namespace GYM_APP
{
    partial class Mainmenu
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
            Viewmemberbtn = new Button();
            Addmemberbtn = new Button();
            Paymentbtn = new Button();
            Gatebtn = new Button();
            Backbtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Viewmemberbtn
            // 
            Viewmemberbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Viewmemberbtn.Location = new Point(285, 129);
            Viewmemberbtn.Name = "Viewmemberbtn";
            Viewmemberbtn.Size = new Size(173, 36);
            Viewmemberbtn.TabIndex = 0;
            Viewmemberbtn.Text = "View Member";
            Viewmemberbtn.UseVisualStyleBackColor = true;
            Viewmemberbtn.Click += Viewmemberbtn_Click;
            // 
            // Addmemberbtn
            // 
            Addmemberbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Addmemberbtn.Location = new Point(285, 192);
            Addmemberbtn.Name = "Addmemberbtn";
            Addmemberbtn.Size = new Size(173, 36);
            Addmemberbtn.TabIndex = 0;
            Addmemberbtn.Text = "Add Member";
            Addmemberbtn.UseVisualStyleBackColor = true;
            Addmemberbtn.Click += Addmemberbtn_Click;
            // 
            // Paymentbtn
            // 
            Paymentbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Paymentbtn.Location = new Point(285, 253);
            Paymentbtn.Name = "Paymentbtn";
            Paymentbtn.Size = new Size(173, 36);
            Paymentbtn.TabIndex = 0;
            Paymentbtn.Text = "Payment";
            Paymentbtn.UseVisualStyleBackColor = true;
            Paymentbtn.Click += Paymentbtn_Click;
            // 
            // Gatebtn
            // 
            Gatebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Gatebtn.Location = new Point(285, 313);
            Gatebtn.Name = "Gatebtn";
            Gatebtn.Size = new Size(173, 36);
            Gatebtn.TabIndex = 0;
            Gatebtn.Text = "Gate Open";
            Gatebtn.UseVisualStyleBackColor = true;
            Gatebtn.Click += Gatebtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.Location = new Point(12, 12);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(102, 36);
            Backbtn.TabIndex = 0;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 75);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 1;
            label1.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(Gatebtn);
            Controls.Add(Paymentbtn);
            Controls.Add(Addmemberbtn);
            Controls.Add(Viewmemberbtn);
            Name = "Mainmenu";
            Text = "Backbtn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Viewmemberbtn;
        private Button Addmemberbtn;
        private Button Paymentbtn;
        private Button Gatebtn;
        private Button Backbtn;
        private Label label1;
    }
}