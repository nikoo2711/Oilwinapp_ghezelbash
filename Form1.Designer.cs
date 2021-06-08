namespace GuessNumber_Ghezelbash
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
            this.NumbertextBox = new System.Windows.Forms.TextBox();
            this.resultLable = new System.Windows.Forms.Label();
            this.GuessButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CounteLable = new System.Windows.Forms.Label();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumbertextBox
            // 
            this.NumbertextBox.Location = new System.Drawing.Point(90, 35);
            this.NumbertextBox.Name = "NumbertextBox";
            this.NumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.NumbertextBox.TabIndex = 0;
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(52, 126);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(0, 13);
            this.resultLable.TabIndex = 1;
            // 
            // GuessButon
            // 
            this.GuessButon.Location = new System.Drawing.Point(55, 77);
            this.GuessButon.Name = "GuessButon";
            this.GuessButon.Size = new System.Drawing.Size(63, 35);
            this.GuessButon.TabIndex = 2;
            this.GuessButon.Text = "Guess";
            this.GuessButon.UseVisualStyleBackColor = true;
            this.GuessButon.Click += new System.EventHandler(this.GuessButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(24, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count:";
            // 
            // CounteLable
            // 
            this.CounteLable.AutoSize = true;
            this.CounteLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CounteLable.Location = new System.Drawing.Point(75, 237);
            this.CounteLable.Name = "CounteLable";
            this.CounteLable.Size = new System.Drawing.Size(0, 16);
            this.CounteLable.TabIndex = 4;
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(124, 77);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(75, 35);
            this.Resetbutton.TabIndex = 5;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.CounteLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuessButon);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.NumbertextBox);
            this.Name = "Form1";
            this.Text = "GuessNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumbertextBox;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Button GuessButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CounteLable;
        private System.Windows.Forms.Button Resetbutton;
    }
}

