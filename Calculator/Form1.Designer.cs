namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Operation = new System.Windows.Forms.TextBox();
            this.Modulus = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Operation
            // 
            this.Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Operation.Location = new System.Drawing.Point(147, 12);
            this.Operation.Multiline = true;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Size = new System.Drawing.Size(34, 40);
            this.Operation.TabIndex = 2;
            this.Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Modulus
            // 
            this.Modulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.Modulus.Location = new System.Drawing.Point(12, 194);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(304, 51);
            this.Modulus.TabIndex = 6;
            this.Modulus.Text = "%";
            this.Modulus.UseVisualStyleBackColor = true;
            this.Modulus.Click += new System.EventHandler(this.button4_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.Add.Location = new System.Drawing.Point(12, 58);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(147, 62);
            this.Add.TabIndex = 7;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.Minus.Location = new System.Drawing.Point(12, 126);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(147, 62);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.Multiply.Location = new System.Drawing.Point(164, 58);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(151, 62);
            this.Multiply.TabIndex = 9;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.Divide.Location = new System.Drawing.Point(165, 126);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(150, 62);
            this.Divide.TabIndex = 10;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Result.Location = new System.Drawing.Point(12, 251);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(303, 47);
            this.Result.TabIndex = 11;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Number1
            // 
            this.Number1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Number1.Location = new System.Drawing.Point(12, 12);
            this.Number1.Multiline = true;
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(129, 40);
            this.Number1.TabIndex = 14;
            this.Number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number1.TextChanged += new System.EventHandler(this.Number1_TextChanged_1);
            this.Number1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Number1_KeyUp);
            // 
            // Number2
            // 
            this.Number2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Number2.Location = new System.Drawing.Point(187, 12);
            this.Number2.Multiline = true;
            this.Number2.Name = "Number2";
            this.Number2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Number2.Size = new System.Drawing.Size(128, 40);
            this.Number2.TabIndex = 15;
            this.Number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.Number2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Number2_KeyUp);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(328, 327);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.Operation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.Button Modulus;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
    }
}

