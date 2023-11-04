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
            Addbtn = new Button();
            Cancelbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Backbtn = new Button();
            dataGridView1 = new DataGridView();
            Standardbtn = new RadioButton();
            Vipbtn = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(12, 169);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 34);
            Addbtn.TabIndex = 0;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Location = new Point(93, 169);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(75, 34);
            Cancelbtn.TabIndex = 0;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 2;
            // 
            // Backbtn
            // 
            Backbtn.Location = new Point(12, 12);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(75, 33);
            Backbtn.TabIndex = 0;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 229);
            dataGridView1.TabIndex = 3;
            // 
            // Standardbtn
            // 
            Standardbtn.AutoSize = true;
            Standardbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Standardbtn.Location = new Point(180, 140);
            Standardbtn.Name = "Standardbtn";
            Standardbtn.Size = new Size(81, 21);
            Standardbtn.TabIndex = 4;
            Standardbtn.TabStop = true;
            Standardbtn.Text = "Standard";
            Standardbtn.UseVisualStyleBackColor = true;
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
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Vipbtn);
            Controls.Add(Standardbtn);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cancelbtn);
            Controls.Add(Backbtn);
            Controls.Add(Addbtn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "AddMember";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Addbtn;
        private Button Cancelbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Backbtn;
        private DataGridView dataGridView1;
        private RadioButton Standardbtn;
        private RadioButton Vipbtn;
    }
}