namespace GYM_APP
{
    partial class AddMember
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
            Addbtn = new Button();
            Cancelbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IDtxtbox = new TextBox();
            Nametxtbox = new TextBox();
            Numbertxtbox = new TextBox();
            Backbtn = new Button();
            Memberinfo = new DataGridView();
            label4 = new Label();
            Standardbtn = new RadioButton();
            Vipbtn = new RadioButton();
            time = new Label();
            timer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Memberinfo).BeginInit();
            SuspendLayout();
            // 
            // Addbtn
            // 
            Addbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.Location = new Point(12, 169);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 34);
            Addbtn.TabIndex = 5;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cancelbtn.Location = new Point(93, 169);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(75, 34);
            Cancelbtn.TabIndex = 6;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Contact Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Member ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(180, 69);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Member Name :";
            label3.Click += label3_Click;
            // 
            // IDtxtbox
            // 
            IDtxtbox.Location = new Point(12, 87);
            IDtxtbox.Name = "IDtxtbox";
            IDtxtbox.Size = new Size(156, 23);
            IDtxtbox.TabIndex = 0;
            IDtxtbox.TextChanged += IDtxtbox_TextChanged;
            // 
            // Nametxtbox
            // 
            Nametxtbox.Location = new Point(180, 87);
            Nametxtbox.Name = "Nametxtbox";
            Nametxtbox.Size = new Size(159, 23);
            Nametxtbox.TabIndex = 1;
            // 
            // Numbertxtbox
            // 
            Numbertxtbox.Location = new Point(12, 140);
            Numbertxtbox.Name = "Numbertxtbox";
            Numbertxtbox.Size = new Size(159, 23);
            Numbertxtbox.TabIndex = 2;
            // 
            // Backbtn
            // 
            Backbtn.Location = new Point(12, 12);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(75, 33);
            Backbtn.TabIndex = 7;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // Memberinfo
            // 
            Memberinfo.AllowUserToAddRows = false;
            Memberinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Memberinfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Memberinfo.Location = new Point(12, 209);
            Memberinfo.Name = "Memberinfo";
            Memberinfo.RowTemplate.Height = 25;
            Memberinfo.Size = new Size(776, 229);
            Memberinfo.TabIndex = 3;
            Memberinfo.CellContentClick += Memberinfo_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(258, 20);
            label4.Name = "label4";
            label4.Size = new Size(276, 25);
            label4.TabIndex = 1;
            label4.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // Standardbtn
            // 
            Standardbtn.AutoSize = true;
            Standardbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Standardbtn.Location = new Point(180, 140);
            Standardbtn.Name = "Standardbtn";
            Standardbtn.Size = new Size(81, 21);
            Standardbtn.TabIndex = 3;
            Standardbtn.TabStop = true;
            Standardbtn.Text = "Standard";
            Standardbtn.UseVisualStyleBackColor = true;
            Standardbtn.CheckedChanged += Standardbtn_CheckedChanged;
            // 
            // Vipbtn
            // 
            Vipbtn.AutoSize = true;
            Vipbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Vipbtn.Location = new Point(267, 139);
            Vipbtn.Name = "Vipbtn";
            Vipbtn.Size = new Size(47, 21);
            Vipbtn.TabIndex = 4;
            Vipbtn.TabStop = true;
            Vipbtn.Text = "Vip";
            Vipbtn.UseVisualStyleBackColor = true;
            Vipbtn.CheckedChanged += Vipbtn_CheckedChanged;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(623, 28);
            time.Name = "time";
            time.Size = new Size(0, 15);
            time.TabIndex = 1;
            time.Click += label3_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(180, 169);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 8;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Vipbtn);
            Controls.Add(Standardbtn);
            Controls.Add(Memberinfo);
            Controls.Add(Numbertxtbox);
            Controls.Add(Nametxtbox);
            Controls.Add(IDtxtbox);
            Controls.Add(label4);
            Controls.Add(time);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cancelbtn);
            Controls.Add(Backbtn);
            Controls.Add(Addbtn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Members";
            Load += AddMember_Load;
            ((System.ComponentModel.ISupportInitialize)Memberinfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Addbtn;
        private Button Cancelbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IDtxtbox;
        private TextBox Nametxtbox;
        private TextBox Numbertxtbox;
        private Button Backbtn;
        private DataGridView Memberinfo;
        private Label label4;
        private RadioButton Standardbtn;
        private RadioButton Vipbtn;
        private Label time;
        private System.Windows.Forms.Timer timer;
        private Button button1;
    }
}