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
            button1 = new Button();
            textBoxFindBy = new TextBox();
            button2 = new Button();
            buttonGetCustomers = new Button();
            listBoxCustomers = new ListBox();
            labelCustomerText = new Label();
            groupBox2 = new GroupBox();
            textBoxFindIdByPhone = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            buttonUpdateCustomer = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            textBoxDeleteCustomer = new TextBox();
            buttonDeleteCustomer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxFindBy);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(buttonGetCustomers);
            groupBox1.Controls.Add(listBoxCustomers);
            groupBox1.Location = new Point(23, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(618, 537);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Find Kunder";
            // 
            // button1
            // 
            button1.Location = new Point(465, 47);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 4;
            button1.Text = "Opret Kunde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            buttonGetCustomers.Location = new Point(324, 45);
            buttonGetCustomers.Margin = new Padding(3, 4, 3, 4);
            buttonGetCustomers.Name = "buttonGetCustomers";
            buttonGetCustomers.Size = new Size(102, 31);
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
            listBoxCustomers.Size = new Size(612, 324);
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
            groupBox2.Controls.Add(textBoxFindIdByPhone);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(buttonUpdateCustomer);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxLastName);
            groupBox2.Controls.Add(textBoxFirstName);
            groupBox2.Location = new Point(647, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 424);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opdater Kunde infomation";
            // 
            // textBoxFindIdByPhone
            // 
            textBoxFindIdByPhone.Location = new Point(74, 76);
            textBoxFindIdByPhone.Name = "textBoxFindIdByPhone";
            textBoxFindIdByPhone.Size = new Size(94, 27);
            textBoxFindIdByPhone.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 44);
            label7.Name = "label7";
            label7.Size = new Size(238, 20);
            label7.TabIndex = 11;
            label7.Text = "Indtast telefonnummeret på kunde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 143);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 10;
            label6.Text = "der skal ændres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 123);
            label5.Name = "label5";
            label5.Size = new Size(196, 20);
            label5.TabIndex = 9;
            label5.Text = "Indtast kun de infomationer ";
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.Location = new Point(66, 389);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(125, 29);
            buttonUpdateCustomer.TabIndex = 8;
            buttonUpdateCustomer.Text = "Updater Kunde";
            buttonUpdateCustomer.UseVisualStyleBackColor = true;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 333);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Mobil No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 280);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 227);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Efternavn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 174);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "Fornavn";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(66, 356);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(66, 303);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(66, 250);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.ForeColor = SystemColors.WindowText;
            textBoxFirstName.Location = new Point(66, 197);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonDeleteCustomer);
            groupBox3.Controls.Add(textBoxDeleteCustomer);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(647, 471);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 125);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Slet Customer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 23);
            label8.Name = "label8";
            label8.Size = new Size(247, 20);
            label8.TabIndex = 0;
            label8.Text = "Indtast ID på kunden der skal slettes";
            // 
            // textBoxDeleteCustomer
            // 
            textBoxDeleteCustomer.Location = new Point(70, 46);
            textBoxDeleteCustomer.Name = "textBoxDeleteCustomer";
            textBoxDeleteCustomer.Size = new Size(125, 27);
            textBoxDeleteCustomer.TabIndex = 1;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(88, 79);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(94, 29);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "Slet Kunde";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox3);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Button buttonUpdateCustomer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxFindIdByPhone;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox textBoxDeleteCustomer;
        private Button buttonDeleteCustomer;
    }
}