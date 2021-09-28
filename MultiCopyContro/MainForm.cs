
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

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

        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
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
                        // Copy
                        File.Copy(destinationItem.Tag.ToString(), destinationItem.Text, this.overwriteFilesToolStripMenuItem.Checked);
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
            // Open our public domain website
            Process.Start("https://publicdomainweekly.com");
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

        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
