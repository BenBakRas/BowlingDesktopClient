namespace BowlingDesktopClient.GuiLayer
{
    partial class BookingMenu
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
            labelProcessBooking = new Label();
            textBoxFindBy = new TextBox();
            buttonFindAll = new Button();
            button1 = new Button();
            listBoxBookings = new ListBox();
            groupBox2 = new GroupBox();
            labelProcessCreateBooking = new Label();
            labelProcessSaved = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxHoursToPlay = new TextBox();
            textBoxPlayers = new TextBox();
            textBoxCustomerPhone = new TextBox();
            buttonCreateBooking = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelProcessBooking);
            groupBox1.Controls.Add(textBoxFindBy);
            groupBox1.Controls.Add(buttonFindAll);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBoxBookings);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(643, 568);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Find Bookinger";
            // 
            // labelProcessBooking
            // 
            labelProcessBooking.AutoSize = true;
            labelProcessBooking.Location = new Point(7, 531);
            labelProcessBooking.Name = "labelProcessBooking";
            labelProcessBooking.Size = new Size(93, 20);
            labelProcessBooking.TabIndex = 4;
            labelProcessBooking.Text = "Good or Not";
            // 
            // textBoxFindBy
            // 
            textBoxFindBy.Location = new Point(7, 44);
            textBoxFindBy.Margin = new Padding(3, 4, 3, 4);
            textBoxFindBy.Name = "textBoxFindBy";
            textBoxFindBy.Size = new Size(213, 27);
            textBoxFindBy.TabIndex = 3;
            // 
            // buttonFindAll
            // 
            buttonFindAll.Location = new Point(320, 44);
            buttonFindAll.Margin = new Padding(3, 4, 3, 4);
            buttonFindAll.Name = "buttonFindAll";
            buttonFindAll.Size = new Size(158, 31);
            buttonFindAll.TabIndex = 2;
            buttonFindAll.Text = "Find alle";
            buttonFindAll.UseVisualStyleBackColor = true;
            buttonFindAll.Click += buttonFindAll_Click;
            // 
            // button1
            // 
            button1.Location = new Point(227, 44);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "Søg";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxBookings
            // 
            listBoxBookings.FormattingEnabled = true;
            listBoxBookings.ItemHeight = 20;
            listBoxBookings.Location = new Point(7, 129);
            listBoxBookings.Margin = new Padding(3, 4, 3, 4);
            listBoxBookings.Name = "listBoxBookings";
            listBoxBookings.Size = new Size(608, 384);
            listBoxBookings.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelProcessCreateBooking);
            groupBox2.Controls.Add(labelProcessSaved);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxHoursToPlay);
            groupBox2.Controls.Add(textBoxPlayers);
            groupBox2.Controls.Add(textBoxCustomerPhone);
            groupBox2.Controls.Add(buttonCreateBooking);
            groupBox2.Location = new Point(694, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(208, 568);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert Booking";
            // 
            // labelProcessCreateBooking
            // 
            labelProcessCreateBooking.AutoSize = true;
            labelProcessCreateBooking.Location = new Point(52, 382);
            labelProcessCreateBooking.Name = "labelProcessCreateBooking";
            labelProcessCreateBooking.Size = new Size(93, 20);
            labelProcessCreateBooking.TabIndex = 8;
            labelProcessCreateBooking.Text = "Good or Not";
            // 
            // labelProcessSaved
            // 
            labelProcessSaved.AutoSize = true;
            labelProcessSaved.Location = new Point(115, 405);
            labelProcessSaved.Name = "labelProcessSaved";
            labelProcessSaved.Size = new Size(0, 20);
            labelProcessSaved.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 243);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Kundes Mobil Nr.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 188);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Antal Spillere";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 133);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Spille Timer";
            // 
            // textBoxHoursToPlay
            // 
            textBoxHoursToPlay.Location = new Point(31, 157);
            textBoxHoursToPlay.Margin = new Padding(3, 4, 3, 4);
            textBoxHoursToPlay.Name = "textBoxHoursToPlay";
            textBoxHoursToPlay.Size = new Size(135, 27);
            textBoxHoursToPlay.TabIndex = 3;
            // 
            // textBoxPlayers
            // 
            textBoxPlayers.Location = new Point(31, 212);
            textBoxPlayers.Margin = new Padding(3, 4, 3, 4);
            textBoxPlayers.Name = "textBoxPlayers";
            textBoxPlayers.Size = new Size(135, 27);
            textBoxPlayers.TabIndex = 2;
            // 
            // textBoxCustomerPhone
            // 
            textBoxCustomerPhone.Location = new Point(31, 267);
            textBoxCustomerPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            textBoxCustomerPhone.Size = new Size(135, 27);
            textBoxCustomerPhone.TabIndex = 1;
            // 
            // buttonCreateBooking
            // 
            buttonCreateBooking.Location = new Point(30, 302);
            buttonCreateBooking.Margin = new Padding(3, 4, 3, 4);
            buttonCreateBooking.Name = "buttonCreateBooking";
            buttonCreateBooking.Size = new Size(136, 31);
            buttonCreateBooking.TabIndex = 0;
            buttonCreateBooking.Text = "Opret Booking";
            buttonCreateBooking.UseVisualStyleBackColor = true;
            buttonCreateBooking.Click += buttonCreateBooking_Click_1;
            // 
            // BookingMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookingMenu";
            Text = "BookingMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxFindBy;
        private Button buttonFindAll;
        private Button button1;
        private ListBox listBoxBookings;
        private Label labelProcessBooking;
        private GroupBox groupBox2;
        private Button buttonCreateBooking;
        private TextBox textBoxHoursToPlay;
        private TextBox textBoxPlayers;
        private TextBox textBoxCustomerPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelProcessSaved;
        private Label labelProcessCreateBooking;
    }
}