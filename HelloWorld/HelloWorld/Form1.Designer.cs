namespace HelloWorld
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.WorkingLabel = new System.Windows.Forms.Label();
            this.OctoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OctoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkingLabel
            // 
            this.WorkingLabel.AutoSize = true;
            this.WorkingLabel.Location = new System.Drawing.Point(66, 216);
            this.WorkingLabel.Name = "WorkingLabel";
            this.WorkingLabel.Size = new System.Drawing.Size(113, 12);
            this.WorkingLabel.TabIndex = 0;
            this.WorkingLabel.Text = "HelloWorld Is Work!";
            // 
            // OctoBox
            // 
            this.OctoBox.Image = ((System.Drawing.Image)(resources.GetObject("OctoBox.Image")));
            this.OctoBox.Location = new System.Drawing.Point(12, 12);
            this.OctoBox.Name = "OctoBox";
            this.OctoBox.Size = new System.Drawing.Size(225, 201);
            this.OctoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OctoBox.TabIndex = 1;
            this.OctoBox.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 237);
            this.Controls.Add(this.OctoBox);
            this.Controls.Add(this.WorkingLabel);
            this.Name = "Welcome";
            this.Text = "Welcome To GitHub";
            ((System.ComponentModel.ISupportInitialize)(this.OctoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkingLabel;
        private System.Windows.Forms.PictureBox OctoBox;
    }
}

