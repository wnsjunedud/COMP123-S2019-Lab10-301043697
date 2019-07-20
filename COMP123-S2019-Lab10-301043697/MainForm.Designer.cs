namespace COMP123_S2019_Lab10_301043697
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
            this.MainFormLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainFormLabel
            // 
            this.MainFormLabel.AutoSize = true;
            this.MainFormLabel.Location = new System.Drawing.Point(42, 35);
            this.MainFormLabel.Name = "MainFormLabel";
            this.MainFormLabel.Size = new System.Drawing.Size(627, 54);
            this.MainFormLabel.TabIndex = 0;
            this.MainFormLabel.Text = "Welcome to Main Form!";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackButton.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackButton.Location = new System.Drawing.Point(606, 446);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(156, 62);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Next";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 53F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MainFormLabel);
            this.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainFormLabel;
        private System.Windows.Forms.Button BackButton;
    }
}

