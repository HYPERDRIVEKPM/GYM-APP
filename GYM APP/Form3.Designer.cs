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
            components = new System.ComponentModel.Container();
            MemberIDtxtbox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Viewbtn = new Button();
            Cancelbtn = new Button();
            Backbtn = new Button();
            label2 = new Label();
            time = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            ViewAllbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MemberIDtxtbox
            // 
            MemberIDtxtbox.Location = new Point(12, 92);
            MemberIDtxtbox.Name = "MemberIDtxtbox";
            MemberIDtxtbox.Size = new Size(193, 23);
            MemberIDtxtbox.TabIndex = 0;
            MemberIDtxtbox.TextChanged += MemberIDtxtbox_TextChanged;
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Viewbtn.TabIndex = 1;
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
            Cancelbtn.TabIndex = 2;
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
            Backbtn.TabIndex = 4;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(242, 20);
            label2.Name = "label2";
            label2.Size = new Size(276, 25);
            label2.TabIndex = 1;
            label2.Text = "GYM MNAGAEMENT SYSTEM";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(634, 20);
            time.Name = "time";
            time.Size = new Size(0, 17);
            time.TabIndex = 1;
            time.Click += time_Click;
            // 
            // timer
            // 
            timer.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1254, 20);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 1;
            label3.Text = "View All";
            label3.Click += time_Click;
            // 
            // ViewAllbtn
            // 
            ViewAllbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewAllbtn.Location = new Point(713, 121);
            ViewAllbtn.Name = "ViewAllbtn";
            ViewAllbtn.Size = new Size(75, 30);
            ViewAllbtn.TabIndex = 3;
            ViewAllbtn.Text = "View All";
            ViewAllbtn.UseVisualStyleBackColor = true;
            ViewAllbtn.Click += ViewAllbtn_Click;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewAllbtn);
            Controls.Add(Backbtn);
            Controls.Add(Cancelbtn);
            Controls.Add(Viewbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(time);
            Controls.Add(label1);
            Controls.Add(MemberIDtxtbox);
            Name = "ViewMember";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label2;
        private Label time;
        private System.Windows.Forms.Timer timer;
        private Label label3;
        private Button ViewAllbtn;
    }
}