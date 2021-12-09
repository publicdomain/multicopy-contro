
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using PublicDomainWeekly;

namespace MultiCopyContro
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The checking destination checked list box.
        /// </summary>
        bool checkingDestinatinCheckedListBox = false;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MultiCopyContro.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain weekly tool strip menu item image
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        void BrowseButtonClick(object sender, EventArgs e)
        {
            this.ProcessNew();

            this.folderBrowserDialog.ShowDialog();

            if (this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                this.sourceCheckedListBox.Items.AddRange(Directory.GetFiles(this.folderBrowserDialog.SelectedPath, this.filePatternTextBox.Text, SearchOption.TopDirectoryOnly));

                this.sourcerCountToolStripStatusLabel.Text = $"0/{this.sourceCheckedListBox.Items.Count}";
            }
        }

        void SourceCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update count
            this.sourcerCountToolStripStatusLabel.Text = $"{this.sourceCheckedListBox.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1)}/{this.sourceCheckedListBox.Items.Count}";

            // Declare source file list
            var sourceFileList = new List<string>();

            // Add to source file list
            sourceFileList.AddRange(this.sourceCheckedListBox.CheckedItems.Cast<string>().ToList());

            // Set selected item 
            string checkedItem = this.sourceCheckedListBox.Items[e.Index].ToString();

            // Add or subtract item
            if (e.NewValue == CheckState.Checked)
            {
                sourceFileList.Add(checkedItem);
            }
            else
            {
                sourceFileList.Remove(checkedItem);
            }

            // Begin update
            this.destinationCheckedListBox.BeginUpdate();

            // Clear destionation list
            this.destinationCheckedListBox.Items.Clear();

            // Check there's something to work with
            if (sourceFileList.Count > 0)
            {
                // Set source dir
                string sourceDir = Directory.GetParent(Directory.GetParent(this.folderBrowserDialog.SelectedPath).ToString()).ToString();

                // Iterate /exp<year>
                foreach (var expYearDirectory in Directory.GetDirectories(sourceDir, "*", SearchOption.TopDirectoryOnly))
                {
                    // TODO Exclude selected path [can be improved witha list, by removal]
                    if (this.folderBrowserDialog.SelectedPath.IndexOf(expYearDirectory, StringComparison.InvariantCulture) == 0)
                    {
                        // Skip iteration
                        continue;
                    }

                    // Get *compo* matching dir
                    foreach (var compoDirectory in Directory.GetDirectories(expYearDirectory, this.folderPatternTextBox.Text, SearchOption.TopDirectoryOnly))
                    {
                        // Check if empty
                        if (Directory.GetFiles(compoDirectory, "*", SearchOption.TopDirectoryOnly).Any())
                        {
                            // Add to destionation list
                            foreach (var sourceFile in sourceFileList)
                            {
                                ListViewItem destItem = new ListViewItem(Path.Combine(compoDirectory, Path.GetFileName(sourceFile)))
                                {
                                    Tag = sourceFile
                                };

                                this.destinationCheckedListBox.Items.Add(destItem);
                            }
                        }
                    }
                }

                // Toggle checking flag
                this.checkingDestinatinCheckedListBox = true;

                // Check all items in destionation checked list box
                for (int i = 0; i < this.destinationCheckedListBox.Items.Count; i++)
                {
                    this.destinationCheckedListBox.SetItemChecked(i, true);
                }

                // Reset checking flag
                this.checkingDestinatinCheckedListBox = false;
            }

            // End update
            this.destinationCheckedListBox.EndUpdate();

            // Update count
            this.destinationCountToolStripStatusLabel.Text = $"{this.destinationCheckedListBox.CheckedItems.Count}/{this.destinationCheckedListBox.Items.Count}";
        }

        void DestinationCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Prevent hangilng by initial checking 
            if (this.checkingDestinatinCheckedListBox)
            {
                return;
            }

            // Update count
            this.destinationCountToolStripStatusLabel.Text = $"{this.destinationCheckedListBox.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1)}/{this.destinationCheckedListBox.Items.Count}";
        }

        void CopyButtonClick(object sender, EventArgs e)
        {
            if (this.destinationCheckedListBox.CheckedItems.Count > 0)
            {
                foreach (ListViewItem destinationItem in this.destinationCheckedListBox.CheckedItems)
                {
                    try
                    {
                        /* Copy */

                        var sourceFile = destinationItem.Tag.ToString();
                        var destinationFile = destinationItem.Text;

                        // Check if file exists
                        if (File.Exists(destinationFile))
                        {
                            // Check if must overwrite
                            if (this.overwriteFilesToolStripMenuItem.Checked)
                            {
                                // set now
                                var now = DateTime.Now;

                                // Check if source is newer
                                if (File.GetLastWriteTimeUtc(sourceFile) > File.GetLastWriteTimeUtc(destinationFile))

                                    // Check if must backup
                                    if (this.backupOnOverwriteToolStripMenuItem.Checked)
                                    {
                                        // Set destination directory
                                        string destinationDirectory = Path.GetDirectoryName(destinationFile);

                                        // Set backups directory
                                        string backupDirectory = Path.Combine(destinationDirectory, "Backups", now.ToString("yyyy-MM-dd"));

                                        // Create "Backups" directory
                                        Directory.CreateDirectory(backupDirectory);

                                        // Create timestamped backup directory for destination file
                                        string timestampedDirectory = Path.Combine(backupDirectory, now.ToString("yyyy-MM-dd_HH-mm-ss_fffffff"));

                                        // Create timestamped destination directory
                                        Directory.CreateDirectory(timestampedDirectory);

                                        // TODO Copy file to timestamped backup folder [Can be refactored for a move]
                                        File.Copy(destinationFile, Path.Combine(timestampedDirectory, destinationFile));
                                    }

                                // Copy file
                                File.Copy(sourceFile, destinationFile, true);
                            }
                        }
                        else
                        {
                            // Copy new file
                            File.Copy(sourceFile, destinationFile);
                        }
                    }
                    catch
                    {
                        // TODO Log or act upon it
                        ;
                    }
                }

                // Advise user
                MessageBox.Show($"{this.destinationCheckedListBox.CheckedItems.Count} checked items processed.", "Copy executed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void NewToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.ProcessNew();
        }

        void ProcessNew()
        {
            this.folderBrowserDialog.SelectedPath = string.Empty;

            this.sourceCheckedListBox.Items.Clear();

            this.destinationCheckedListBox.Items.Clear();
        }

        void OptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        void WeeklyReleasesPublicDomainWeeklycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        void OriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=51778.0");
        }

        void SourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/multicopy-contro");
        }

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Archive drawer Icon by OpenClipart-Vectors - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/archive-drawer-file-cabinet-154686/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P{Environment.NewLine} Raster d.o.o.{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: Contro{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #342, Week #49 @ December 08, 2021",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
