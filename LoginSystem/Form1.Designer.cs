namespace LoginSystem
{
    partial class Inlog
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
            Userlabel = new Label();
            Passwordlabel = new Label();
            txtUser = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.Location = new Point(142, 99);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(60, 15);
            Userlabel.TabIndex = 0;
            Userlabel.Text = "Username";
            Userlabel.Click += label1_Click;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(142, 201);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(57, 15);
            Passwordlabel.TabIndex = 1;
            Passwordlabel.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(272, 96);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(201, 23);
            txtUser.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(212, 269);
            button1.Name = "button1";
            button1.Size = new Size(169, 53);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Inlog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(txtUser);
            Controls.Add(Passwordlabel);
            Controls.Add(Userlabel);
            Name = "Inlog";
            ShowIcon = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Userlabel;
        private Label Passwordlabel;
        private TextBox txtUser;
        private TextBox textBox2;
        private Button button1;
    }
}
