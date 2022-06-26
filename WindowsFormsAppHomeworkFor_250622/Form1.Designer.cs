namespace WindowsFormsAppHomeworkFor_250622
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.missionsText = new System.Windows.Forms.Label();
            this.missionsTitleText = new System.Windows.Forms.Label();
            this.resorcesText = new System.Windows.Forms.Label();
            this.WaterButton = new System.Windows.Forms.Button();
            this.WaterButtonText = new System.Windows.Forms.Label();
            this.GrassButtonText = new System.Windows.Forms.Label();
            this.GrassButton = new System.Windows.Forms.Button();
            this.GrassProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // missionsText
            // 
            this.missionsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.missionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.missionsText.Location = new System.Drawing.Point(23, 51);
            this.missionsText.Name = "missionsText";
            this.missionsText.Size = new System.Drawing.Size(295, 508);
            this.missionsText.TabIndex = 0;
            this.missionsText.Text = "Нет задач";
            // 
            // missionsTitleText
            // 
            this.missionsTitleText.AutoSize = true;
            this.missionsTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.missionsTitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.missionsTitleText.Location = new System.Drawing.Point(22, 9);
            this.missionsTitleText.Name = "missionsTitleText";
            this.missionsTitleText.Size = new System.Drawing.Size(87, 26);
            this.missionsTitleText.TabIndex = 1;
            this.missionsTitleText.Text = "Задачи";
            // 
            // resorcesText
            // 
            this.resorcesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.resorcesText.Location = new System.Drawing.Point(347, 52);
            this.resorcesText.Name = "resorcesText";
            this.resorcesText.Size = new System.Drawing.Size(191, 332);
            this.resorcesText.TabIndex = 2;
            this.resorcesText.Text = "Нет ресурсов";
            // 
            // WaterButton
            // 
            this.WaterButton.BackColor = System.Drawing.Color.PowderBlue;
            this.WaterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaterButton.Location = new System.Drawing.Point(351, 500);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(63, 59);
            this.WaterButton.TabIndex = 3;
            this.WaterButton.TabStop = false;
            this.WaterButton.Text = "Качать воду";
            this.WaterButton.UseVisualStyleBackColor = false;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // WaterButtonText
            // 
            this.WaterButtonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.WaterButtonText.Location = new System.Drawing.Point(348, 435);
            this.WaterButtonText.Name = "WaterButtonText";
            this.WaterButtonText.Size = new System.Drawing.Size(66, 62);
            this.WaterButtonText.TabIndex = 4;
            this.WaterButtonText.Text = "+ 1 Water";
            this.WaterButtonText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GrassButtonText
            // 
            this.GrassButtonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GrassButtonText.Location = new System.Drawing.Point(440, 410);
            this.GrassButtonText.Name = "GrassButtonText";
            this.GrassButtonText.Size = new System.Drawing.Size(66, 62);
            this.GrassButtonText.TabIndex = 6;
            this.GrassButtonText.Text = "- 1 Water\r\n\r\n+20% Grass";
            this.GrassButtonText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GrassButton
            // 
            this.GrassButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GrassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrassButton.Location = new System.Drawing.Point(443, 500);
            this.GrassButton.Name = "GrassButton";
            this.GrassButton.Size = new System.Drawing.Size(63, 59);
            this.GrassButton.TabIndex = 5;
            this.GrassButton.TabStop = false;
            this.GrassButton.Text = "Растить траву";
            this.GrassButton.UseVisualStyleBackColor = false;
            this.GrassButton.Click += new System.EventHandler(this.GrassButton_Click);
            // 
            // GrassProgressBar
            // 
            this.GrassProgressBar.Location = new System.Drawing.Point(443, 484);
            this.GrassProgressBar.MarqueeAnimationSpeed = 5;
            this.GrassProgressBar.Name = "GrassProgressBar";
            this.GrassProgressBar.Size = new System.Drawing.Size(63, 13);
            this.GrassProgressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(727, 594);
            this.Controls.Add(this.GrassProgressBar);
            this.Controls.Add(this.GrassButtonText);
            this.Controls.Add(this.GrassButton);
            this.Controls.Add(this.WaterButtonText);
            this.Controls.Add(this.WaterButton);
            this.Controls.Add(this.resorcesText);
            this.Controls.Add(this.missionsTitleText);
            this.Controls.Add(this.missionsText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label missionsText;
        private System.Windows.Forms.Label missionsTitleText;
        private System.Windows.Forms.Label resorcesText;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Label WaterButtonText;
        private System.Windows.Forms.Label GrassButtonText;
        private System.Windows.Forms.Button GrassButton;
        private System.Windows.Forms.ProgressBar GrassProgressBar;
    }
}

