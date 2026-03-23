namespace CatchMe2_WinFormsApp
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
            createButton = new Button();
            clearButton = new Button();
            countBallsLabel = new Label();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(661, 47);
            createButton.Name = "createButton";
            createButton.Size = new Size(80, 30);
            createButton.TabIndex = 0;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(661, 83);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(80, 29);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // countBallsLabel
            // 
            countBallsLabel.AutoSize = true;
            countBallsLabel.Location = new Point(599, 47);
            countBallsLabel.Name = "countBallsLabel";
            countBallsLabel.Size = new Size(13, 15);
            countBallsLabel.TabIndex = 2;
            countBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countBallsLabel);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createButton;
        private Button clearButton;
        private Label countBallsLabel;
    }
}
