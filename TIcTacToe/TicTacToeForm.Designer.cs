namespace TIcTacToe
{
    partial class TicTacToeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            winnerLable = new Label();
            restartButton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // winnerLable
            // 
            winnerLable.BackColor = SystemColors.ButtonFace;
            winnerLable.Font = new Font("Viner Hand ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winnerLable.Location = new Point(86, 42);
            winnerLable.Name = "winnerLable";
            winnerLable.Size = new Size(325, 43);
            winnerLable.TabIndex = 9;
            // 
            // restartButton
            // 
            restartButton.Font = new Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restartButton.Location = new Point(176, 466);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(151, 46);
            restartButton.TabIndex = 10;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button2.Location = new Point(86, 119);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button3.Location = new Point(207, 119);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(324, 119);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 13;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button5.Location = new Point(86, 228);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 14;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button6.Location = new Point(207, 228);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 15;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button7.Location = new Point(324, 228);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 16;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button8.Location = new Point(86, 340);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 17;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button9.Location = new Point(207, 340);
            button9.Name = "button9";
            button9.Size = new Size(90, 90);
            button9.TabIndex = 18;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold);
            button10.Location = new Point(324, 340);
            button10.Name = "button10";
            button10.Size = new Size(90, 90);
            button10.TabIndex = 19;
            button10.UseVisualStyleBackColor = true;
            // 
            // TicTacToeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(521, 533);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(restartButton);
            Controls.Add(winnerLable);
            Name = "TicTacToeForm";
            Text = "TicTacToeForm";
            ResumeLayout(false);
        }

        #endregion
        private Label winnerLable;
        private Button restartButton;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}