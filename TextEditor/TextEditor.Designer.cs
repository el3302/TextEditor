namespace TextEditor
{
    partial class textEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textEditor));
            this.txt = new System.Windows.Forms.RichTextBox();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cmSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dOpen = new System.Windows.Forms.OpenFileDialog();
            this.dSave = new System.Windows.Forms.SaveFileDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mInsertDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mSpelling = new System.Windows.Forms.ToolStripMenuItem();
            this.mFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mInsertLink = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mAboutComTech = new System.Windows.Forms.ToolStripMenuItem();
            this.mReleaseNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.dPrint = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.dFont = new System.Windows.Forms.FontDialog();
            this.dColor = new System.Windows.Forms.ColorDialog();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.dPrintSetup = new System.Windows.Forms.PageSetupDialog();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tFont = new System.Windows.Forms.ToolStripDropDownButton();
            this.font1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tFontSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tBold = new System.Windows.Forms.ToolStripButton();
            this.tItalic = new System.Windows.Forms.ToolStripButton();
            this.tUnderline = new System.Windows.Forms.ToolStripButton();
            this.cMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.ContextMenuStrip = this.cMenu;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(0, 24);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(907, 599);
            this.txt.TabIndex = 5;
            this.txt.Text = "";
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmCut,
            this.cmCopy,
            this.cmPaste,
            this.toolStripSeparator8,
            this.cmSourceCode,
            this.toolStripSeparator9,
            this.cmClose});
            this.cMenu.Name = "cMenu";
            this.cMenu.ShowImageMargin = false;
            this.cMenu.Size = new System.Drawing.Size(117, 126);
            this.cMenu.Text = "Contextual Menu";
            // 
            // cmCut
            // 
            this.cmCut.Name = "cmCut";
            this.cmCut.Size = new System.Drawing.Size(116, 22);
            this.cmCut.Text = "Cut";
            this.cmCut.Click += new System.EventHandler(this.cmCut_Click);
            // 
            // cmCopy
            // 
            this.cmCopy.Name = "cmCopy";
            this.cmCopy.Size = new System.Drawing.Size(116, 22);
            this.cmCopy.Text = "Copy";
            this.cmCopy.Click += new System.EventHandler(this.cmCopy_Click);
            // 
            // cmPaste
            // 
            this.cmPaste.Name = "cmPaste";
            this.cmPaste.Size = new System.Drawing.Size(116, 22);
            this.cmPaste.Text = "Paste";
            this.cmPaste.Click += new System.EventHandler(this.cmPaste_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(113, 6);
            // 
            // cmSourceCode
            // 
            this.cmSourceCode.Name = "cmSourceCode";
            this.cmSourceCode.Size = new System.Drawing.Size(116, 22);
            this.cmSourceCode.Text = "Source Code";
            this.cmSourceCode.Click += new System.EventHandler(this.cmSourceCode_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(113, 6);
            // 
            // cmClose
            // 
            this.cmClose.Name = "cmClose";
            this.cmClose.Size = new System.Drawing.Size(116, 22);
            this.cmClose.Text = "Exit";
            this.cmClose.Click += new System.EventHandler(this.cmClose_Click);
            // 
            // dOpen
            // 
            this.dOpen.Title = "Select file to open";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(907, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNew,
            this.mOpen,
            this.toolStripSeparator,
            this.mSave,
            this.mSaveAs,
            this.toolStripSeparator1,
            this.mPrint,
            this.toolStripSeparator2,
            this.mExit});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // mNew
            // 
            this.mNew.Image = ((System.Drawing.Image)(resources.GetObject("mNew.Image")));
            this.mNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mNew.Name = "mNew";
            this.mNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mNew.Size = new System.Drawing.Size(146, 22);
            this.mNew.Text = "&New";
            this.mNew.Click += new System.EventHandler(this.mNew_Click);
            // 
            // mOpen
            // 
            this.mOpen.Image = ((System.Drawing.Image)(resources.GetObject("mOpen.Image")));
            this.mOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mOpen.Name = "mOpen";
            this.mOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mOpen.Size = new System.Drawing.Size(146, 22);
            this.mOpen.Text = "&Open";
            this.mOpen.Click += new System.EventHandler(this.mOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // mSave
            // 
            this.mSave.Image = ((System.Drawing.Image)(resources.GetObject("mSave.Image")));
            this.mSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSave.Name = "mSave";
            this.mSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mSave.Size = new System.Drawing.Size(146, 22);
            this.mSave.Text = "&Save";
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // mSaveAs
            // 
            this.mSaveAs.Name = "mSaveAs";
            this.mSaveAs.Size = new System.Drawing.Size(146, 22);
            this.mSaveAs.Text = "Save As";
            this.mSaveAs.Click += new System.EventHandler(this.mSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // mPrint
            // 
            this.mPrint.Image = ((System.Drawing.Image)(resources.GetObject("mPrint.Image")));
            this.mPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mPrint.Name = "mPrint";
            this.mPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mPrint.Size = new System.Drawing.Size(146, 22);
            this.mPrint.Text = "&Print";
            this.mPrint.Click += new System.EventHandler(this.mPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(146, 22);
            this.mExit.Text = "E&xit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUndo,
            this.toolStripSeparator3,
            this.mCut,
            this.mCopy,
            this.mPaste,
            this.toolStripSeparator4,
            this.mSelectAll,
            this.toolStripSeparator5,
            this.mInsertDateTime});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // mUndo
            // 
            this.mUndo.Name = "mUndo";
            this.mUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mUndo.Size = new System.Drawing.Size(199, 22);
            this.mUndo.Text = "&Undo";
            this.mUndo.Click += new System.EventHandler(this.mUndo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // mCut
            // 
            this.mCut.Image = ((System.Drawing.Image)(resources.GetObject("mCut.Image")));
            this.mCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mCut.Name = "mCut";
            this.mCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mCut.Size = new System.Drawing.Size(199, 22);
            this.mCut.Text = "Cu&t";
            this.mCut.Click += new System.EventHandler(this.mCut_Click);
            // 
            // mCopy
            // 
            this.mCopy.Image = ((System.Drawing.Image)(resources.GetObject("mCopy.Image")));
            this.mCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mCopy.Name = "mCopy";
            this.mCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mCopy.Size = new System.Drawing.Size(199, 22);
            this.mCopy.Text = "&Copy";
            this.mCopy.Click += new System.EventHandler(this.mCopy_Click);
            // 
            // mPaste
            // 
            this.mPaste.Image = ((System.Drawing.Image)(resources.GetObject("mPaste.Image")));
            this.mPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mPaste.Name = "mPaste";
            this.mPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mPaste.Size = new System.Drawing.Size(199, 22);
            this.mPaste.Text = "&Paste";
            this.mPaste.Click += new System.EventHandler(this.mPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // mSelectAll
            // 
            this.mSelectAll.Name = "mSelectAll";
            this.mSelectAll.Size = new System.Drawing.Size(199, 22);
            this.mSelectAll.Text = "Select &All";
            this.mSelectAll.Click += new System.EventHandler(this.mSelectAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(196, 6);
            // 
            // mInsertDateTime
            // 
            this.mInsertDateTime.Name = "mInsertDateTime";
            this.mInsertDateTime.ShortcutKeyDisplayString = "";
            this.mInsertDateTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mInsertDateTime.Size = new System.Drawing.Size(199, 22);
            this.mInsertDateTime.Text = "&Insert Date/Time";
            this.mInsertDateTime.Click += new System.EventHandler(this.mInsertDateTime_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFont,
            this.mToolbar,
            this.toolStripSeparator6,
            this.mSpelling,
            this.mFind,
            this.toolStripSeparator7,
            this.mInsertLink});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fontToolStripMenuItem.Text = "Tools";
            // 
            // mFont
            // 
            this.mFont.Name = "mFont";
            this.mFont.Size = new System.Drawing.Size(202, 22);
            this.mFont.Text = "Font";
            this.mFont.Click += new System.EventHandler(this.mFont_Click);
            // 
            // mToolbar
            // 
            this.mToolbar.Name = "mToolbar";
            this.mToolbar.Size = new System.Drawing.Size(202, 22);
            this.mToolbar.Text = "Text Formatting Toolbar";
            this.mToolbar.Click += new System.EventHandler(this.mToolbar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(199, 6);
            // 
            // mSpelling
            // 
            this.mSpelling.Enabled = false;
            this.mSpelling.Name = "mSpelling";
            this.mSpelling.Size = new System.Drawing.Size(202, 22);
            this.mSpelling.Text = "Spelling";
            // 
            // mFind
            // 
            this.mFind.Enabled = false;
            this.mFind.Name = "mFind";
            this.mFind.Size = new System.Drawing.Size(202, 22);
            this.mFind.Text = "Find";
            this.mFind.Click += new System.EventHandler(this.mFind_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(199, 6);
            // 
            // mInsertLink
            // 
            this.mInsertLink.Enabled = false;
            this.mInsertLink.Name = "mInsertLink";
            this.mInsertLink.Size = new System.Drawing.Size(202, 22);
            this.mInsertLink.Text = "Insert Link";
            this.mInsertLink.Click += new System.EventHandler(this.mInsertLink_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAbout,
            this.mAboutComTech,
            this.mReleaseNotes});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mAbout.Size = new System.Drawing.Size(231, 22);
            this.mAbout.Text = "&About This App";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // mAboutComTech
            // 
            this.mAboutComTech.Name = "mAboutComTech";
            this.mAboutComTech.Size = new System.Drawing.Size(231, 22);
            this.mAboutComTech.Text = "About ComTech";
            this.mAboutComTech.Click += new System.EventHandler(this.mAboutComTech_Click);
            // 
            // mReleaseNotes
            // 
            this.mReleaseNotes.Name = "mReleaseNotes";
            this.mReleaseNotes.Size = new System.Drawing.Size(231, 22);
            this.mReleaseNotes.Text = "Release Notes";
            this.mReleaseNotes.Click += new System.EventHandler(this.mReleaseNotes_Click);
            // 
            // dPrint
            // 
            this.dPrint.Document = this.printDocument;
            this.dPrint.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.OriginAtMargins = true;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Black;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(0, 603);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(907, 20);
            this.txtMessage.TabIndex = 9;
            this.txtMessage.Text = "Ready, willing and sort of able!";
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tFont,
            this.tFontSize,
            this.toolStripSeparator10,
            this.tBold,
            this.tItalic,
            this.tUnderline});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(907, 25);
            this.toolbar.TabIndex = 10;
            this.toolbar.Text = "toolStrip1";
            this.toolbar.Visible = false;
            // 
            // tFont
            // 
            this.tFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font1ToolStripMenuItem,
            this.font2ToolStripMenuItem,
            this.font3ToolStripMenuItem});
            this.tFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tFont.Name = "tFont";
            this.tFont.Size = new System.Drawing.Size(78, 22);
            this.tFont.Text = "Select Font";
            this.tFont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // font1ToolStripMenuItem
            // 
            this.font1ToolStripMenuItem.Name = "font1ToolStripMenuItem";
            this.font1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.font1ToolStripMenuItem.Text = "Font1";
            // 
            // font2ToolStripMenuItem
            // 
            this.font2ToolStripMenuItem.Name = "font2ToolStripMenuItem";
            this.font2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.font2ToolStripMenuItem.Text = "Font2";
            // 
            // font3ToolStripMenuItem
            // 
            this.font3ToolStripMenuItem.Name = "font3ToolStripMenuItem";
            this.font3ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.font3ToolStripMenuItem.Text = "Font3";
            // 
            // tFontSize
            // 
            this.tFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptToolStripMenuItem,
            this.ptToolStripMenuItem1,
            this.ptToolStripMenuItem2,
            this.ptToolStripMenuItem3});
            this.tFontSize.Image = ((System.Drawing.Image)(resources.GetObject("tFontSize.Image")));
            this.tFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tFontSize.Name = "tFontSize";
            this.tFontSize.Size = new System.Drawing.Size(67, 22);
            this.tFontSize.Text = "Font Size";
            // 
            // ptToolStripMenuItem
            // 
            this.ptToolStripMenuItem.Name = "ptToolStripMenuItem";
            this.ptToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.ptToolStripMenuItem.Text = "12pt";
            // 
            // ptToolStripMenuItem1
            // 
            this.ptToolStripMenuItem1.Name = "ptToolStripMenuItem1";
            this.ptToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.ptToolStripMenuItem1.Text = "14pt";
            // 
            // ptToolStripMenuItem2
            // 
            this.ptToolStripMenuItem2.Name = "ptToolStripMenuItem2";
            this.ptToolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.ptToolStripMenuItem2.Text = "16pt";
            // 
            // ptToolStripMenuItem3
            // 
            this.ptToolStripMenuItem3.Name = "ptToolStripMenuItem3";
            this.ptToolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.ptToolStripMenuItem3.Text = "24pt";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tBold
            // 
            this.tBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tBold.Image = ((System.Drawing.Image)(resources.GetObject("tBold.Image")));
            this.tBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBold.Name = "tBold";
            this.tBold.Size = new System.Drawing.Size(23, 22);
            this.tBold.Text = "B";
            this.tBold.ToolTipText = "Bold";
            this.tBold.Click += new System.EventHandler(this.tBold_Click);
            // 
            // tItalic
            // 
            this.tItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tItalic.Image = ((System.Drawing.Image)(resources.GetObject("tItalic.Image")));
            this.tItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tItalic.Name = "tItalic";
            this.tItalic.Size = new System.Drawing.Size(23, 22);
            this.tItalic.Text = "I";
            this.tItalic.ToolTipText = "Italic";
            this.tItalic.Click += new System.EventHandler(this.tItalic_Click);
            // 
            // tUnderline
            // 
            this.tUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tUnderline.Image")));
            this.tUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tUnderline.Name = "tUnderline";
            this.tUnderline.Size = new System.Drawing.Size(23, 22);
            this.tUnderline.Text = "U";
            this.tUnderline.ToolTipText = "Underline";
            this.tUnderline.Click += new System.EventHandler(this.tUnderline_Click);
            // 
            // textEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 623);
            this.ContextMenuStrip = this.cMenu;
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "textEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComTech Text Editor";
            this.cMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.OpenFileDialog dOpen;
        private System.Windows.Forms.SaveFileDialog dSave;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripMenuItem mOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mCut;
        private System.Windows.Forms.ToolStripMenuItem mCopy;
        private System.Windows.Forms.ToolStripMenuItem mPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mSelectAll;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mInsertDateTime;
        private System.Windows.Forms.PrintDialog dPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripMenuItem mSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mFont;
        private System.Windows.Forms.FontDialog dFont;
        private System.Windows.Forms.ColorDialog dColor;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem cmSourceCode;
        private System.Windows.Forms.ToolStripMenuItem cmClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mInsertLink;
        private System.Windows.Forms.ToolStripMenuItem cmCut;
        private System.Windows.Forms.ToolStripMenuItem cmCopy;
        private System.Windows.Forms.ToolStripMenuItem cmPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mAboutComTech;
        private System.Windows.Forms.ToolStripMenuItem mSpelling;
        private System.Windows.Forms.PageSetupDialog dPrintSetup;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripDropDownButton tFont;
        private System.Windows.Forms.ToolStripMenuItem font1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem font2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem font3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tFontSize;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tBold;
        private System.Windows.Forms.ToolStripButton tItalic;
        private System.Windows.Forms.ToolStripButton tUnderline;
        private System.Windows.Forms.ToolStripMenuItem mToolbar;
        private System.Windows.Forms.ToolStripMenuItem mReleaseNotes;
    }
}

