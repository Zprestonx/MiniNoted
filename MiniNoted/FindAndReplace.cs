using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScintillaNET;

namespace MiniNoted
{
    public partial class FindAndReplace : Form
    {
        //父控件
        private TabControl tabControl1;
        //父控件中的Scintilla控件
        private Scintilla MyEditor;
        //大小写匹配标识
        private Boolean findUper = false;
        //全词匹配标识
        private Boolean findWhole = false;
        //向前向后查找标识
        private Boolean findForward = false;
        public FindAndReplace(TabControl tabControl1)
        {
            InitializeComponent();
            //设置父控件
            this.tabControl1 = tabControl1;
        }
        #region 窗体加载
        private void FormFind_Load(object sender, EventArgs e)
        {
            //初始化查找、替换、全部替换按钮
            findButton.Enabled = false;
            replaceButton.Enabled = false;
            replaceAllButton.Enabled = false;
        }
        #endregion
        #region 获取当前标签页的Scintilla控件
        private Scintilla getEditor()
        {
            return (Scintilla)(tabControl1.SelectedTab.Controls.Find("MyEditor",false)[0]);
        }
        #endregion
        #region 获取查找标志
        private SearchFlags getSearhFlags()
        {
            //大写
            if (findUper == true && findWhole == false) return SearchFlags.MatchCase;
            //全词匹配
            else if (findUper == false && findWhole == true) return SearchFlags.WholeWord;
            //大写+全词匹配
            else if (findUper == true && findWhole == true) return SearchFlags.MatchCase | SearchFlags.WholeWord;
            else return SearchFlags.Empty;
        }
        #endregion
        #region 查找文本框
        private void findText_TextChanged(object sender, EventArgs e)
        {
            if (findText.Text == string.Empty) findButton.Enabled = false;
            else findButton.Enabled = true;
        }
        #endregion
        #region 查找按钮
        private void findButton_Click(object sender, EventArgs e)
        {
            //获取查找字符串
            string findString = findText.Text;
            //获取当前标签页的Scintilla控件
            MyEditor=getEditor();
            //获取查找标志
            SearchFlags searchFlags=getSearhFlags();
            //查找到的字符串的范围
            Range range;
            if (findForward == false)
            {
                range = MyEditor.FindReplace.FindNext(findString,searchFlags);
            }
            else
            {
                range = MyEditor.FindReplace.FindPrevious(findString,searchFlags);
            }
            if (range==null)
            {
                MessageBox.Show("查找内容不存在!","查找");
                return;
            }
            //选中查找到的字符串
            range.Select();
        }
        #endregion
        #region 替换文本框
        private void replaceText_TextChanged(object sender, EventArgs e)
        {
            if (replaceText.Text == string.Empty || findText.Text==string.Empty)
            {
                replaceAllButton.Enabled = false;
                replaceButton.Enabled = false;
            }
            else
            {
                replaceAllButton.Enabled = true;
                replaceButton.Enabled = true;
            }
        }
        #endregion
        #region 替换按钮
        private void replaceButton_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            MyEditor=getEditor();
            //查找到的字符串的范围
            Range range;
            //获取查找标志
            SearchFlags searchFlags = getSearhFlags();
            //向后查找并替换
            if (findForward==false) range=MyEditor.FindReplace.ReplaceNext(findText.Text, replaceText.Text,searchFlags);
            //向前查找并替换
            else range=MyEditor.FindReplace.ReplacePrevious(findText.Text,replaceText.Text,searchFlags);
            //选中替换后的字符串
            if (null != range) range.Select();
            else MessageBox.Show("没有符合条件的字符串!","替换");
        }
        #endregion
        #region 全部替换按钮
        private void replaceAllButton_Click(object sender, EventArgs e)
        {
            //获取当前标签页的Scintilla控件
            MyEditor = getEditor();
            //获取查找标志
            SearchFlags searchFlags = getSearhFlags();
            //获取查找到的全部字符串的范围
            List<Range> ranges = MyEditor.FindReplace.ReplaceAll(findText.Text,replaceText.Text,searchFlags);
            MessageBox.Show("共完成"+ranges.Count+"处替换!","替换");
        }
        #endregion
        #region 取消按钮
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 大小写复选框
        private void uperOrLower_CheckedChanged(object sender, EventArgs e)
        {
            if (uperOrLower.Checked == true) findUper = true;
            else findUper = false;
        }
        #endregion
        #region 全词匹配复选框
        private void matchWhole_CheckedChanged(object sender, EventArgs e)
        {
            if (matchWhole.Checked == true) findWhole = true;
            else findWhole = false;
        }
        #endregion
        #region 向前向后查找单选框
        private void forward_CheckedChanged(object sender, EventArgs e)
        {
            if (forward.Checked == true) findForward = true;
            else findForward = false;
        }
        #endregion
    }
}
