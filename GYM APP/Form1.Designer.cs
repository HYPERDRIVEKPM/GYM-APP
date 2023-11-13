namespace GYM_APP
{
    partial class Login
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
            label1 = new Label();
            Loginbtn = new Button();
            Cancelbtn = new Button();
            Passwordtxtbox = new TextBox();
            Empidtxtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 170);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE ID :";
            // 
            // Loginbtn
            // 
            Loginbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Loginbtn.Location = new Point(267, 279);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(96, 30);
            Loginbtn.TabIndex = 2;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += button1_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cancelbtn.Location = new Point(383, 279);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(92, 30);
            Cancelbtn.TabIndex = 3;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += button2_Click;
            // 
            // Passwordtxtbox
            // 
            Passwordtxtbox.Location = new Point(267, 250);
            Passwordtxtbox.Name = "Passwordtxtbox";
            Passwordtxtbox.Size = new Size(208, 23);
            Passwordtxtbox.TabIndex = 1;
            // 
            // Empidtxtbox
            // 
            Empidtxtbox.Location = new Point(267, 190);
            Empidtxtbox.Name = "Empidtxtbox";
            Empidtxtbox.Size = new Size(208, 23);
            Empidtxtbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(333, 230);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(248, 114);
            label3.Name = "label3";
            label3.Size = new Size(241, 21);
            label3.TabIndex = 0;
            label3.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Empidtxtbox);
            Controls.Add(Passwordtxtbox);
            Controls.Add(Cancelbtn);
            Controls.Add(Loginbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Loginbtn;
        private Button Cancelbtn;
        private TextBox Passwordtxtbox;
        private TextBox Empidtxtbox;
        private Label label2;
        private Label label3;
    }
}