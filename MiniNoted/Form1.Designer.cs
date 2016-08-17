namespace MiniNoted
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.replace = new System.Windows.Forms.ToolStripMenuItem();
            this.goTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asm = new System.Windows.Forms.ToolStripMenuItem();
            this.CSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.cpp = new System.Windows.Forms.ToolStripMenuItem();
            this.HTML = new System.Windows.Forms.ToolStripMenuItem();
            this.INI = new System.Windows.Forms.ToolStripMenuItem();
            this.js = new System.Windows.Forms.ToolStripMenuItem();
            this.Python = new System.Windows.Forms.ToolStripMenuItem();
            this.PlainText = new System.Windows.Forms.ToolStripMenuItem();
            this.SQL = new System.Windows.Forms.ToolStripMenuItem();
            this.MSSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.VBScript = new System.Windows.Forms.ToolStripMenuItem();
            this.XML = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.autoEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.lookup = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.createButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.findButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.closeAll = new System.Windows.Forms.ToolStripButton();
            this.saveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1 = new MyTabControl(this);
            this.MainMenu.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.语言ToolStripMenuItem,
            this.Format,
            this.lookup,
            this.Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(641, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.open,
            this.save,
            this.saveAs,
            this.toolStripSeparator1,
            this.pageSetting,
            this.print,
            this.toolStripSeparator2,
            this.exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // create
            // 
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(124, 22);
            this.create.Text = "新建";
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(124, 22);
            this.open.Text = "打开";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(124, 22);
            this.save.Text = "保存";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(124, 22);
            this.saveAs.Text = "另存为";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // pageSetting
            // 
            this.pageSetting.Name = "pageSetting";
            this.pageSetting.Size = new System.Drawing.Size(124, 22);
            this.pageSetting.Text = "页面设置";
            this.pageSetting.Click += new System.EventHandler(this.pageSetting_Click);
            // 
            // print
            // 
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(124, 22);
            this.print.Text = "打印";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.paste,
            this.delete,
            this.toolStripSeparator3,
            this.find,
            this.replace,
            this.goTo,
            this.toolStripSeparator4,
            this.selectAll,
            this.dateTime});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(59, 21);
            this.Edit.Text = "编辑(&E)";
            // 
            // undo
            // 
            this.undo.Enabled = false;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(146, 22);
            this.undo.Text = "撤销(&U)";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.Enabled = false;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(146, 22);
            this.redo.Text = "重做";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(146, 22);
            this.cut.Text = "剪切(T)";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(146, 22);
            this.copy.Text = "复制(&C)";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(146, 22);
            this.paste.Text = "粘贴(&P)";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(146, 22);
            this.delete.Text = "删除(&L)";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(146, 22);
            this.find.Text = "查找(&F)";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // replace
            // 
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(146, 22);
            this.replace.Text = "替换(&R)";
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // goTo
            // 
            this.goTo.Name = "goTo";
            this.goTo.Size = new System.Drawing.Size(146, 22);
            this.goTo.Text = "转到(&G)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // selectAll
            // 
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(146, 22);
            this.selectAll.Text = "全选(&A)";
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // dateTime
            // 
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(146, 22);
            this.dateTime.Text = "时间/日期(&D)";
            this.dateTime.Click += new System.EventHandler(this.dateTime_Click);
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asm,
            this.CSharp,
            this.cpp,
            this.HTML,
            this.INI,
            this.js,
            this.Python,
            this.PlainText,
            this.SQL,
            this.VBScript,
            this.XML});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.语言ToolStripMenuItem.Text = "语言(&L)";
            // 
            // asm
            // 
            this.asm.Name = "asm";
            this.asm.Size = new System.Drawing.Size(131, 22);
            this.asm.Text = "asm";
            this.asm.Click += new System.EventHandler(this.aSMToolStripMenuItem_Click);
            // 
            // CSharp
            // 
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(131, 22);
            this.CSharp.Text = "C#";
            this.CSharp.Click += new System.EventHandler(this.CSharp_Click);
            // 
            // cpp
            // 
            this.cpp.Name = "cpp";
            this.cpp.Size = new System.Drawing.Size(131, 22);
            this.cpp.Text = "C++";
            this.cpp.Click += new System.EventHandler(this.cPPToolStripMenuItem_Click);
            // 
            // HTML
            // 
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(131, 22);
            this.HTML.Text = "HTML";
            this.HTML.Click += new System.EventHandler(this.HTML_Click);
            // 
            // INI
            // 
            this.INI.Name = "INI";
            this.INI.Size = new System.Drawing.Size(131, 22);
            this.INI.Text = "INI";
            this.INI.Click += new System.EventHandler(this.INI_Click);
            // 
            // js
            // 
            this.js.Name = "js";
            this.js.Size = new System.Drawing.Size(131, 22);
            this.js.Text = "js";
            this.js.Click += new System.EventHandler(this.jsToolStripMenuItem_Click);
            // 
            // Python
            // 
            this.Python.Name = "Python";
            this.Python.Size = new System.Drawing.Size(131, 22);
            this.Python.Text = "Python";
            this.Python.Click += new System.EventHandler(this.Python_Click);
            // 
            // PlainText
            // 
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(131, 22);
            this.PlainText.Text = "Plain Text";
            this.PlainText.Click += new System.EventHandler(this.PlainText_Click);
            // 
            // SQL
            // 
            this.SQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSSQL});
            this.SQL.Name = "SQL";
            this.SQL.Size = new System.Drawing.Size(131, 22);
            this.SQL.Text = "SQL";
            // 
            // MSSQL
            // 
            this.MSSQL.Name = "MSSQL";
            this.MSSQL.Size = new System.Drawing.Size(118, 22);
            this.MSSQL.Text = "MSSQL";
            this.MSSQL.Click += new System.EventHandler(this.MSSQL_Click);
            // 
            // VBScript
            // 
            this.VBScript.Name = "VBScript";
            this.VBScript.Size = new System.Drawing.Size(131, 22);
            this.VBScript.Text = "VBScript";
            this.VBScript.Click += new System.EventHandler(this.VBScript_Click);
            // 
            // XML
            // 
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(131, 22);
            this.XML.Text = "XML";
            this.XML.Click += new System.EventHandler(this.XML_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoEnter,
            this.font,
            this.color});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(62, 21);
            this.Format.Text = "格式(&O)";
            // 
            // autoEnter
            // 
            this.autoEnter.Checked = true;
            this.autoEnter.CheckOnClick = true;
            this.autoEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoEnter.Name = "autoEnter";
            this.autoEnter.Size = new System.Drawing.Size(124, 22);
            this.autoEnter.Text = "自动换行";
            this.autoEnter.Click += new System.EventHandler(this.autoEnter_Click);
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(124, 22);
            this.font.Text = "字体(&F)";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(124, 22);
            this.color.Text = "颜色(&C)";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // lookup
            // 
            this.lookup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools,
            this.Status});
            this.lookup.Name = "lookup";
            this.lookup.Size = new System.Drawing.Size(60, 21);
            this.lookup.Text = "查看(&V)";
            // 
            // tools
            // 
            this.tools.Checked = true;
            this.tools.CheckOnClick = true;
            this.tools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(127, 22);
            this.tools.Text = "工具栏(&T)";
            this.tools.Click += new System.EventHandler(this.tools_Click);
            // 
            // Status
            // 
            this.Status.Checked = true;
            this.Status.CheckOnClick = true;
            this.Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(127, 22);
            this.Status.Text = "状态栏(&S)";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // version
            // 
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(116, 22);
            this.version.Text = "版本(&V)";
            this.version.Click += new System.EventHandler(this.version_Click);
            // 
            // toolMenu
            // 
            this.toolMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createButton,
            this.openButton,
            this.saveButton,
            this.printButton,
            this.toolStripSeparator5,
            this.copyButton,
            this.pasteButton,
            this.cutButton,
            this.toolStripSeparator6,
            this.undoButton,
            this.redoButton,
            this.toolStripSeparator7,
            this.findButton,
            this.zoomInButton,
            this.zoomOutButton,
            this.toolStripSeparator8,
            this.closeAll,
            this.saveAll,
            this.toolStripSeparator9,
            this.helpButton});
            this.toolMenu.Location = new System.Drawing.Point(0, 25);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(641, 25);
            this.toolMenu.TabIndex = 2;
            this.toolMenu.Text = "toolStrip1";
            // 
            // createButton
            // 
            this.createButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createButton.Image = ((System.Drawing.Image)(resources.GetObject("createButton.Image")));
            this.createButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(23, 22);
            this.createButton.Text = "新建";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(23, 22);
            this.openButton.Text = "打开";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "保存";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(23, 22);
            this.printButton.Text = "打印";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(23, 22);
            this.copyButton.Text = "复制";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(23, 22);
            this.pasteButton.Text = "粘贴";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(23, 22);
            this.cutButton.Text = "剪切";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Enabled = false;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(23, 22);
            this.undoButton.Text = "撤销";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Enabled = false;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(23, 22);
            this.redoButton.Text = "重做";
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // findButton
            // 
            this.findButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(23, 22);
            this.findButton.Text = "查找";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
            this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInButton.Text = "放大";
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.Image")));
            this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutButton.Text = "缩小";
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // closeAll
            // 
            this.closeAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeAll.Image = ((System.Drawing.Image)(resources.GetObject("closeAll.Image")));
            this.closeAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(23, 22);
            this.closeAll.Text = "全部关闭";
            this.closeAll.Click += new System.EventHandler(this.closeAll_Click);
            // 
            // saveAll
            // 
            this.saveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAll.Image = ((System.Drawing.Image)(resources.GetObject("saveAll.Image")));
            this.saveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(23, 22);
            this.saveAll.Text = "全部保存";
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 22);
            this.helpButton.Text = "帮助";
            //
            //tabControl1
            //
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(641, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolMenu);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Zpreston Notepad--";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem version;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem pageSetting;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem replace;
        private System.Windows.Forms.ToolStripMenuItem goTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private System.Windows.Forms.ToolStripMenuItem dateTime;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem lookup;
        private System.Windows.Forms.ToolStripMenuItem tools;
        private System.Windows.Forms.ToolStripMenuItem Status;
        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton createButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton printButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem redo;
        private System.Windows.Forms.ToolStripMenuItem 语言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CSharp;
        private System.Windows.Forms.ToolStripMenuItem HTML;
        private System.Windows.Forms.ToolStripMenuItem Python;
        private System.Windows.Forms.ToolStripMenuItem PlainText;
        private System.Windows.Forms.ToolStripMenuItem SQL;
        private System.Windows.Forms.ToolStripMenuItem MSSQL;
        private System.Windows.Forms.ToolStripMenuItem VBScript;
        private System.Windows.Forms.ToolStripMenuItem XML;
        private System.Windows.Forms.ToolStripMenuItem INI;
        private System.Windows.Forms.ToolStripMenuItem autoEnter;
        private System.Windows.Forms.ToolStripMenuItem js;
        private System.Windows.Forms.ToolStripMenuItem asm;
        private System.Windows.Forms.ToolStripMenuItem cpp;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private MyTabControl tabControl1;
        private System.Windows.Forms.ToolStripButton zoomInButton;
        private System.Windows.Forms.ToolStripButton findButton;
        private System.Windows.Forms.ToolStripButton zoomOutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton closeAll;
        private System.Windows.Forms.ToolStripButton saveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}

