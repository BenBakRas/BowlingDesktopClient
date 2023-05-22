namespace BowlingDesktopClient.GuiLayer
{
    partial class CustomerMenu
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
            groupBox1 = new GroupBox();
            textBoxFindBy = new TextBox();
            button2 = new Button();
            buttonGetCustomers = new Button();
            listBoxCustomers = new ListBox();
            labelCustomerText = new Label();
            groupBox2 = new GroupBox();
            labelProcessSaved = new Label();
            buttonSaveCustomer = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxFindBy);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(buttonGetCustomers);
            groupBox1.Controls.Add(listBoxCustomers);
            groupBox1.Location = new Point(23, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(582, 537);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Find Kunder";
            // 
            // textBoxFindBy
            // 
            textBoxFindBy.Location = new Point(7, 45);
            textBoxFindBy.Margin = new Padding(3, 4, 3, 4);
            textBoxFindBy.Name = "textBoxFindBy";
            textBoxFindBy.Size = new Size(218, 27);
            textBoxFindBy.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(232, 45);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 2;
            button2.Text = "Søg";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonGetCustomers
            // 
            buttonGetCustomers.Location = new Point(325, 44);
            buttonGetCustomers.Margin = new Padding(3, 4, 3, 4);
            buttonGetCustomers.Name = "buttonGetCustomers";
            buttonGetCustomers.Size = new Size(159, 31);
            buttonGetCustomers.TabIndex = 1;
            buttonGetCustomers.Text = "Find alle";
            buttonGetCustomers.UseVisualStyleBackColor = true;
            buttonGetCustomers.Click += buttonGetCustomers_Click_1;
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.ItemHeight = 20;
            listBoxCustomers.Location = new Point(0, 205);
            listBoxCustomers.Margin = new Padding(3, 4, 3, 4);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(553, 324);
            listBoxCustomers.TabIndex = 0;
            // 
            // labelCustomerText
            // 
            labelCustomerText.AutoSize = true;
            labelCustomerText.Location = new Point(30, 571);
            labelCustomerText.Name = "labelCustomerText";
            labelCustomerText.Size = new Size(93, 20);
            labelCustomerText.TabIndex = 1;
            labelCustomerText.Text = "Good or Not";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelProcessSaved);
            groupBox2.Controls.Add(buttonSaveCustomer);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxLastName);
            groupBox2.Controls.Add(textBoxFirstName);
            groupBox2.Location = new Point(617, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 525);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert Kunde";
            // 
            // labelProcessSaved
            // 
            labelProcessSaved.AutoSize = true;
            labelProcessSaved.Location = new Point(50, 376);
            labelProcessSaved.Name = "labelProcessSaved";
            labelProcessSaved.Size = new Size(15, 20);
            labelProcessSaved.TabIndex = 9;
            labelProcessSaved.Text = "..";
            // 
            // buttonSaveCustomer
            // 
            buttonSaveCustomer.Location = new Point(43, 328);
            buttonSaveCustomer.Name = "buttonSaveCustomer";
            buttonSaveCustomer.Size = new Size(125, 29);
            buttonSaveCustomer.TabIndex = 8;
            buttonSaveCustomer.Text = "Save Customer";
            buttonSaveCustomer.UseVisualStyleBackColor = true;
            buttonSaveCustomer.Click += buttonSaveCustomer_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 253);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Mobil No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 197);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 140);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Efternavn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 83);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "Fornavn";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(43, 277);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(43, 221);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(43, 163);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.ForeColor = SystemColors.WindowText;
            textBoxFirstName.Location = new Point(43, 105);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(labelCustomerText);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerMenu";
            Text = "CustomerMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxFindBy;
        private Button button2;
        private Button buttonGetCustomers;
        private ListBox listBoxCustomers;
        private Label labelCustomerText;
        private GroupBox groupBox2;
        private Button buttonSaveCustomer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelProcessSaved;
    }
}