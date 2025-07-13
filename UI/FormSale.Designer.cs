namespace UI
{
    partial class FormSale
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
            ReadOneCustomer = new Button();
            ReadAllButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            deleteSubmit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ReadOnePanel = new Panel();
            label13 = new Label();
            textBoxReadOne = new TextBox();
            sumbitReadOne = new Button();
            AddPanel = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            textBoxUpdateId = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            checkBox2 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            textBox2 = new TextBox();
            button1 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ReadOnePanel.SuspendLayout();
            AddPanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // ReadOneCustomer
            // 
            ReadOneCustomer.Location = new Point(648, 166);
            ReadOneCustomer.Margin = new Padding(3, 2, 3, 2);
            ReadOneCustomer.Name = "ReadOneCustomer";
            ReadOneCustomer.Size = new Size(102, 25);
            ReadOneCustomer.TabIndex = 21;
            ReadOneCustomer.Text = "הצג בודד";
            ReadOneCustomer.UseVisualStyleBackColor = true;
            ReadOneCustomer.Click += ReadOneCustomer_Click;
            // 
            // ReadAllButton
            // 
            ReadAllButton.Location = new Point(648, 136);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(102, 28);
            ReadAllButton.TabIndex = 17;
            ReadAllButton.Text = "הצג הכל";
            ReadAllButton.UseVisualStyleBackColor = true;
            ReadAllButton.Click += ReadAllButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(648, 107);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 28);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "מחיקה";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(648, 78);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(102, 28);
            UpdateButton.TabIndex = 19;
            UpdateButton.Text = "עדכון";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(648, 49);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(102, 28);
            AddButton.TabIndex = 20;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(551, 275);
            dataGridView1.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Controls.Add(deleteSubmit);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(149, 305);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 38);
            panel5.TabIndex = 28;
            // 
            // deleteSubmit
            // 
            deleteSubmit.Location = new Point(76, 10);
            deleteSubmit.Margin = new Padding(3, 2, 3, 2);
            deleteSubmit.Name = "deleteSubmit";
            deleteSubmit.Size = new Size(82, 22);
            deleteSubmit.TabIndex = 2;
            deleteSubmit.Text = "אישור";
            deleteSubmit.UseVisualStyleBackColor = true;
            deleteSubmit.Click += deleteSubmit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "קוד מבצע";
            // 
            // ReadOnePanel
            // 
            ReadOnePanel.Controls.Add(label13);
            ReadOnePanel.Controls.Add(textBoxReadOne);
            ReadOnePanel.Controls.Add(sumbitReadOne);
            ReadOnePanel.Location = new Point(608, 196);
            ReadOnePanel.Name = "ReadOnePanel";
            ReadOnePanel.Size = new Size(166, 102);
            ReadOnePanel.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(53, 15);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 15;
            label13.Text = "קוד מבצע";
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
            // AddPanel
            // 
            AddPanel.BackColor = SystemColors.Control;
            AddPanel.Controls.Add(label8);
            AddPanel.Controls.Add(label9);
            AddPanel.Controls.Add(dateTimePicker3);
            AddPanel.Controls.Add(dateTimePicker4);
            AddPanel.Controls.Add(checkBox2);
            AddPanel.Controls.Add(numericUpDown1);
            AddPanel.Controls.Add(numericUpDown3);
            AddPanel.Controls.Add(textBox2);
            AddPanel.Controls.Add(button1);
            AddPanel.Controls.Add(label10);
            AddPanel.Controls.Add(label11);
            AddPanel.Controls.Add(label12);
            AddPanel.Controls.Add(label14);
            AddPanel.Location = new Point(70, 21);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(465, 242);
            AddPanel.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(numericUpDownPrice);
            panel4.Controls.Add(textBoxUpdateId);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(124, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 242);
            panel4.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 170);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 30;
            label4.Text = "תאריך התחלה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 192);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 30;
            label2.Text = "תאריך סיום";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(76, 192);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(76, 166);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(193, 142);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 29;
            checkBox1.Text = "לכל הלקוחות";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(165, 116);
            numericUpDown2.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(165, 90);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(118, 23);
            numericUpDownPrice.TabIndex = 6;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(165, 62);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(120, 23);
            textBoxUpdateId.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(193, 216);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 120);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "כמות במבצע";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 91);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(65, 15);
            label6.TabIndex = 4;
            label6.Text = "מחיר מבצע";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 68);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 4;
            label7.Text = "מזהה מוצר";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(314, 170);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 30;
            label8.Text = "תאריך התחלה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(314, 192);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 30;
            label9.Text = "תאריך סיום";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(76, 192);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(219, 23);
            dateTimePicker3.TabIndex = 29;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(76, 166);
            dateTimePicker4.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(219, 23);
            dateTimePicker4.TabIndex = 29;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(193, 142);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 19);
            checkBox2.TabIndex = 29;
            checkBox2.Text = "לכל הלקוחות";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(165, 116);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(165, 90);
            numericUpDown3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(118, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(193, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "להוספה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(155, 45);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(289, 120);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 4;
            label11.Text = "כמות במבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(289, 91);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(65, 15);
            label12.TabIndex = 4;
            label12.Text = "מחיר מבצע";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(289, 68);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 4;
            label14.Text = "מזהה מוצר";
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(AddPanel);
            Controls.Add(ReadOnePanel);
            Controls.Add(panel5);
            Controls.Add(dataGridView1);
            Controls.Add(ReadOneCustomer);
            Controls.Add(ReadAllButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Name = "FormSale";
            Text = "FormSale";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ReadOnePanel.ResumeLayout(false);
            ReadOnePanel.PerformLayout();
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ReadOneCustomer;
        private Button ReadAllButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Button deleteSubmit;
        private TextBox textBox1;
        private Label label1;
        private Panel ReadOnePanel;
        private Label label13;
        private TextBox textBoxReadOne;
        private Button sumbitReadOne;
        private Panel AddPanel;
        private Panel panel4;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxUpdateId;
        private Button button2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private CheckBox checkBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown3;
        private TextBox textBox2;
        private Button button1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
    }
}