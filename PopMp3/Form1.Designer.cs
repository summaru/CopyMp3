namespace PopMp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDirList = new System.Windows.Forms.TextBox();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.btnRunLogic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirList
            // 
            this.txtDirList.Location = new System.Drawing.Point(12, 36);
            this.txtDirList.Multiline = true;
            this.txtDirList.Name = "txtDirList";
            this.txtDirList.Size = new System.Drawing.Size(260, 221);
            this.txtDirList.TabIndex = 1;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(12, 303);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(80, 30);
            this.btnOpenDialog.TabIndex = 2;
            this.btnOpenDialog.Text = "Open";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // btnRunLogic
            // 
            this.btnRunLogic.Location = new System.Drawing.Point(192, 303);
            this.btnRunLogic.Name = "btnRunLogic";
            this.btnRunLogic.Size = new System.Drawing.Size(80, 30);
            this.btnRunLogic.TabIndex = 3;
            this.btnRunLogic.Text = "Run";
            this.btnRunLogic.UseVisualStyleBackColor = true;
            this.btnRunLogic.Click += new System.EventHandler(this.btnRunLogic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.btnRunLogic);
            this.Controls.Add(this.btnOpenDialog);
            this.Controls.Add(this.txtDirList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CopyMp3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDirList;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Button btnRunLogic;
    }
}

