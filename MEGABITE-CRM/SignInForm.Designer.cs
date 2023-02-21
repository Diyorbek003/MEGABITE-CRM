namespace MEGABITE_CRM
{
    partial class signinform
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.signupbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(135, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 58);
            this.label7.TabIndex = 21;
            this.label7.Text = "Welcome";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(135, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 56);
            this.label6.TabIndex = 20;
            this.label6.Text = "welcome to our app";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 58);
            this.label1.TabIndex = 32;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(134, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 55);
            this.label2.TabIndex = 31;
            this.label2.Text = "Welcome back! Login whith your credentials";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(135, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(135, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(309, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sign Up";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(134, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Dont have an account?";
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(135, 483);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(248, 54);
            this.signupbutton.TabIndex = 25;
            this.signupbutton.Text = "Login";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 31);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 31);
            this.textBox1.TabIndex = 22;
            // 
            // signinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "signinform";
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label9;
        private Button signupbutton;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}