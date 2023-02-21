namespace MEGABITE_CRM
{
    partial class Form2
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
            this.signupbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(135, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 58);
            this.label7.TabIndex = 30;
            this.label7.Text = "Hello There!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 56);
            this.label6.TabIndex = 29;
            this.label6.Text = "Automatic identity verification whith enable yo to verify your verify";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(135, 550);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(248, 54);
            this.signupbutton.TabIndex = 24;
            this.signupbutton.Text = "Sign In";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 54);
            this.button1.TabIndex = 31;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.signupbutton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label7;
        private Label label6;
        private Button signupbutton;
        private Button button1;
    }
}