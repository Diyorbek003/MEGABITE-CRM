namespace MEGABITE_CRM
{
    partial class signupform
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 382);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 31);
            this.textBox3.TabIndex = 2;
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(131, 464);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(248, 54);
            this.signupbutton.TabIndex = 3;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Already have an account?";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(309, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(131, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(131, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(130, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(130, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Create an account free";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(131, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 58);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sign Up";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 643);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "signupform";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button signupbutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}