namespace GYM_APP
{
    partial class Payment
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
            components = new System.ComponentModel.Container();
            Memberinfo = new DataGridView();
            label1 = new Label();
            IDtxtbox = new TextBox();
            Viewbtn = new Button();
            Cancelbtn = new Button();
            Backbtn = new Button();
            label2 = new Label();
            Paymenttxtbox = new TextBox();
            Paybtn = new Button();
            label3 = new Label();
            time = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Memberinfo).BeginInit();
            SuspendLayout();
            // 
            // Memberinfo
            // 
            Memberinfo.AllowUserToAddRows = false;
            Memberinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Memberinfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Memberinfo.Location = new Point(12, 159);
            Memberinfo.Name = "Memberinfo";
            Memberinfo.RowTemplate.Height = 25;
            Memberinfo.Size = new Size(776, 279);
            Memberinfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 1;
            label1.Text = "Member ID : ";
            // 
            // IDtxtbox
            // 
            IDtxtbox.Location = new Point(12, 92);
            IDtxtbox.Name = "IDtxtbox";
            IDtxtbox.Size = new Size(154, 23);
            IDtxtbox.TabIndex = 0;
            IDtxtbox.TextChanged += IDtxtbox_TextChanged;
            // 
            // Viewbtn
            // 
            Viewbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Viewbtn.Location = new Point(12, 121);
            Viewbtn.Name = "Viewbtn";
            Viewbtn.Size = new Size(75, 32);
            Viewbtn.TabIndex = 3;
            Viewbtn.Text = "View";
            Viewbtn.UseVisualStyleBackColor = true;
            Viewbtn.Click += Viewbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cancelbtn.Location = new Point(711, 121);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(75, 32);
            Cancelbtn.TabIndex = 3;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.Location = new Point(12, 12);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(75, 32);
            Backbtn.TabIndex = 3;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(632, 72);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 1;
            label2.Text = "Payment :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Paymenttxtbox
            // 
            Paymenttxtbox.Location = new Point(632, 92);
            Paymenttxtbox.Name = "Paymenttxtbox";
            Paymenttxtbox.Size = new Size(154, 23);
            Paymenttxtbox.TabIndex = 1;
            // 
            // Paybtn
            // 
            Paybtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Paybtn.Location = new Point(630, 121);
            Paybtn.Name = "Paybtn";
            Paybtn.Size = new Size(75, 32);
            Paybtn.TabIndex = 3;
            Paybtn.Text = "Pay";
            Paybtn.UseVisualStyleBackColor = true;
            Paybtn.Click += Paybtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(244, 19);
            label3.Name = "label3";
            label3.Size = new Size(276, 25);
            label3.TabIndex = 1;
            label3.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(619, 25);
            time.Name = "time";
            time.Size = new Size(0, 17);
            time.TabIndex = 1;
            time.Click += label4_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbtn);
            Controls.Add(Cancelbtn);
            Controls.Add(Paybtn);
            Controls.Add(Paymenttxtbox);
            Controls.Add(Viewbtn);
            Controls.Add(label2);
            Controls.Add(IDtxtbox);
            Controls.Add(label3);
            Controls.Add(time);
            Controls.Add(label1);
            Controls.Add(Memberinfo);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)Memberinfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Memberinfo;
        private Label label1;
        private TextBox IDtxtbox;
        private Button Viewbtn;
        private Button Cancelbtn;
        private Button Backbtn;
        private Label label2;
        private TextBox Paymenttxtbox;
        private Button Paybtn;
        private Label label3;
        private Label time;
        private System.Windows.Forms.Timer timer;
    }
}