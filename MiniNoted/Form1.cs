using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using ScintillaNET;
using WeifenLuo.WinFormsUI;
using WeifenLuo.WinFormsUI.Docking;
using System.Collections;

namespace MiniNoted
{
    public partial class FormMain : Form
    {
        //新建文件的编号
        int n=0;
        //当前标签页的Scintilla控件
        private Scintilla MyEditor;  
        //窗口标题后缀
        private string titleFlag=" - Notepad--";
        public FormMain()
        {
            InitializeComponent();
        }
        #region 键盘快捷键处理
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Ctrl+S 保存
            if (keyData == (Keys.S | Keys.Control))
            {
                save.PerformClick();
                return true;
            }
            //Ctrl+F 弹出查找替换框
            if (keyData == (Keys.F | Keys.Control))
            {
                find.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
        #region 获取当前标签页的Scintilla控件
        private Scintilla getEditor()
        {
            return (Scintilla)(this.tabControl1.SelectedTab.Controls.Find("MyEditor", false)[0]);
        }
        #endregion
        #region 初始化Scintilla控件
        private Scintilla setEditor()
        {
            Scintilla MyEditor = new Scintilla();
            MyEditor.Name = "MyEditor";
            //Margin2为编辑列，编辑文本
            MyEditor.Margins.Margin2.Width = 1;
            //Margin1为折叠列，点击折叠代码
            MyEditor.Margins.Margin1.IsFoldMargin = true;
            MyEditor.Margins.Margin1.IsClickable = true;
            MyEditor.Margins.Margin1.Width = 0x10;
            MyEditor.Folding.MarkerScheme = FoldMarkerScheme.Arrow;//折叠标志为三角箭头
            //Margin0为数字列，显示行号
            MyEditor.Margins.Margin0.Type = MarginType.Number;
            MyEditor.Margins.Margin0.Width = 0x23;
            //设置Scintilla控件的编程语言
            MyEditor.ConfigurationManager.Language = "cs";
            MyEditor.Dock = DockStyle.Fill;
            //同时显示水平和垂直滚动条
            MyEditor.Scrolling.ScrollBars = ScrollBars.Both;
            MyEditor.ConfigurationManager.IsBuiltInEnabled = true;
            //为Scintilla控件订阅文本更改事件
            MyEditor.TextChanged += new EventHandler(this.MyEditor_TextChanged);
            //为Scintilla控件订阅光标变焦事件
            MyEditor.SelectionChanged += new EventHandler(this.MyEditor_SelectionChanged);
            //将Scintilla控件的更改标志置为false
            MyEditor.Modified = false;
            return MyEditor;
        }
        #endregion
        #region 创建文件
        private void create_Click(object sender, EventArgs e)
        {
            //每创建一个文件，编号n加1
            n=n+1;
            //初始化Scintilla控件
            Scintilla MyEditor = setEditor();

            //int length = MyEditor.Text.Length;
            //int lines = MyEditor.Lines.Count;
            //初始化显示信息面板
            Panel footer = setFooter(0, 1);
            //创建一个新标签页
            TabPage page = new TabPage();
            page.Name = "new " + n.ToString();
            page.Text = "new " + n.ToString();
            //为标签页添加Scintilla控件和显示信息面板
            page.Controls.Add(footer);
            page.Controls.Add(MyEditor);
            //为标签控制器添加标签页，并让其获得焦点
            this.tabControl1.Controls.Add(page);
            this.tabControl1.SelectedTab = page;
            //设置自动换行
            autoEnter_Click(sender, e);
            //设置窗口标题
            this.Text = page.Name + titleFlag;
        }
        #endregion
        #region 设置信息显示面板
        private Panel setFooter(int TextLength,int TextLines)
        {
            //创建源文件显示标签
            Label sourceFile = new Label();
            sourceFile.Name = "sourceFile";
            sourceFile.Text = "cs sourceFile";
            sourceFile.AutoSize = true;
            sourceFile.Dock = DockStyle.Left;
            sourceFile.TextAlign = ContentAlignment.MiddleLeft;
            //创建长度显示标签
            Label length = new Label();
            length.Name = "length";
            length.Width = 150;
            length.Text = "length: "+TextLength;
            length.Dock = DockStyle.Right;
            length.TextAlign = ContentAlignment.MiddleLeft;
            //创建行数显示标签
            Label lines = new Label();
            lines.Name = "lines";
            lines.Width = 100;
            lines.Text = "lines: "+TextLines;
            lines.Dock = DockStyle.Right;
            lines.TextAlign = ContentAlignment.MiddleLeft;
            //创建选中行显示标签
            Label row = new Label();
            row.Name = "row";
            row.Width = 100;
            row.Text = "row: 0";
            row.Dock = DockStyle.Right;
            row.TextAlign = ContentAlignment.MiddleLeft;
            //创建选中列显示标签
            Label col = new Label();
            col.Name = "col";
            col.Width = 100;
            col.Text = "col: 0";
            col.Dock = DockStyle.Right;
            col.TextAlign = ContentAlignment.MiddleLeft;
            //创建信息显示面板
            Panel footer = new Panel();
            footer.Name = "footer";
            footer.Height = 20;
            footer.Font = new Font("Consolas", 11);
            footer.Dock = DockStyle.Bottom;
            //为信息显示面板添加各个显示标签
            footer.Controls.Add(sourceFile);
            footer.Controls.Add(length);
            footer.Controls.Add(lines);
            footer.Controls.Add(row);
            footer.Controls.Add(col);

            return footer;
        }
        #endregion
        #region 打开文件
        private void open_Click(object sender, EventArgs e)
        {
            //创建打开文件对话框
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\user\\desktop\\";
            openFileDialog1.Filter = "RichText files (*.rtf) | *.rtf";
            //打开文件
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //文件路径
                string path = openFileDialog1.FileName;
                //判断文件是否已经打开
                //遍历所有标签页
                for (int i = 0; i < this.tabControl1.TabCount; i++)
                {
                    //文件已经打开
                    if (this.tabControl1.TabPages[i].Name.Equals(path))
                    {
                        //让其获得焦点并返回
                        this.tabControl1.SelectedTab = this.tabControl1.TabPages[i];
                        return;
                    }
                }
                //创建Scintilla控件
                Scintilla MyEditor = new Scintilla();               
                string fileName;
                //查找最后一个\的索引
                int index = path.LastIndexOf(@"\");
                //截取最后一个\之后的字符串，即文件名
                if (index > 0) fileName = path.Substring(index+1, path.Length - index - 1);
                else fileName = path;
                //读取打开文件内容并写入Scintilla控件
                using (StreamReader streamReader = new StreamReader(path, Encoding.Unicode))
                {
                    MyEditor.Text = streamReader.ReadToEnd();
                }
                //创建标签页
                TabPage page = new TabPage();
                //设置Name属性为文件路径，方便之后的保存操作
                page.Name = openFileDialog1.FileName;
                page.Text = fileName;
                //初始化Scintilla控件
                MyEditor.Name = "MyEditor";
                //Margin2为编辑列，编辑文本
                MyEditor.Margins.Margin2.Width = 1;
                //Margin1为折叠列，点击折叠代码
                MyEditor.Margins.Margin1.IsFoldMargin = true;
                MyEditor.Margins.Margin1.IsClickable = true;
                MyEditor.Margins.Margin1.Width = 0x10;
                MyEditor.Folding.MarkerScheme = FoldMarkerScheme.Arrow;
                //Margin0为数字列，显示行号
                MyEditor.Margins.Margin0.Type = MarginType.Number;
                MyEditor.Margins.Margin0.Width = 0x23;
                //设置Scintilla控件的编程语言
                MyEditor.ConfigurationManager.Language = "cs";
                MyEditor.Dock = DockStyle.Fill;
                //同时显示水平和垂直滚动条
                MyEditor.Scrolling.ScrollBars = ScrollBars.Both;
                MyEditor.ConfigurationManager.IsBuiltInEnabled = true;
                //为Scintilla控件订阅文本更改事件
                MyEditor.TextChanged += new EventHandler(this.MyEditor_TextChanged);
                //为Scintilla控件订阅光标变焦事件
                MyEditor.SelectionChanged += new EventHandler(this.MyEditor_SelectionChanged);
                //将Scintilla控件的更改标志置为false
                MyEditor.Modified = false;
                //获取文本的长度和行数
                int length = MyEditor.Text.Length;
                int lines = MyEditor.Lines.Count;
                //设置信息显示面板的长度和行数
                Panel footer = setFooter(length,lines);
                //为标签页添加Scintilla控件和信息显示面板
                page.Controls.Add(MyEditor);
                page.Controls.Add(footer);
                //为标签控制器添加标签页，并获得焦点
                this.tabControl1.Controls.Add(page);
                this.tabControl1.SelectedTab = page;
                //设置窗口标题
                this.Text = page.Name + titleFlag;
            }
        }
        #endregion
        #region Scintilla控件文本更改事件
        private void MyEditor_TextChanged(object sender,EventArgs e)
        {
            MyEditor = getEditor();
            MyEditor.AutoComplete.AutoHide = true;
            MyEditor.AutoComplete.Show();
            //更新窗口标题
            setFormText();
            //更新撤销和重做按钮的状态
            updateUndoRedo();
        }
        #endregion
        #region Scintilla控件光标变焦事件
        private void MyEditor_SelectionChanged(object sender, EventArgs e)
        {
            //获取当前标签标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //获取文本的长度
            int length = MyEditor.Text.Length;
            //获取文本的行数
            int lines = MyEditor.Lines.Count;
            //获取光标位置
            int position = MyEditor.CurrentPos;
            //获取光标所在列号
            int col = MyEditor.GetColumn(position)+1;
            //获取光标所在行号
            int row = MyEditor.Lines.Current.Number+1;
            //更新信息显示面板
            updateRowCol(length,lines,row,col);
        }
        #endregion
        #region 更新信息显示面板
        private void updateRowCol(int length,int lines,int row,int col)
        {
            //获取当前标签页的信息显示面板
            Panel footer = (Panel)(tabControl1.SelectedTab.Controls.Find("footer", false)[0]);
            //更新长度、行数、行号和列号
            (footer.Controls.Find("length", false)[0]).Text = "length: " + length;
            (footer.Controls.Find("lines", false)[0]).Text = "lines: " + lines;
            (footer.Controls.Find("row", false)[0]).Text = "row: "+row;
            (footer.Controls.Find("col", false)[0]).Text = "col: "+col;
        }
        private void updateSourceFile(string language)
        {
            Panel footer = (Panel)(tabControl1.SelectedTab.Controls.Find("footer", false)[0]);
            //string sourceFile = "";
            //if (language.Equals("cs")) sourceFile = "C#";
            if (language.Equals(String.Empty)) language = "text";
            (footer.Controls.Find("sourceFile", false)[0]).Text = language+" sourceFile";
        }
        #endregion
        #region 设置窗口标题
        private void setFormText()
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //当前文件已被修改
            MyEditor.Modified = true;
            //当前文件被修改且窗口标题不含有*字符，即首次被修改
            if (MyEditor.Modified && !(this.Text.Contains("*")))
            {
                StringBuilder formText = new StringBuilder();
                formText.Append(this.Text);
                //在窗口标题最前面加上*字符，表示被修改
                formText.Insert(0, "*");
                this.Text = formText.ToString();
            }
        }
        #endregion
        #region 更新撤销和重做按钮的状态
        private void updateUndoRedo()
        {
            //可撤销
            if (MyEditor.UndoRedo.CanUndo)
            {
                undo.Enabled = true;
                undoButton.Enabled = true;
            }
            //不可撤销
            else
            {
                undo.Enabled = false;
                undoButton.Enabled = false;
            }
            //可重做
            if (MyEditor.UndoRedo.CanRedo)
            {
                redo.Enabled = true;
                redoButton.Enabled = true;
            }
            //不可重做
            else
            {
                redo.Enabled = false;
                redoButton.Enabled = false;
            }
        }
        #endregion
        #region 保存文件
        public void save_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //文件被修改过
            if (MyEditor.Modified)
            {               
                //获取当前标签页的Name属性，即文件路径
                string formText = this.tabControl1.SelectedTab.Name;
                //文件名包含\字符，即该文件为打开的文件
                if (formText.Contains("\\"))
                {
                    FileStream fileStream = new FileStream(formText, FileMode.Create);
                     StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Unicode);
                     streamWriter.Write(MyEditor.Text);
                     streamWriter.Close();
                     fileStream.Close();
                     MyEditor.Modified = false;
                     this.Text = formText;
                     this.tabControl1.SelectedTab.Name = formText;
                     //MessageBox.Show("保存成功!");
                }
                //否则为新创建的文件
                else
                {
                    saveAs.PerformClick();
                }
            }
        }
        #endregion
        #region 退出
        private void exit_Click(object sender, EventArgs e)
        {
            closeAll.PerformClick();
            Application.Exit();
        }
        #endregion
        #region 版本
        private void version_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本1.0.0，CopyRight Zpreston","版本");
        }
        #endregion
        #region 另存为
        private void saveAs_Click(object sender, EventArgs e)
        {
            Scintilla MyEditor = getEditor();
            //打开保存文件对话框
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\\user\\desktop\\";
            saveFileDialog1.Filter = "RichText files (*.rtf) | *.rtf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                FileStream fileStream = new FileStream(path, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Unicode);
                streamWriter.Write(MyEditor.Text);
                streamWriter.Close();
                fileStream.Close();
                MyEditor.Modified = false;
                //MessageBox.Show("保存成功!");
                tabControl1.SelectedTab.Name = path;
                this.Text = path+titleFlag;
                int index = path.LastIndexOf(@"\");
                tabControl1.SelectedTab.Text = path.Substring(index+1,path.Length-index-1);
            }
        }
        #endregion
        #region 页面设置
        private void pageSetting_Click(object sender, EventArgs e)
        {
            MyEditor = getEditor();
            MyEditor.Printing.ShowPageSetupDialog();
        }
        #endregion
        #region 打印
        private void print_Click(object sender, EventArgs e)
        {
            MyEditor = getEditor();
            printDialog1.Document = MyEditor.Printing.PrintDocument;
            if (printDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            MyEditor.Printing.PrintDocument.Print();
        }
        #endregion
        #region 撤销
        private void undo_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //撤销
            if (MyEditor.UndoRedo.CanUndo)  MyEditor.UndoRedo.Undo();          
        }
        #endregion
        #region 重做
        private void redo_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //重做
            if (MyEditor.UndoRedo.CanRedo)  MyEditor.UndoRedo.Redo();
        }
        #endregion
        #region 剪切
        private void cut_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //剪切
            if (MyEditor.Clipboard.CanCut) MyEditor.Clipboard.Cut();
        }
        #endregion
        #region 复制
        private void copy_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //复制
            if (MyEditor.Clipboard.CanCopy) MyEditor.Clipboard.Copy();
        }
        #endregion
        #region 粘贴
        private void paste_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //粘贴
            if (MyEditor.Clipboard.CanPaste) MyEditor.Clipboard.Paste();
        }
        #endregion
        #region 删除
        private void delete_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //删除
            MyEditor.Selection.Clear();
        }
        #endregion
        #region 查找
        private void find_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FindAndReplace"] != null)
            {
                return;
            }
            //创建查找替换窗体
            FindAndReplace findAndReplace = new FindAndReplace(this.tabControl1);
            //显示查找替换窗体
            findAndReplace.Show(this);
        }
        #endregion
        #region 替换
        private void replace_Click(object sender, EventArgs e)
        {
            //调用查找按钮的单击事件
            find.PerformClick();
        }
        #endregion
        #region 全选
        private void selectAll_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //全选
            MyEditor.Selection.SelectAll();
        }
        #endregion
        #region 日期和时间
        private void dateTime_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //获取当前的系统时间
            DateTime dateTime = DateTime.Now;
            //系统时间的字符串表示
            string strDateTime = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() +":"+dateTime.Second.ToString()+ " " + dateTime.Year.ToString() + "-"
                +dateTime.Month.ToString()+"-"+dateTime.Day.ToString();
            //设置剪贴板文字
            System.Windows.Forms.Clipboard.SetText(strDateTime);
            //将当前时间粘贴
            MyEditor.Clipboard.Paste();
        }
        #endregion
        #region 字体
        private void font_Click(object sender, EventArgs e)
        {
            //创建并显示字体对话框
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //设置字体
            MyEditor.Font = fontDialog.Font;
        }
        #endregion
        #region 颜色
        private void color_Click(object sender, EventArgs e)
        {
            //创建并显示颜色对话框
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            //获取当前标签页的Scintilla控件
            Scintilla MyEditor = getEditor();
            //设置颜色
            MyEditor.ForeColor = colorDialog.Color;
        }
        #endregion
        #region 工具栏
        private void tools_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = tools.Checked;
        }
        #endregion
        #region 状态栏
        private void Status_Click(object sender, EventArgs e)
        {
            toolMenu.Visible = Status.Checked;
        }
        #endregion
        #region 创建文件按钮
        private void createButton_Click(object sender, EventArgs e)
        {
            create.PerformClick();
        }
        #endregion
        #region 打开文件按钮
        private void openButton_Click(object sender, EventArgs e)
        {
            open.PerformClick();
        }
        #endregion
        #region 保存文件按钮
        private void saveButton_Click(object sender, EventArgs e)
        {
            save.PerformClick();
        }
        #endregion
        #region 打印按钮
        private void printButton_Click(object sender, EventArgs e)
        {
            print.PerformClick();
        }
        #endregion
        #region 复制按钮
        private void copyButton_Click(object sender, EventArgs e)
        {
            copy.PerformClick();
        }
        #endregion
        #region 粘贴按钮
        private void pasteButton_Click(object sender, EventArgs e)
        {
            paste.PerformClick();
        }
        #endregion
        #region 剪切按钮
        private void cutButton_Click(object sender, EventArgs e)
        {
            cut.PerformClick();
        }
        #endregion
        #region 语言
        private void setLanguage(string language)
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //设置语言
            MyEditor.ConfigurationManager.Language = language;
            updateSourceFile(language);
        }
        #endregion
        #region CS
        private void CSharp_Click(object sender, EventArgs e)
        {
            setLanguage("cs");
        }
        #endregion
        #region HTML
        private void HTML_Click(object sender, EventArgs e)
        {
            setLanguage("html");
        }
        #endregion
        #region Python
        private void Python_Click(object sender, EventArgs e)
        {
            setLanguage("python");
        }
        #endregion
        #region MSSQL
        private void MSSQL_Click(object sender, EventArgs e)
        {
            setLanguage("mssql");
        }
        #endregion
        #region VBScript
        private void VBScript_Click(object sender, EventArgs e)
        {
            setLanguage("vbscript");
        }
        #endregion
        #region XML
        private void XML_Click(object sender, EventArgs e)
        {
            setLanguage("xml");
        }
        #endregion
        #region INI
        private void INI_Click(object sender, EventArgs e)
        {
            setLanguage("ini");
        }
        #endregion
        #region PlainText
        private void PlainText_Click(object sender, EventArgs e)
        {
            setLanguage(String.Empty);
        }
        #endregion
        #region JS
        private void jsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLanguage("js");
        }
        #endregion
        #region asm
        private void aSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLanguage("asm");
        }
        #endregion
        #region cpp
        private void cPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLanguage("cpp");
        }
        #endregion
        #region 自动换行
        private void autoEnter_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //设置自动换行
            if (autoEnter.Checked)
            {
                MyEditor.LineWrapping.Mode = LineWrappingMode.Word;
            }
            //取消自动换行
            else MyEditor.LineWrapping.Mode = LineWrappingMode.None;
        }
        #endregion
        #region 撤销按钮
        private void undoButton_Click(object sender, EventArgs e)
        {
            undo.PerformClick();
        }
        #endregion
        #region 重做按钮
        private void redoButton_Click(object sender, EventArgs e)
        {
            redo.PerformClick();
        }
        #endregion
        #region 标签控制器标签变焦事件
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount >= 1)
            {
                MyEditor = getEditor();
                if (MyEditor.Modified) this.Text = "*" + tabControl1.SelectedTab.Name + titleFlag;
                else this.Text = tabControl1.SelectedTab.Name + titleFlag;                
            }
            else Text = "Zpreston Notepad--";
        }
        #endregion
        #region 放大
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //放大
            MyEditor.ZoomIn();
        }
        #endregion
        #region 缩小
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //缩小
            MyEditor.ZoomOut();
        }
        #endregion
        #region 查找按钮
        private void findButton_Click(object sender, EventArgs e)
        {
            find.PerformClick();
        }
        #endregion
        #region 全部关闭
        private void closeAll_Click(object sender, EventArgs e)
        {
            //遍历所有标签页
            for (int i = tabControl1.TabCount-1; i >= 0; i--)
            {
                //让标签页获得焦点
                tabControl1.SelectedTab = tabControl1.TabPages[i];
                //检查是否需要保存
                this.tabControl1.CheckSave();
            }
        }
        #endregion
        #region 全部保存
        private void saveAll_Click(object sender, EventArgs e)
        {
            //遍历所有标签页
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                //让标签页获得焦点
                tabControl1.SelectedTab = tabControl1.TabPages[i];
                //保存
                save.PerformClick();
            }
        }
        #endregion
    }
}
