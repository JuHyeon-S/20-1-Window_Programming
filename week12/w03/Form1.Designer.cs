﻿namespace w03
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("1학년", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("2학년", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("3학년", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("4학년", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(41, 48);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "노드4";
            treeNode37.Text = "1학기";
            treeNode38.Name = "노드5";
            treeNode38.Text = "2학기";
            treeNode39.Name = "노드0";
            treeNode39.Text = "1학년";
            treeNode40.Name = "노드6";
            treeNode40.Text = "1학기";
            treeNode41.Name = "노드7";
            treeNode41.Text = "2학기";
            treeNode42.Name = "노드1";
            treeNode42.Text = "2학년";
            treeNode43.Name = "노드8";
            treeNode43.Text = "1학기";
            treeNode44.Name = "노드9";
            treeNode44.Text = "2학기";
            treeNode45.Name = "노드2";
            treeNode45.Text = "3학년";
            treeNode46.Name = "노드10";
            treeNode46.Text = "1학기";
            treeNode47.Name = "노드11";
            treeNode47.Text = "2학기";
            treeNode48.Name = "노드3";
            treeNode48.Text = "4학년";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode42,
            treeNode45,
            treeNode48});
            this.treeView1.Size = new System.Drawing.Size(623, 543);
            this.treeView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(707, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(623, 544);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 644);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 42);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "과목 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 644);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "과목 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1108, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 59);
            this.button3.TabIndex = 5;
            this.button3.Text = "과목 출력";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 782);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TreeViewApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

