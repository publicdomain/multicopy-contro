
namespace MultiCopyContro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.overwriteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.sourceToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sourcerCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.destinationToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.destinationCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.sourceLabel = new System.Windows.Forms.Label();
			this.destionationLabel = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.sourceCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.destinationCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.copyButton = new System.Windows.Forms.Button();
			this.filePatternLlabel = new System.Windows.Forms.Label();
			this.filePatternTextBox = new System.Windows.Forms.TextBox();
			this.folderPatternTextBox = new System.Windows.Forms.TextBox();
			this.filePatternLabel = new System.Windows.Forms.Label();
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.minimizeToolStripMenuItem,
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
			this.mainMenuStrip.TabIndex = 41;
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			this.minimizeToolStripMenuItem.Visible = false;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripSeparator,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem,
									this.overwriteFilesToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// overwriteFilesToolStripMenuItem
			// 
			this.overwriteFilesToolStripMenuItem.Name = "overwriteFilesToolStripMenuItem";
			this.overwriteFilesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.overwriteFilesToolStripMenuItem.Text = "&Overwrite files";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem,
									this.originalThreadDonationCodercomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// weeklyReleasesPublicDomainWeeklycomToolStripMenuItem
			// 
			this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Name = "weeklyReleasesPublicDomainWeeklycomToolStripMenuItem";
			this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
			this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Text = "&Weekly releases @ PublicDomainWeekly.com";
			this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Click += new System.EventHandler(this.WeeklyReleasesPublicDomainWeeklycomToolStripMenuItemClick);
			// 
			// originalThreadDonationCodercomToolStripMenuItem
			// 
			this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
			this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
			this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
			this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
			this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OriginalThreadDonationCodercomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.SourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(310, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sourceToolStripStatusLabel,
									this.sourcerCountToolStripStatusLabel,
									this.destinationToolStripStatusLabel,
									this.destinationCountToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 390);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 40;
			// 
			// sourceToolStripStatusLabel
			// 
			this.sourceToolStripStatusLabel.Name = "sourceToolStripStatusLabel";
			this.sourceToolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
			this.sourceToolStripStatusLabel.Text = "Source:";
			// 
			// sourcerCountToolStripStatusLabel
			// 
			this.sourcerCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.sourcerCountToolStripStatusLabel.Name = "sourcerCountToolStripStatusLabel";
			this.sourcerCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.sourcerCountToolStripStatusLabel.Text = "0";
			// 
			// destinationToolStripStatusLabel
			// 
			this.destinationToolStripStatusLabel.Name = "destinationToolStripStatusLabel";
			this.destinationToolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
			this.destinationToolStripStatusLabel.Text = "Destination:";
			// 
			// destinationCountToolStripStatusLabel
			// 
			this.destinationCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.destinationCountToolStripStatusLabel.Name = "destinationCountToolStripStatusLabel";
			this.destinationCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.destinationCountToolStripStatusLabel.Text = "0";
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 2;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.Controls.Add(this.sourceLabel, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.destionationLabel, 0, 5);
			this.mainTableLayoutPanel.Controls.Add(this.browseButton, 0, 1);
			this.mainTableLayoutPanel.Controls.Add(this.sourceCheckedListBox, 0, 2);
			this.mainTableLayoutPanel.Controls.Add(this.destinationCheckedListBox, 0, 6);
			this.mainTableLayoutPanel.Controls.Add(this.copyButton, 0, 7);
			this.mainTableLayoutPanel.Controls.Add(this.filePatternLlabel, 0, 3);
			this.mainTableLayoutPanel.Controls.Add(this.filePatternTextBox, 0, 4);
			this.mainTableLayoutPanel.Controls.Add(this.folderPatternTextBox, 1, 4);
			this.mainTableLayoutPanel.Controls.Add(this.filePatternLabel, 1, 3);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 8;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 366);
			this.mainTableLayoutPanel.TabIndex = 42;
			// 
			// sourceLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.sourceLabel, 2);
			this.sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sourceLabel.Location = new System.Drawing.Point(3, 0);
			this.sourceLabel.Name = "sourceLabel";
			this.sourceLabel.Size = new System.Drawing.Size(278, 20);
			this.sourceLabel.TabIndex = 0;
			this.sourceLabel.Text = "&Source:";
			this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// destionationLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.destionationLabel, 2);
			this.destionationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destionationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.destionationLabel.Location = new System.Drawing.Point(3, 161);
			this.destionationLabel.Name = "destionationLabel";
			this.destionationLabel.Size = new System.Drawing.Size(278, 20);
			this.destionationLabel.TabIndex = 3;
			this.destionationLabel.Text = "&Destination:";
			this.destionationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// browseButton
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.browseButton, 2);
			this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseButton.Location = new System.Drawing.Point(3, 23);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(278, 24);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "&Browse for \"compo\" folder";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// sourceCheckedListBox
			// 
			this.sourceCheckedListBox.CheckOnClick = true;
			this.mainTableLayoutPanel.SetColumnSpan(this.sourceCheckedListBox, 2);
			this.sourceCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sourceCheckedListBox.FormattingEnabled = true;
			this.sourceCheckedListBox.IntegralHeight = false;
			this.sourceCheckedListBox.Location = new System.Drawing.Point(3, 53);
			this.sourceCheckedListBox.Name = "sourceCheckedListBox";
			this.sourceCheckedListBox.Size = new System.Drawing.Size(278, 60);
			this.sourceCheckedListBox.Sorted = true;
			this.sourceCheckedListBox.TabIndex = 2;
			this.sourceCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SourceCheckedListBoxItemCheck);
			// 
			// destinationCheckedListBox
			// 
			this.destinationCheckedListBox.CheckOnClick = true;
			this.mainTableLayoutPanel.SetColumnSpan(this.destinationCheckedListBox, 2);
			this.destinationCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destinationCheckedListBox.FormattingEnabled = true;
			this.destinationCheckedListBox.IntegralHeight = false;
			this.destinationCheckedListBox.Location = new System.Drawing.Point(3, 184);
			this.destinationCheckedListBox.Name = "destinationCheckedListBox";
			this.destinationCheckedListBox.Size = new System.Drawing.Size(278, 148);
			this.destinationCheckedListBox.Sorted = true;
			this.destinationCheckedListBox.TabIndex = 4;
			this.destinationCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DestinationCheckedListBoxItemCheck);
			// 
			// copyButton
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.copyButton, 2);
			this.copyButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.copyButton.Location = new System.Drawing.Point(3, 338);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(278, 25);
			this.copyButton.TabIndex = 5;
			this.copyButton.Text = "&Copy all checked files";
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.CopyButtonClick);
			// 
			// filePatternLlabel
			// 
			this.filePatternLlabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filePatternLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.filePatternLlabel.Location = new System.Drawing.Point(3, 116);
			this.filePatternLlabel.Name = "filePatternLlabel";
			this.filePatternLlabel.Size = new System.Drawing.Size(136, 20);
			this.filePatternLlabel.TabIndex = 6;
			this.filePatternLlabel.Text = "&File pattern:";
			this.filePatternLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// filePatternTextBox
			// 
			this.filePatternTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filePatternTextBox.Location = new System.Drawing.Point(3, 139);
			this.filePatternTextBox.Name = "filePatternTextBox";
			this.filePatternTextBox.Size = new System.Drawing.Size(136, 20);
			this.filePatternTextBox.TabIndex = 7;
			this.filePatternTextBox.Text = "*.doc*";
			// 
			// folderPatternTextBox
			// 
			this.folderPatternTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.folderPatternTextBox.Location = new System.Drawing.Point(145, 139);
			this.folderPatternTextBox.Name = "folderPatternTextBox";
			this.folderPatternTextBox.Size = new System.Drawing.Size(136, 20);
			this.folderPatternTextBox.TabIndex = 8;
			this.folderPatternTextBox.Text = "*compo*";
			// 
			// filePatternLabel
			// 
			this.filePatternLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filePatternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.filePatternLabel.Location = new System.Drawing.Point(145, 116);
			this.filePatternLabel.Name = "filePatternLabel";
			this.filePatternLabel.Size = new System.Drawing.Size(136, 20);
			this.filePatternLabel.TabIndex = 9;
			this.filePatternLabel.Text = "F&older pattern:";
			this.filePatternLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 412);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MultiCopyContro";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.mainTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem overwriteFilesToolStripMenuItem;
		private System.Windows.Forms.Label filePatternLabel;
		private System.Windows.Forms.TextBox folderPatternTextBox;
		private System.Windows.Forms.TextBox filePatternTextBox;
		private System.Windows.Forms.Label filePatternLlabel;
		private System.Windows.Forms.Button copyButton;
		private System.Windows.Forms.CheckedListBox destinationCheckedListBox;
		private System.Windows.Forms.CheckedListBox sourceCheckedListBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label destionationLabel;
		private System.Windows.Forms.Label sourceLabel;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.ToolStripStatusLabel destinationCountToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel destinationToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel sourcerCountToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel sourceToolStripStatusLabel;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem weeklyReleasesPublicDomainWeeklycomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
	}
}
