namespace w01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.데이터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자료입력NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체삭제XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택삭제PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴대화상자TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상대화상자CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일불러오기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일저장하기SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.데이터ToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.파일FToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 데이터ToolStripMenuItem
            // 
            this.데이터ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자료입력NToolStripMenuItem,
            this.전체삭제XToolStripMenuItem,
            this.선택삭제PToolStripMenuItem});
            this.데이터ToolStripMenuItem.Name = "데이터ToolStripMenuItem";
            this.데이터ToolStripMenuItem.ShortcutKeyDisplayString = "w";
            this.데이터ToolStripMenuItem.Size = new System.Drawing.Size(179, 50);
            this.데이터ToolStripMenuItem.Text = "데이터(W)";
            // 
            // 자료입력NToolStripMenuItem
            // 
            this.자료입력NToolStripMenuItem.Name = "자료입력NToolStripMenuItem";
            this.자료입력NToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.자료입력NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.자료입력NToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.자료입력NToolStripMenuItem.Text = "자료입력(N)";
            this.자료입력NToolStripMenuItem.Click += new System.EventHandler(this.자료입력NToolStripMenuItem_Click);
            // 
            // 전체삭제XToolStripMenuItem
            // 
            this.전체삭제XToolStripMenuItem.Name = "전체삭제XToolStripMenuItem";
            this.전체삭제XToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.전체삭제XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.전체삭제XToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.전체삭제XToolStripMenuItem.Text = "전체삭제(X)";
            this.전체삭제XToolStripMenuItem.Click += new System.EventHandler(this.전체삭제XToolStripMenuItem_Click);
            // 
            // 선택삭제PToolStripMenuItem
            // 
            this.선택삭제PToolStripMenuItem.Name = "선택삭제PToolStripMenuItem";
            this.선택삭제PToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.선택삭제PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.선택삭제PToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.선택삭제PToolStripMenuItem.Text = "선택삭제(P)";
            this.선택삭제PToolStripMenuItem.Click += new System.EventHandler(this.선택삭제PToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴대화상자TToolStripMenuItem,
            this.색상대화상자CToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(136, 50);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 글꼴대화상자TToolStripMenuItem
            // 
            this.글꼴대화상자TToolStripMenuItem.Name = "글꼴대화상자TToolStripMenuItem";
            this.글꼴대화상자TToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.글꼴대화상자TToolStripMenuItem.Text = "글꼴 대화 상자(T)";
            this.글꼴대화상자TToolStripMenuItem.Click += new System.EventHandler(this.글꼴대화상자TToolStripMenuItem_Click);
            // 
            // 색상대화상자CToolStripMenuItem
            // 
            this.색상대화상자CToolStripMenuItem.Name = "색상대화상자CToolStripMenuItem";
            this.색상대화상자CToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.색상대화상자CToolStripMenuItem.Text = "색상 대화 상자(C)";
            this.색상대화상자CToolStripMenuItem.Click += new System.EventHandler(this.색상대화상자CToolStripMenuItem_Click);
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일불러오기OToolStripMenuItem,
            this.파일저장하기SToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(135, 48);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 파일불러오기OToolStripMenuItem
            // 
            this.파일불러오기OToolStripMenuItem.Name = "파일불러오기OToolStripMenuItem";
            this.파일불러오기OToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.파일불러오기OToolStripMenuItem.Text = "파일 불러 오기(O)";
            this.파일불러오기OToolStripMenuItem.Click += new System.EventHandler(this.파일불러오기OToolStripMenuItem_Click);
            // 
            // 파일저장하기SToolStripMenuItem
            // 
            this.파일저장하기SToolStripMenuItem.Name = "파일저장하기SToolStripMenuItem";
            this.파일저장하기SToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.파일저장하기SToolStripMenuItem.Text = "파일 저장 하기(S)";
            this.파일저장하기SToolStripMenuItem.Click += new System.EventHandler(this.파일저장하기SToolStripMenuItem_Click);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(138, 48);
            this.종료XToolStripMenuItem.Text = "종료(X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(37, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(938, 484);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 575);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(938, 284);
            this.textBox1.TabIndex = 2;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 937);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MenuStripApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 데이터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자료입력NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체삭제XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택삭제PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴대화상자TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상대화상자CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일불러오기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일저장하기SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.ListBox listBox1;
    }
}

