namespace UI
{
    partial class FormProduct
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
            numericUpDownCA = new NumericUpDown();
            numericUpDownPA = new NumericUpDown();
            comboBoxCaA = new ComboBox();
            textBoxNAdd = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            AddSubmit = new Button();
            label2 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            textBoxUpdateProductId = new TextBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            comboBox1 = new ComboBox();
            textBoxUpdateName = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label12 = new Label();
            filter = new ComboBox();
            buttonFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ReadOnePanel.SuspendLayout();
            AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPA).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // ReadOneCustomer
            // 
            ReadOneCustomer.Location = new Point(658, 162);
            ReadOneCustomer.Margin = new Padding(3, 2, 3, 2);
            ReadOneCustomer.Name = "ReadOneCustomer";
            ReadOneCustomer.Size = new Size(102, 25);
            ReadOneCustomer.TabIndex = 16;
            ReadOneCustomer.Text = "הצג בודד";
            ReadOneCustomer.UseVisualStyleBackColor = true;
            ReadOneCustomer.Click += ReadOneCustomer_Click;
            // 
            // ReadAllButton
            // 
            ReadAllButton.Location = new Point(658, 130);
            ReadAllButton.Name = "ReadAllButton";
            ReadAllButton.Size = new Size(102, 28);
            ReadAllButton.TabIndex = 12;
            ReadAllButton.Text = "הצג הכל";
            ReadAllButton.UseVisualStyleBackColor = true;
            ReadAllButton.Click += ReadAllButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(658, 101);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 28);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "מחיקה";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(658, 72);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(102, 28);
            UpdateButton.TabIndex = 14;
            UpdateButton.Text = "עדכון";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(658, 43);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(102, 28);
            AddButton.TabIndex = 15;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(532, 299);
            dataGridView1.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.Controls.Add(deleteSubmit);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(124, 368);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 38);
            panel5.TabIndex = 18;
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
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = ":מזהה מוצר";
            // 
            // ReadOnePanel
            // 
            ReadOnePanel.Controls.Add(label13);
            ReadOnePanel.Controls.Add(textBoxReadOne);
            ReadOnePanel.Controls.Add(sumbitReadOne);
            ReadOnePanel.Location = new Point(622, 336);
            ReadOnePanel.Name = "ReadOnePanel";
            ReadOnePanel.Size = new Size(166, 102);
            ReadOnePanel.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(53, 15);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 15;
            label13.Text = "קוד מוצר";
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
            AddPanel.Controls.Add(numericUpDownCA);
            AddPanel.Controls.Add(numericUpDownPA);
            AddPanel.Controls.Add(comboBoxCaA);
            AddPanel.Controls.Add(textBoxNAdd);
            AddPanel.Controls.Add(label8);
            AddPanel.Controls.Add(label9);
            AddPanel.Controls.Add(label10);
            AddPanel.Controls.Add(label11);
            AddPanel.Controls.Add(AddSubmit);
            AddPanel.Controls.Add(label2);
            AddPanel.Location = new Point(124, 44);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(374, 229);
            AddPanel.TabIndex = 20;
            // 
            // numericUpDownCA
            // 
            numericUpDownCA.Location = new Point(90, 119);
            numericUpDownCA.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownCA.Name = "numericUpDownCA";
            numericUpDownCA.Size = new Size(120, 23);
            numericUpDownCA.TabIndex = 13;
            // 
            // numericUpDownPA
            // 
            numericUpDownPA.Location = new Point(89, 93);
            numericUpDownPA.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPA.Name = "numericUpDownPA";
            numericUpDownPA.Size = new Size(120, 23);
            numericUpDownPA.TabIndex = 14;
            // 
            // comboBoxCaA
            // 
            comboBoxCaA.FormattingEnabled = true;
            comboBoxCaA.Items.AddRange(new object[] { "משחקי_הרכבה", "משחקי_קופסא", "משחקי_חשיבה ", "משחקי_קלפים", "משחקי_בובות" });
            comboBoxCaA.Location = new Point(88, 148);
            comboBoxCaA.Name = "comboBoxCaA";
            comboBoxCaA.Size = new Size(121, 23);
            comboBoxCaA.TabIndex = 12;
            // 
            // textBoxNAdd
            // 
            textBoxNAdd.Location = new Point(108, 63);
            textBoxNAdd.Name = "textBoxNAdd";
            textBoxNAdd.Size = new Size(100, 23);
            textBoxNAdd.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 146);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 8;
            label8.Text = "קטגוריה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 123);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 9;
            label9.Text = "כמות";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(214, 94);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(33, 15);
            label10.TabIndex = 10;
            label10.Text = "מחיר";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(214, 71);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 11;
            label11.Text = "שם:";
            // 
            // AddSubmit
            // 
            AddSubmit.Location = new Point(116, 177);
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
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(textBoxUpdateProductId);
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(numericUpDownPrice);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(textBoxUpdateName);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(97, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(424, 267);
            panel4.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(301, 40);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 8;
            label14.Text = ":מזהה מוצר";
            // 
            // textBoxUpdateProductId
            // 
            textBoxUpdateProductId.Location = new Point(162, 37);
            textBoxUpdateProductId.Name = "textBoxUpdateProductId";
            textBoxUpdateProductId.Size = new Size(120, 23);
            textBoxUpdateProductId.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(162, 144);
            numericUpDown2.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(162, 108);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "משחקי הרכבה";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "משחקי_הרכבה", "משחקי_קופסא", "משחקי_חשיבה ", "משחקי_קלפים", "משחקי_בובות" });
            comboBox1.Location = new Point(162, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxUpdateName
            // 
            textBoxUpdateName.Location = new Point(162, 72);
            textBoxUpdateName.Name = "textBoxUpdateName";
            textBoxUpdateName.Size = new Size(120, 23);
            textBoxUpdateName.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(183, 220);
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
            label4.Location = new Point(301, 187);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "קטגוריה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 146);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "כמות";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 110);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(33, 15);
            label6.TabIndex = 4;
            label6.Text = "מחיר";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 72);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 4;
            label7.Text = "שם:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(658, 194);
            label12.Name = "label12";
            label12.Size = new Size(89, 15);
            label12.TabIndex = 21;
            label12.Text = "סנן לפי קטגוריה";
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "משחקי_הרכבה", "משחקי_קופסא", "משחקי_חשיבה ", "משחקי_קלפים", "משחקי_בובות" });
            filter.Location = new Point(643, 212);
            filter.Name = "filter";
            filter.Size = new Size(121, 23);
            filter.TabIndex = 22;
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(672, 241);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(75, 23);
            buttonFilter.TabIndex = 23;
            buttonFilter.Text = "סנן";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFilter);
            Controls.Add(panel4);
            Controls.Add(filter);
            Controls.Add(label12);
            Controls.Add(AddPanel);
            Controls.Add(ReadOnePanel);
            Controls.Add(panel5);
            Controls.Add(dataGridView1);
            Controls.Add(ReadOneCustomer);
            Controls.Add(ReadAllButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Name = "FormProduct";
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ReadOnePanel.ResumeLayout(false);
            ReadOnePanel.PerformLayout();
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPA).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button AddSubmit;
        private Label label2;
        private NumericUpDown numericUpDownCA;
        private NumericUpDown numericUpDownPA;
        private ComboBox comboBoxCaA;
        private TextBox textBoxNAdd;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDownPrice;
        private ComboBox comboBox1;
        private TextBox textBoxUpdateName;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label12;
        private ComboBox filter;
        private Button buttonFilter;
        private TextBox textBoxUpdateProductId;
        private Label label14;
    }
}