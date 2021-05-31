namespace DiceRoll
{
    partial class Form1
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
            this.rollButton = new System.Windows.Forms.Button();
            this.dice1Label = new System.Windows.Forms.Label();
            this.numSides = new System.Windows.Forms.TextBox();
            this.dice2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidesText = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.snakeEyes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(127, 144);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(125, 125);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Visible = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // dice1Label
            // 
            this.dice1Label.AutoSize = true;
            this.dice1Label.BackColor = System.Drawing.Color.PapayaWhip;
            this.dice1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1Label.Location = new System.Drawing.Point(326, 165);
            this.dice1Label.Name = "dice1Label";
            this.dice1Label.Size = new System.Drawing.Size(59, 65);
            this.dice1Label.TabIndex = 1;
            this.dice1Label.Text = "1";
            // 
            // numSides
            // 
            this.numSides.Location = new System.Drawing.Point(140, 322);
            this.numSides.Name = "numSides";
            this.numSides.Size = new System.Drawing.Size(100, 20);
            this.numSides.TabIndex = 2;
            // 
            // dice2Label
            // 
            this.dice2Label.AutoSize = true;
            this.dice2Label.BackColor = System.Drawing.Color.PapayaWhip;
            this.dice2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2Label.Location = new System.Drawing.Point(464, 165);
            this.dice2Label.Name = "dice2Label";
            this.dice2Label.Size = new System.Drawing.Size(59, 65);
            this.dice2Label.TabIndex = 3;
            this.dice2Label.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dice Game";
            // 
            // sidesText
            // 
            this.sidesText.AutoSize = true;
            this.sidesText.Location = new System.Drawing.Point(124, 292);
            this.sidesText.Name = "sidesText";
            this.sidesText.Size = new System.Drawing.Size(174, 13);
            this.sidesText.TabIndex = 5;
            this.sidesText.Text = "Enter number of sides per dice (1+):";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(152, 348);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 6;
            this.setButton.Text = "Set Sides";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // snakeEyes
            // 
            this.snakeEyes.AutoSize = true;
            this.snakeEyes.Location = new System.Drawing.Point(383, 269);
            this.snakeEyes.Name = "snakeEyes";
            this.snakeEyes.Size = new System.Drawing.Size(35, 13);
            this.snakeEyes.TabIndex = 7;
            this.snakeEyes.Text = "label2";
            this.snakeEyes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 390);
            this.Controls.Add(this.snakeEyes);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.sidesText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice2Label);
            this.Controls.Add(this.numSides);
            this.Controls.Add(this.dice1Label);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox numSides;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sidesText;
        private System.Windows.Forms.Button setButton;
        internal System.Windows.Forms.Label dice1Label;
        internal System.Windows.Forms.Label dice2Label;
        private System.Windows.Forms.Label snakeEyes;
    }
}

