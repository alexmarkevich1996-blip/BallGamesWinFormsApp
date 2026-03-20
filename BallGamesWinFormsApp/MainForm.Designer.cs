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
            timerForBall = new System.Windows.Forms.Timer(components);
            createBallsButton = new Button();
            stopBallsButton = new Button();
            SuspendLayout();
            // 
            // timerForBall
            // 
            timerForBall.Tick += timerForBall_Tick;
            // 
            // createBallsButton
            // 
            createBallsButton.Location = new Point(952, 40);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(168, 50);
            createBallsButton.TabIndex = 0;
            createBallsButton.Text = "Create Balls";
            createBallsButton.UseVisualStyleBackColor = true;
            createBallsButton.Click += CreateBallsButton_Click;
            // 
            // stopBallsButton
            // 
            stopBallsButton.Location = new Point(952, 114);
            stopBallsButton.Name = "stopBallsButton";
            stopBallsButton.Size = new Size(168, 50);
            stopBallsButton.TabIndex = 1;
            stopBallsButton.Text = "Stop Balls";
            stopBallsButton.UseVisualStyleBackColor = true;
            stopBallsButton.Click += stopBallsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 746);
            Controls.Add(stopBallsButton);
            Controls.Add(createBallsButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerForBall;
        private Button createBallsButton;
        private Button stopBallsButton;
    }
}
