
namespace MyFormsApp_ILMerge
{
    partial class MainWindow
    {
///  <summary> Required designer variable. </summary>
        private System.ComponentModel.IContainer components = null;

///  <summary> Clean up any resources being used. </summary> <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

///  <summary> Required method for Designer support - do not modify the contents of this method with the code editor. </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.filePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.filePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.editRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.sep6 = new System.Windows.Forms.ToolStripSeparator();
            this.editCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.sep7 = new System.Windows.Forms.ToolStripSeparator();
            this.editSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsCustomize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.helpIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.sep8 = new System.Windows.Forms.ToolStripSeparator();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileNewButton = new System.Windows.Forms.ToolStripButton();
            this.fileOpenButton = new System.Windows.Forms.ToolStripButton();
            this.fileSaveButton = new System.Windows.Forms.ToolStripButton();
            this.filePrintButton = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.editCutButton = new System.Windows.Forms.ToolStripButton();
            this.editCopyButton = new System.Windows.Forms.ToolStripButton();
            this.editPasteButton = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpAboutButton = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.messageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileContentTextBox = new System.Windows.Forms.TextBox();
            this.fileContentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu.SuspendLayout();
            this.standardToolStrip.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.helpMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(742, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.sep3,
            this.fileSave,
            this.fileSaveAs,
            this.sep4,
            this.filePrint,
            this.filePrintPreview,
            this.sep5,
            this.fileExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileNew
            // 
            this.fileNew.Enabled = false;
            this.fileNew.Image = ((System.Drawing.Image)(resources.GetObject("fileNew.Image")));
            this.fileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileNew.Name = "fileNew";
            this.fileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNew.Size = new System.Drawing.Size(150, 26);
            this.fileNew.Text = "&New";
            // 
            // fileOpen
            // 
            this.fileOpen.Image = ((System.Drawing.Image)(resources.GetObject("fileOpen.Image")));
            this.fileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(150, 26);
            this.fileOpen.Text = "&Open";
            this.fileOpen.Click += new System.EventHandler(this.OnFileOpen);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(147, 6);
            // 
            // fileSave
            // 
            this.fileSave.Enabled = false;
            this.fileSave.Image = ((System.Drawing.Image)(resources.GetObject("fileSave.Image")));
            this.fileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSave.Name = "fileSave";
            this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSave.Size = new System.Drawing.Size(150, 26);
            this.fileSave.Text = "&Save";
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Enabled = false;
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.Size = new System.Drawing.Size(150, 26);
            this.fileSaveAs.Text = "Save &As";
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(147, 6);
            // 
            // filePrint
            // 
            this.filePrint.Enabled = false;
            this.filePrint.Image = ((System.Drawing.Image)(resources.GetObject("filePrint.Image")));
            this.filePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrint.Name = "filePrint";
            this.filePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.filePrint.Size = new System.Drawing.Size(150, 26);
            this.filePrint.Text = "&Print";
            // 
            // filePrintPreview
            // 
            this.filePrintPreview.Enabled = false;
            this.filePrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("filePrintPreview.Image")));
            this.filePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrintPreview.Name = "filePrintPreview";
            this.filePrintPreview.Size = new System.Drawing.Size(150, 26);
            this.filePrintPreview.Text = "Print Pre&view";
            // 
            // sep5
            // 
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(147, 6);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(150, 26);
            this.fileExit.Text = "E&xit";
            this.fileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUndo,
            this.editRedo,
            this.sep6,
            this.editCut,
            this.editCopy,
            this.editPaste,
            this.sep7,
            this.editSelectAll});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // editUndo
            // 
            this.editUndo.Enabled = false;
            this.editUndo.Name = "editUndo";
            this.editUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editUndo.Size = new System.Drawing.Size(148, 26);
            this.editUndo.Text = "&Undo";
            // 
            // editRedo
            // 
            this.editRedo.Enabled = false;
            this.editRedo.Name = "editRedo";
            this.editRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.editRedo.Size = new System.Drawing.Size(148, 26);
            this.editRedo.Text = "&Redo";
            // 
            // sep6
            // 
            this.sep6.Name = "sep6";
            this.sep6.Size = new System.Drawing.Size(145, 6);
            // 
            // editCut
            // 
            this.editCut.Enabled = false;
            this.editCut.Image = ((System.Drawing.Image)(resources.GetObject("editCut.Image")));
            this.editCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCut.Name = "editCut";
            this.editCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCut.Size = new System.Drawing.Size(148, 26);
            this.editCut.Text = "Cu&t";
            // 
            // editCopy
            // 
            this.editCopy.Enabled = false;
            this.editCopy.Image = ((System.Drawing.Image)(resources.GetObject("editCopy.Image")));
            this.editCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCopy.Name = "editCopy";
            this.editCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopy.Size = new System.Drawing.Size(148, 26);
            this.editCopy.Text = "&Copy";
            // 
            // editPaste
            // 
            this.editPaste.Enabled = false;
            this.editPaste.Image = ((System.Drawing.Image)(resources.GetObject("editPaste.Image")));
            this.editPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPaste.Name = "editPaste";
            this.editPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editPaste.Size = new System.Drawing.Size(148, 26);
            this.editPaste.Text = "&Paste";
            // 
            // sep7
            // 
            this.sep7.Name = "sep7";
            this.sep7.Size = new System.Drawing.Size(145, 6);
            // 
            // editSelectAll
            // 
            this.editSelectAll.Enabled = false;
            this.editSelectAll.Name = "editSelectAll";
            this.editSelectAll.Size = new System.Drawing.Size(148, 26);
            this.editSelectAll.Text = "Select &All";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolbar,
            this.viewStatusBar});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // viewToolbar
            // 
            this.viewToolbar.Checked = true;
            this.viewToolbar.CheckOnClick = true;
            this.viewToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolbar.Name = "viewToolbar";
            this.viewToolbar.Size = new System.Drawing.Size(126, 22);
            this.viewToolbar.Text = "&Toolbar";
            this.viewToolbar.Click += new System.EventHandler(this.OnViewToolbar);
            // 
            // viewStatusBar
            // 
            this.viewStatusBar.Checked = true;
            this.viewStatusBar.CheckOnClick = true;
            this.viewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewStatusBar.Name = "viewStatusBar";
            this.viewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.viewStatusBar.Text = "&Status Bar";
            this.viewStatusBar.Click += new System.EventHandler(this.OnViewStatusBar);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsCustomize,
            this.toolsOptions});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // toolsCustomize
            // 
            this.toolsCustomize.Enabled = false;
            this.toolsCustomize.Name = "toolsCustomize";
            this.toolsCustomize.Size = new System.Drawing.Size(130, 22);
            this.toolsCustomize.Text = "&Customize";
            // 
            // toolsOptions
            // 
            this.toolsOptions.Enabled = false;
            this.toolsOptions.Name = "toolsOptions";
            this.toolsOptions.Size = new System.Drawing.Size(130, 22);
            this.toolsOptions.Text = "&Options";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContents,
            this.helpIndex,
            this.helpSearch,
            this.sep8,
            this.helpAbout});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // helpContents
            // 
            this.helpContents.Enabled = false;
            this.helpContents.Name = "helpContents";
            this.helpContents.Size = new System.Drawing.Size(122, 22);
            this.helpContents.Text = "&Contents";
            // 
            // helpIndex
            // 
            this.helpIndex.Enabled = false;
            this.helpIndex.Name = "helpIndex";
            this.helpIndex.Size = new System.Drawing.Size(122, 22);
            this.helpIndex.Text = "&Index";
            // 
            // helpSearch
            // 
            this.helpSearch.Enabled = false;
            this.helpSearch.Name = "helpSearch";
            this.helpSearch.Size = new System.Drawing.Size(122, 22);
            this.helpSearch.Text = "&Search";
            // 
            // sep8
            // 
            this.sep8.Name = "sep8";
            this.sep8.Size = new System.Drawing.Size(119, 6);
            // 
            // helpAbout
            // 
            this.helpAbout.Enabled = false;
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(122, 22);
            this.helpAbout.Text = "&About...";
            // 
            // standardToolStrip
            // 
            this.standardToolStrip.AutoSize = false;
            this.standardToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.standardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewButton,
            this.fileOpenButton,
            this.fileSaveButton,
            this.filePrintButton,
            this.sep1,
            this.editCutButton,
            this.editCopyButton,
            this.editPasteButton,
            this.sep2,
            this.helpAboutButton});
            this.standardToolStrip.Location = new System.Drawing.Point(0, 24);
            this.standardToolStrip.Name = "standardToolStrip";
            this.standardToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.standardToolStrip.Size = new System.Drawing.Size(742, 27);
            this.standardToolStrip.TabIndex = 1;
            this.standardToolStrip.Text = "toolStrip1";
            // 
            // fileNewButton
            // 
            this.fileNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileNewButton.Enabled = false;
            this.fileNewButton.Image = ((System.Drawing.Image)(resources.GetObject("fileNewButton.Image")));
            this.fileNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileNewButton.Name = "fileNewButton";
            this.fileNewButton.Size = new System.Drawing.Size(24, 24);
            this.fileNewButton.Text = "&New";
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("fileOpenButton.Image")));
            this.fileOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(24, 24);
            this.fileOpenButton.Text = "&Open";
            this.fileOpenButton.Click += new System.EventHandler(this.OnFileOpen);
            // 
            // fileSaveButton
            // 
            this.fileSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileSaveButton.Enabled = false;
            this.fileSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("fileSaveButton.Image")));
            this.fileSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSaveButton.Name = "fileSaveButton";
            this.fileSaveButton.Size = new System.Drawing.Size(24, 24);
            this.fileSaveButton.Text = "&Save";
            // 
            // filePrintButton
            // 
            this.filePrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filePrintButton.Enabled = false;
            this.filePrintButton.Image = ((System.Drawing.Image)(resources.GetObject("filePrintButton.Image")));
            this.filePrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filePrintButton.Name = "filePrintButton";
            this.filePrintButton.Size = new System.Drawing.Size(24, 24);
            this.filePrintButton.Text = "&Print";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 27);
            // 
            // editCutButton
            // 
            this.editCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editCutButton.Enabled = false;
            this.editCutButton.Image = ((System.Drawing.Image)(resources.GetObject("editCutButton.Image")));
            this.editCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCutButton.Name = "editCutButton";
            this.editCutButton.Size = new System.Drawing.Size(24, 24);
            this.editCutButton.Text = "C&ut";
            // 
            // editCopyButton
            // 
            this.editCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editCopyButton.Enabled = false;
            this.editCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("editCopyButton.Image")));
            this.editCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCopyButton.Name = "editCopyButton";
            this.editCopyButton.Size = new System.Drawing.Size(24, 24);
            this.editCopyButton.Text = "&Copy";
            // 
            // editPasteButton
            // 
            this.editPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPasteButton.Enabled = false;
            this.editPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("editPasteButton.Image")));
            this.editPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPasteButton.Name = "editPasteButton";
            this.editPasteButton.Size = new System.Drawing.Size(24, 24);
            this.editPasteButton.Text = "&Paste";
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 27);
            // 
            // helpAboutButton
            // 
            this.helpAboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpAboutButton.Enabled = false;
            this.helpAboutButton.Image = ((System.Drawing.Image)(resources.GetObject("helpAboutButton.Image")));
            this.helpAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpAboutButton.Name = "helpAboutButton";
            this.helpAboutButton.Size = new System.Drawing.Size(24, 24);
            this.helpAboutButton.Text = "He&lp";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 415);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusBar.Size = new System.Drawing.Size(742, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // messageLabel
            // 
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(730, 17);
            this.messageLabel.Spring = true;
            this.messageLabel.Text = "Ready";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileContentTextBox
            // 
            this.fileContentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fileContentsBindingSource, "FileContents", true));
            this.fileContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileContentTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContentTextBox.Location = new System.Drawing.Point(0, 51);
            this.fileContentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileContentTextBox.Multiline = true;
            this.fileContentTextBox.Name = "fileContentTextBox";
            this.fileContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileContentTextBox.Size = new System.Drawing.Size(742, 364);
            this.fileContentTextBox.TabIndex = 3;
            // 
            // fileContentsBindingSource
            // 
            this.fileContentsBindingSource.DataSource = typeof(MyFormsApp_ILMerge.Documents.Interfaces.IDocument);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "*.txt";
            this.openFileDialog.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            this.openFileDialog.Title = "Open File";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(742, 437);
            this.Controls.Add(this.fileContentTextBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.standardToolStrip);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ILMerge Demo Application";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.standardToolStrip.ResumeLayout(false);
            this.standardToolStrip.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripMenuItem filePrint;
        private System.Windows.Forms.ToolStripMenuItem filePrintPreview;
        private System.Windows.Forms.ToolStripSeparator sep5;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem editUndo;
        private System.Windows.Forms.ToolStripMenuItem editRedo;
        private System.Windows.Forms.ToolStripSeparator sep6;
        private System.Windows.Forms.ToolStripMenuItem editCut;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripSeparator sep7;
        private System.Windows.Forms.ToolStripMenuItem editSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsCustomize;
        private System.Windows.Forms.ToolStripMenuItem toolsOptions;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpContents;
        private System.Windows.Forms.ToolStripMenuItem helpIndex;
        private System.Windows.Forms.ToolStripMenuItem helpSearch;
        private System.Windows.Forms.ToolStripSeparator sep8;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolbar;
        private System.Windows.Forms.ToolStripMenuItem viewStatusBar;
        private System.Windows.Forms.ToolStrip standardToolStrip;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel messageLabel;
        private System.Windows.Forms.TextBox fileContentTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource fileContentsBindingSource;
        private System.Windows.Forms.ToolStripButton fileNewButton;
        private System.Windows.Forms.ToolStripButton fileOpenButton;
        private System.Windows.Forms.ToolStripButton fileSaveButton;
        private System.Windows.Forms.ToolStripButton filePrintButton;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton editCutButton;
        private System.Windows.Forms.ToolStripButton editCopyButton;
        private System.Windows.Forms.ToolStripButton editPasteButton;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripButton helpAboutButton;
    }
}
