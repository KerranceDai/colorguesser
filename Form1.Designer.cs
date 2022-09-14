namespace colorguesser
{
    partial class Form1
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
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rText = new System.Windows.Forms.TextBox();
            this.gText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.guessBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(12, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(96, 96);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(138, 35);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(60, 27);
            this.rText.TabIndex = 2;
            // 
            // gText
            // 
            this.gText.Location = new System.Drawing.Point(204, 35);
            this.gText.Name = "gText";
            this.gText.Size = new System.Drawing.Size(60, 27);
            this.gText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
            // 
            // bText
            // 
            this.bText.Location = new System.Drawing.Point(270, 35);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(60, 27);
            this.bText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(194, 79);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(94, 29);
            this.guessButton.TabIndex = 7;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.Control;
            this.resultText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultText.Location = new System.Drawing.Point(138, 121);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(192, 96);
            this.resultText.TabIndex = 8;
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(12, 121);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(96, 96);
            this.guessBox.TabIndex = 9;
            this.guessBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 233);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.bText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "colorguesser";
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox colorBox;
        private Label label1;
        private TextBox rText;
        private TextBox gText;
        private Label label2;
        private TextBox bText;
        private Label label3;
        private Button guessButton;
        private TextBox resultText;
        private PictureBox guessBox;
    }
}