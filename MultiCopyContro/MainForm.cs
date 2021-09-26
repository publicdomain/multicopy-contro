
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

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
            this.folderBrowserDialog.SelectedPath = string.Empty;

            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
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
                                this.destinationCheckedListBox.Items.Add(Path.Combine(compoDirectory, Path.GetFileName(sourceFile)));
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

            // Update status
            this.destinationCountToolStripStatusLabel.Text = $"0/{this.destinationCheckedListBox.Items.Count}";
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

        }

        void NewToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void OptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        void WeeklyReleasesPublicDomainWeeklycomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void OriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void SourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
    }
}
