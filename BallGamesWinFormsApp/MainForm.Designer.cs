namespace BallGamesWinFormsApp
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
            components = new System.ComponentModel.Container();
            createRandomBallButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            stopAllBallsButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // createRandomBallButton
            // 
            createRandomBallButton.Location = new Point(994, 107);
            createRandomBallButton.Name = "createRandomBallButton";
            createRandomBallButton.Size = new Size(120, 38);
            createRandomBallButton.TabIndex = 1;
            createRandomBallButton.Text = "Create Random Balls";
            createRandomBallButton.UseVisualStyleBackColor = true;
            createRandomBallButton.Click += DrawRandomBallButton_Click;
            // 
            // stopAllBallsButton
            // 
            stopAllBallsButton.Location = new Point(994, 151);
            stopAllBallsButton.Name = "stopAllBallsButton";
            stopAllBallsButton.Size = new Size(120, 36);
            stopAllBallsButton.TabIndex = 2;
            stopAllBallsButton.Text = "Stop All Balls";
            stopAllBallsButton.UseVisualStyleBackColor = true;
            stopAllBallsButton.Click += StopAllBallsButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(994, 203);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(120, 31);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += CleanButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 746);
            Controls.Add(clearButton);
            Controls.Add(stopAllBallsButton);
            Controls.Add(createRandomBallButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button createRandomBallButton;
        private System.Windows.Forms.Timer timer;
        private Button stopAllBallsButton;
        private Button clearButton;
    }
}
