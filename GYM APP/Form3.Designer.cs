namespace GYM_APP
{
    partial class ViewMember
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
            MemberIDtxtbox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Viewbtn = new Button();
            Cancelbtn = new Button();
            Backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MemberIDtxtbox
            // 
            MemberIDtxtbox.Location = new Point(12, 92);
            MemberIDtxtbox.Name = "MemberIDtxtbox";
            MemberIDtxtbox.Size = new Size(193, 23);
            MemberIDtxtbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 1;
            label1.Text = "Member ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 281);
            dataGridView1.TabIndex = 2;
            // 
            // Viewbtn
            // 
            Viewbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Viewbtn.Location = new Point(12, 121);
            Viewbtn.Name = "Viewbtn";
            Viewbtn.Size = new Size(75, 30);
            Viewbtn.TabIndex = 3;
            Viewbtn.Text = "View";
            Viewbtn.UseVisualStyleBackColor = true;
            Viewbtn.Click += Viewbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cancelbtn.Location = new Point(93, 121);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(75, 30);
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
            Backbtn.Size = new Size(75, 33);
            Backbtn.TabIndex = 3;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbtn);
            Controls.Add(Cancelbtn);
            Controls.Add(Viewbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(MemberIDtxtbox);
            Name = "ViewMember";
            Text = "View Member";
            Load += ViewMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MemberIDtxtbox;
        private Label label1;
        private DataGridView dataGridView1;
        private Button Viewbtn;
        private Button Cancelbtn;
        private Button Backbtn;
    }
}