namespace UI
{
    partial class FormCustomer
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
            ReadOneCustomer = new Button();
            ReadAllButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            DeletePanel = new Panel();
            label13 = new Label();
            textBoxReadOne = new TextBox();
            sumbitReadOne = new Button();
            panel5 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            AddPanel = new Panel();
            checkBoxClubAdd = new CheckBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            AddSubmit = new Button();
            label2 = new Label();
            addPhone = new Label();
            addAdress = new Label();
            addId = new Label();
            addName = new Label();
            panel4 = new Panel();
            checkBoxClubUpdate = new CheckBox();
            textBoxUpdatePhone = new TextBox();
            textBoxUpdateAddress = new TextBox();
            textBoxUpdateId = new TextBox();
            textBoxUpdateName = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            DeletePanel.SuspendLayout();
            panel5.SuspendLayout();
            AddPanel.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(513, 382);
            dataGridView1.TabIndex = 2;
            // 
            // ReadOneCustomer
            // 
            ReadOneCustomer.Location = new Point(578, 142);
            ReadOneCustomer.Margin = new Padding(3, 2, 3, 2);
            ReadOneCustomer.Name = "ReadOneCustomer";
            ReadOneCustomer.Size = new Size(102, 25);
            ReadOneCustomer.TabIndex = 11;
            ReadOneCustomer.Text = "הצג בודד";
            ReadOneCustomer.UseVisualStyleBackColor = true;
            ReadOneCustomer.Click += ReadOneCustomer_Click;
            // 
            // ReadAllButton
            // 
            ReadAllButton.Location = new Point(578, 112);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(102, 28);
            ReadAllButton.TabIndex = 7;
            ReadAllButton.Text = "הצג הכל";
            ReadAllButton.UseVisualStyleBackColor = true;
            ReadAllButton.Click += ReadAllButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(578, 83);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 28);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "מחיקה";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(578, 54);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(102, 28);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "עדכון";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(578, 25);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(102, 28);
            AddButton.TabIndex = 10;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeletePanel
            // 
            DeletePanel.Controls.Add(label13);
            DeletePanel.Controls.Add(textBoxReadOne);
            DeletePanel.Controls.Add(sumbitReadOne);
            DeletePanel.Location = new Point(578, 302);
            DeletePanel.Name = "DeletePanel";
            DeletePanel.Size = new Size(166, 102);
            DeletePanel.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(53, 15);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 15;
            label13.Text = "מספר זהות";
            // 
            // textBoxReadOne
            // 
            textBoxReadOne.Location = new Point(14, 32);
            textBoxReadOne.Margin = new Padding(3, 2, 3, 2);
            textBoxReadOne.Name = "textBoxReadOne";
            textBoxReadOne.Size = new Size(135, 23);
            textBoxReadOne.TabIndex = 14;
            // 
            // sumbitReadOne
            // 
            sumbitReadOne.Location = new Point(37, 59);
            sumbitReadOne.Margin = new Padding(3, 2, 3, 2);
            sumbitReadOne.Name = "sumbitReadOne";
            sumbitReadOne.Size = new Size(82, 22);
            sumbitReadOne.TabIndex = 13;
            sumbitReadOne.Text = "אישור";
            sumbitReadOne.UseVisualStyleBackColor = true;
            sumbitReadOne.Click += sumbitReadOne_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(88, 302);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 38);
            panel5.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(76, 10);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "אישור";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 14);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "מספר זהות";
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(checkBoxClubAdd);
            AddPanel.Controls.Add(textBoxPhone);
            AddPanel.Controls.Add(textBoxAddress);
            AddPanel.Controls.Add(textBoxId);
            AddPanel.Controls.Add(textBoxName);
            AddPanel.Controls.Add(AddSubmit);
            AddPanel.Controls.Add(label2);
            AddPanel.Controls.Add(addPhone);
            AddPanel.Controls.Add(addAdress);
            AddPanel.Controls.Add(addId);
            AddPanel.Controls.Add(addName);
            AddPanel.Location = new Point(51, 33);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(500, 250);
            AddPanel.TabIndex = 15;
            // 
            // checkBoxClubAdd
            // 
            checkBoxClubAdd.AutoSize = true;
            checkBoxClubAdd.Location = new Point(241, 150);
            checkBoxClubAdd.Margin = new Padding(3, 2, 3, 2);
            checkBoxClubAdd.Name = "checkBoxClubAdd";
            checkBoxClubAdd.Size = new Size(56, 19);
            checkBoxClubAdd.TabIndex = 5;
            checkBoxClubAdd.Text = "מועדון";
            checkBoxClubAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(187, 117);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(187, 90);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 4;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(187, 64);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(187, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 4;
            // 
            // AddSubmit
            // 
            AddSubmit.Location = new Point(241, 173);
            AddSubmit.Name = "AddSubmit";
            AddSubmit.Size = new Size(75, 23);
            AddSubmit.TabIndex = 4;
            AddSubmit.Text = "להוספה";
            AddSubmit.UseVisualStyleBackColor = true;
            AddSubmit.Click += AddSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 45);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // addPhone
            // 
            addPhone.AutoSize = true;
            addPhone.Location = new Point(293, 120);
            addPhone.Name = "addPhone";
            addPhone.Size = new Size(36, 15);
            addPhone.TabIndex = 4;
            addPhone.Text = "טלפון";
            // 
            // addAdress
            // 
            addAdress.AutoSize = true;
            addAdress.Location = new Point(293, 97);
            addAdress.Name = "addAdress";
            addAdress.Size = new Size(42, 15);
            addAdress.TabIndex = 4;
            addAdress.Text = "כתובת";
            // 
            // addId
            // 
            addId.AutoSize = true;
            addId.Location = new Point(293, 68);
            addId.Name = "addId";
            addId.RightToLeft = RightToLeft.Yes;
            addId.Size = new Size(65, 15);
            addId.TabIndex = 4;
            addId.Text = "מספר זהות";
            // 
            // addName
            // 
            addName.AutoSize = true;
            addName.Location = new Point(293, 45);
            addName.Name = "addName";
            addName.Size = new Size(27, 15);
            addName.TabIndex = 4;
            addName.Text = "שם:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(checkBoxClubUpdate);
            panel4.Controls.Add(textBoxUpdatePhone);
            panel4.Controls.Add(textBoxUpdateAddress);
            panel4.Controls.Add(textBoxUpdateId);
            panel4.Controls.Add(textBoxUpdateName);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(65, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 242);
            panel4.TabIndex = 14;
            // 
            // checkBoxClubUpdate
            // 
            checkBoxClubUpdate.AutoSize = true;
            checkBoxClubUpdate.Location = new Point(231, 165);
            checkBoxClubUpdate.Margin = new Padding(3, 2, 3, 2);
            checkBoxClubUpdate.Name = "checkBoxClubUpdate";
            checkBoxClubUpdate.Size = new Size(56, 19);
            checkBoxClubUpdate.TabIndex = 5;
            checkBoxClubUpdate.Text = "מועדון";
            checkBoxClubUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxUpdatePhone
            // 
            textBoxUpdatePhone.Location = new Point(183, 140);
            textBoxUpdatePhone.Name = "textBoxUpdatePhone";
            textBoxUpdatePhone.Size = new Size(100, 23);
            textBoxUpdatePhone.TabIndex = 4;
            // 
            // textBoxUpdateAddress
            // 
            textBoxUpdateAddress.Location = new Point(183, 113);
            textBoxUpdateAddress.Name = "textBoxUpdateAddress";
            textBoxUpdateAddress.Size = new Size(100, 23);
            textBoxUpdateAddress.TabIndex = 4;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(183, 87);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(100, 23);
            textBoxUpdateId.TabIndex = 4;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(183, 60);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(100, 23);
            textBoxUpdateName.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(229, 183);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "לעדכון";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 45);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 143);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "טלפון";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 120);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "כתובת";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 91);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(65, 15);
            label6.TabIndex = 4;
            label6.Text = "מספר זהות";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 68);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 4;
            label7.Text = "שם:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(578, 176);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 15;
            label9.Text = "סנן לפי חברי מועדון";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(592, 195);
            radioButton3.Name = "radioButton3";
            radioButton3.RightToLeft = RightToLeft.Yes;
            radioButton3.Size = new Size(76, 19);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "לקוח רגיל";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(584, 220);
            radioButton4.Name = "radioButton4";
            radioButton4.RightToLeft = RightToLeft.Yes;
            radioButton4.Size = new Size(84, 19);
            radioButton4.TabIndex = 16;
            radioButton4.TabStop = true;
            radioButton4.Text = "לקוח מועדון";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPanel);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(label9);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(DeletePanel);
            Controls.Add(ReadOneCustomer);
            Controls.Add(ReadAllButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            DeletePanel.ResumeLayout(false);
            DeletePanel.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ReadOneCustomer;
        private Button ReadAllButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private Panel DeletePanel;
        private Label label13;
        private TextBox textBoxReadOne;
        private Button sumbitReadOne;
        private Panel panel5;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel4;
        private CheckBox checkBoxClubUpdate;
        private TextBox textBoxUpdatePhone;
        private TextBox textBoxUpdateAddress;
        private TextBox textBoxUpdateId;
        private TextBox textBoxUpdateName;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel AddPanel;
        private CheckBox checkBoxClubAdd;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private Button AddSubmit;
        private Label label2;
        private Label addPhone;
        private Label addAdress;
        private Label addId;
        private Label addName;
        private Label label9;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}