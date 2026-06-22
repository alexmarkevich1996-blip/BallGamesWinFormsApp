namespace BilliardBalls_WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            leftLabel = new Label();
            topLabel = new Label();
            rightLabel = new Label();
            downLabel = new Label();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftLabel.Location = new Point(16, 185);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(15, 17);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLabel.Location = new Point(394, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(15, 17);
            topLabel.TabIndex = 1;
            topLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rightLabel.Location = new Point(773, 185);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(15, 17);
            rightLabel.TabIndex = 2;
            rightLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downLabel.Location = new Point(394, 424);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(15, 17);
            downLabel.TabIndex = 3;
            downLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downLabel);
            Controls.Add(rightLabel);
            Controls.Add(topLabel);
            Controls.Add(leftLabel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label topLabel;
        private Label rightLabel;
        private Label downLabel;
    }
}
