namespace MiniNoted
{
    partial class FindAndReplace
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
            this.findText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.GroupBox();
            this.backward = new System.Windows.Forms.RadioButton();
            this.forward = new System.Windows.Forms.RadioButton();
            this.findButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Label();
            this.replaceText = new System.Windows.Forms.TextBox();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.GroupBox();
            this.matchWhole = new System.Windows.Forms.CheckBox();
            this.uperOrLower = new System.Windows.Forms.CheckBox();
            this.direction.SuspendLayout();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // findText
            // 
            this.findText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.findText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.findText.Location = new System.Drawing.Point(94, 29);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(208, 21);
            this.findText.TabIndex = 0;
            this.findText.TextChanged += new System.EventHandler(this.findText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "查找内容:";
            // 
            // direction
            // 
            this.direction.Controls.Add(this.backward);
            this.direction.Controls.Add(this.forward);
            this.direction.Font = new System.Drawing.Font("宋体", 10F);
            this.direction.Location = new System.Drawing.Point(128, 97);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(170, 58);
            this.direction.TabIndex = 3;
            this.direction.TabStop = false;
            this.direction.Text = "查找方向";
            // 
            // backward
            // 
            this.backward.AutoSize = true;
            this.backward.Checked = true;
            this.backward.Location = new System.Drawing.Point(93, 19);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(81, 18);
            this.backward.TabIndex = 1;
            this.backward.TabStop = true;
            this.backward.Text = "向后查找";
            this.backward.UseVisualStyleBackColor = true;
            // 
            // forward
            // 
            this.forward.AutoSize = true;
            this.forward.Location = new System.Drawing.Point(6, 19);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(81, 18);
            this.forward.TabIndex = 0;
            this.forward.Text = "向前查找";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.CheckedChanged += new System.EventHandler(this.forward_CheckedChanged);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(317, 29);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(86, 23);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "查找下一个";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(317, 123);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // replace
            // 
            this.replace.AutoSize = true;
            this.replace.Font = new System.Drawing.Font("宋体", 12F);
            this.replace.Location = new System.Drawing.Point(29, 61);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(64, 16);
            this.replace.TabIndex = 6;
            this.replace.Text = "替换为:";
            // 
            // replaceText
            // 
            this.replaceText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.replaceText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.replaceText.Location = new System.Drawing.Point(94, 61);
            this.replaceText.Name = "replaceText";
            this.replaceText.Size = new System.Drawing.Size(208, 21);
            this.replaceText.TabIndex = 7;
            this.replaceText.TextChanged += new System.EventHandler(this.replaceText_TextChanged);
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(317, 91);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(86, 23);
            this.replaceAllButton.TabIndex = 8;
            this.replaceAllButton.Text = "全部替换";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            this.replaceAllButton.Click += new System.EventHandler(this.replaceAllButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(317, 60);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(86, 23);
            this.replaceButton.TabIndex = 9;
            this.replaceButton.Text = "替换";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // options
            // 
            this.options.Controls.Add(this.matchWhole);
            this.options.Controls.Add(this.uperOrLower);
            this.options.Font = new System.Drawing.Font("宋体", 10F);
            this.options.Location = new System.Drawing.Point(11, 97);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(111, 83);
            this.options.TabIndex = 10;
            this.options.TabStop = false;
            this.options.Text = "选项";
            // 
            // matchWhole
            // 
            this.matchWhole.AutoSize = true;
            this.matchWhole.Location = new System.Drawing.Point(3, 47);
            this.matchWhole.Name = "matchWhole";
            this.matchWhole.Size = new System.Drawing.Size(82, 18);
            this.matchWhole.TabIndex = 1;
            this.matchWhole.Text = "全词匹配";
            this.matchWhole.UseVisualStyleBackColor = true;
            this.matchWhole.CheckedChanged += new System.EventHandler(this.matchWhole_CheckedChanged);
            // 
            // uperOrLower
            // 
            this.uperOrLower.AutoSize = true;
            this.uperOrLower.Location = new System.Drawing.Point(3, 22);
            this.uperOrLower.Name = "uperOrLower";
            this.uperOrLower.Size = new System.Drawing.Size(96, 18);
            this.uperOrLower.TabIndex = 0;
            this.uperOrLower.Text = "区分大小写";
            this.uperOrLower.UseVisualStyleBackColor = true;
            this.uperOrLower.CheckedChanged += new System.EventHandler(this.uperOrLower_CheckedChanged);
            // 
            // FindAndReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 197);
            this.Controls.Add(this.options);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceText);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findText);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FindAndReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.FormFind_Load);
            this.direction.ResumeLayout(false);
            this.direction.PerformLayout();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox direction;
        private System.Windows.Forms.RadioButton backward;
        private System.Windows.Forms.RadioButton forward;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label replace;
        private System.Windows.Forms.TextBox replaceText;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.CheckBox matchWhole;
        private System.Windows.Forms.CheckBox uperOrLower;
    }
}