using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MiniNoted
{
    /// <summary> 
    /// 重写的TabControl控件 带关闭按钮
    /// </summary>
    public class MyTabControl : TabControl
    {
        //父窗体
        private FormMain father;
        //关闭按钮的宽度
        private int iconWidth = 16;
        //关闭按钮的高度
        private int iconHeight = 16;
        //关闭按钮
        private Image icon = null;
        //选项卡的背景色
        private Brush bgcolor = Brushes.MistyRose; 
        public MyTabControl(FormMain father)
            : base()
        {
            //设置父窗体
            this.father = father;
            this.SizeMode=TabSizeMode.Normal;
            //设置选项卡标签的大小,可改变高不可改变宽
            this.ItemSize = new Size(50, 25);
            //选项卡的显示模式
            this.Appearance = TabAppearance.Buttons;  
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            icon = Properties.Resources.close;
            //iconWidth = icon.Width; 
            //iconHeight = icon.Height;
        }
        /// <summary>
        /// 重写TabControl的绘制事件，为其绘制标题及关闭按钮
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //获取画布
            Graphics g = e.Graphics;
            //获取控件区域
            Rectangle r = GetTabRect(e.Index);
            //当前选中的标签页，设置不同的样式以示选中
            if (e.Index == this.SelectedIndex)    
            {
                //选中的标签页的背景色
                Brush selected_color = Brushes.PaleGoldenrod;
                //改变标签页的背景色
                g.FillRectangle(selected_color, r);  
                //标签页标题
                string title = this.TabPages[e.Index].Text + "  ";
                //绘制标签页的标题
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 0, r.Y + 6));
                //移动绘制区域
                r.Offset(r.Width - iconWidth, 5);
                //绘制标签页的关闭按钮
                g.DrawImage(icon, new Point(r.X+4, r.Y + 2));
            }
            //非选中的标签页
            else
            {
                //非选中的选项卡标签的背景色
                g.FillRectangle(bgcolor, r);  
                //标签页标题
                string title = this.TabPages[e.Index].Text + "   ";
                //绘制标签页的标题
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 0, r.Y + 6));
                //移动绘制区域
                r.Offset(r.Width - iconWidth, 5);
                //绘制关闭按钮
                g.DrawImage(icon, new Point(r.X+4, r.Y + 2)); 
            }
        }
        #region 双击事件
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            //检查是否需要保存
            CheckSave();
        }
        #endregion
        #region 检查是否需要保存
        public void CheckSave()
        {
            //窗口标题包含*字符，说明需要保存
            if (father.Text.Contains("*"))
            {
                //确认是否保存
                DialogResult response = MessageBox.Show(this.SelectedTab.Name + "文件未保存，是否保存？", "保存", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                //保存
                if (response == DialogResult.Yes) father.save_Click(null, null);
                //取消
                else if(response==DialogResult.Cancel) return;
            }
            //移除标签页
            this.TabPages.Remove(this.SelectedTab);
        }
        #endregion
        protected override void OnMouseClick(MouseEventArgs e)
        {
            #region 左键判断是否在关闭区域
            if (e.Button == MouseButtons.Left)
            {
                Point p = e.Location;
                Rectangle r = GetTabRect(this.SelectedIndex);
                r.Offset(r.Width - iconWidth, 5);
                r.Width = iconWidth;
                r.Height = iconHeight;
                if (r.Contains(p)) //点击关闭按钮区域时才发生 
                {
                    CheckSave();
                }
            }
            #endregion
        }
    }
}
