namespace KVLS2_C1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pBIT_GBOX = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_SBC1 = new System.Windows.Forms.TextBox();
            this.tBox_SSD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pBIT_GBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBIT_GBOX
            // 
            this.pBIT_GBOX.Controls.Add(this.label2);
            this.pBIT_GBOX.Controls.Add(this.tBox_SBC1);
            this.pBIT_GBOX.Controls.Add(this.tBox_SSD);
            this.pBIT_GBOX.Controls.Add(this.label1);
            this.pBIT_GBOX.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pBIT_GBOX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pBIT_GBOX.Location = new System.Drawing.Point(23, 62);
            this.pBIT_GBOX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBIT_GBOX.Name = "pBIT_GBOX";
            this.pBIT_GBOX.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBIT_GBOX.Size = new System.Drawing.Size(884, 483);
            this.pBIT_GBOX.TabIndex = 0;
            this.pBIT_GBOX.TabStop = false;
            this.pBIT_GBOX.Text = "H/W Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SBC";
            // 
            // tBox_SBC1
            // 
            this.tBox_SBC1.BackColor = System.Drawing.SystemColors.Control;
            this.tBox_SBC1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBox_SBC1.Location = new System.Drawing.Point(99, 126);
            this.tBox_SBC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_SBC1.Multiline = true;
            this.tBox_SBC1.Name = "tBox_SBC1";
            this.tBox_SBC1.ReadOnly = true;
            this.tBox_SBC1.Size = new System.Drawing.Size(424, 316);
            this.tBox_SBC1.TabIndex = 2;
            this.tBox_SBC1.TabStop = false;
            // 
            // tBox_SSD
            // 
            this.tBox_SSD.BackColor = System.Drawing.SystemColors.Window;
            this.tBox_SSD.Location = new System.Drawing.Point(99, 55);
            this.tBox_SSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_SSD.Name = "tBox_SSD";
            this.tBox_SSD.ReadOnly = true;
            this.tBox_SSD.Size = new System.Drawing.Size(262, 30);
            this.tBox_SSD.TabIndex = 1;
            this.tBox_SSD.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSD";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1178, 608);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(970, 62);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 499);
            this.listBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 658);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pBIT_GBOX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KVLS2-C1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pBIT_GBOX.ResumeLayout(false);
            this.pBIT_GBOX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pBIT_GBOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBox_SSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_SBC1;
    }
}

