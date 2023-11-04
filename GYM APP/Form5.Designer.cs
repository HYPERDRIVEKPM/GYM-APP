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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            MemberIDtxtbox = new TextBox();
            Viewbtn = new Button();
            Cancelbtn = new Button();
            Backbtn = new Button();
            label2 = new Label();
            Paymenttxtbox = new TextBox();
            Paybtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 279);
            dataGridView1.TabIndex = 0;
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
            // MemberIDtxtbox
            // 
            MemberIDtxtbox.Location = new Point(12, 92);
            MemberIDtxtbox.Name = "MemberIDtxtbox";
            MemberIDtxtbox.Size = new Size(154, 23);
            MemberIDtxtbox.TabIndex = 2;
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
            Paymenttxtbox.TabIndex = 2;
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
            Controls.Add(MemberIDtxtbox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox MemberIDtxtbox;
        private Button Viewbtn;
        private Button Cancelbtn;
        private Button Backbtn;
        private Label label2;
        private TextBox Paymenttxtbox;
        private Button Paybtn;
    }
}