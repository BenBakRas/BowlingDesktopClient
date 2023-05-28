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
            buttonFindCustomerByPhone = new Button();
            listBoxBookings = new ListBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            monthCalendar2 = new MonthCalendar();
            maskedTextBoxSetBookingDate = new MaskedTextBox();
            labelProcessCreateBooking = new Label();
            labelProcessSaved = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxHoursToPlay = new TextBox();
            textBoxPlayers = new TextBox();
            textBoxCustomerPhone = new TextBox();
            buttonCreateBooking = new Button();
            groupBox3 = new GroupBox();
            label5 = new Label();
            buttonDeleteBooking = new Button();
            textBoxDeleteBooking = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelProcessBooking);
            groupBox1.Controls.Add(textBoxFindBy);
            groupBox1.Controls.Add(buttonFindAll);
            groupBox1.Controls.Add(buttonFindCustomerByPhone);
            groupBox1.Controls.Add(listBoxBookings);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(865, 568);
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
            buttonFindAll.Click += buttonFindAll_Click_1;
            // 
            // buttonFindCustomerByPhone
            // 
            buttonFindCustomerByPhone.Location = new Point(227, 44);
            buttonFindCustomerByPhone.Margin = new Padding(3, 4, 3, 4);
            buttonFindCustomerByPhone.Name = "buttonFindCustomerByPhone";
            buttonFindCustomerByPhone.Size = new Size(86, 31);
            buttonFindCustomerByPhone.TabIndex = 1;
            buttonFindCustomerByPhone.Text = "Søg";
            buttonFindCustomerByPhone.UseVisualStyleBackColor = true;
            buttonFindCustomerByPhone.Click += buttonFindCusByPhone;
            // 
            // listBoxBookings
            // 
            listBoxBookings.FormattingEnabled = true;
            listBoxBookings.ItemHeight = 20;
            listBoxBookings.Location = new Point(7, 129);
            listBoxBookings.Margin = new Padding(3, 4, 3, 4);
            listBoxBookings.Name = "listBoxBookings";
            listBoxBookings.Size = new Size(852, 384);
            listBoxBookings.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(monthCalendar2);
            groupBox2.Controls.Add(maskedTextBoxSetBookingDate);
            groupBox2.Controls.Add(labelProcessCreateBooking);
            groupBox2.Controls.Add(labelProcessSaved);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxHoursToPlay);
            groupBox2.Controls.Add(textBoxPlayers);
            groupBox2.Controls.Add(textBoxCustomerPhone);
            groupBox2.Controls.Add(buttonCreateBooking);
            groupBox2.Location = new Point(885, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(429, 407);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opret Booking";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 249);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 13;
            label4.Text = "Indtast dag/måned/år - tid";
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(207, 33);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 12;
            // 
            // maskedTextBoxSetBookingDate
            // 
            maskedTextBoxSetBookingDate.Location = new Point(234, 282);
            maskedTextBoxSetBookingDate.Mask = "00/00/0000 00:00";
            maskedTextBoxSetBookingDate.Name = "maskedTextBoxSetBookingDate";
            maskedTextBoxSetBookingDate.Size = new Size(125, 27);
            maskedTextBoxSetBookingDate.TabIndex = 11;
            maskedTextBoxSetBookingDate.ValidatingType = typeof(DateTime);
            // 
            // labelProcessCreateBooking
            // 
            labelProcessCreateBooking.AutoSize = true;
            labelProcessCreateBooking.Location = new Point(163, 370);
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
            label3.Location = new Point(30, 189);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Kundes Mobil Nr.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 134);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Antal Spillere";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 79);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Spille Timer";
            // 
            // textBoxHoursToPlay
            // 
            textBoxHoursToPlay.Location = new Point(30, 103);
            textBoxHoursToPlay.Margin = new Padding(3, 4, 3, 4);
            textBoxHoursToPlay.Name = "textBoxHoursToPlay";
            textBoxHoursToPlay.Size = new Size(135, 27);
            textBoxHoursToPlay.TabIndex = 3;
            // 
            // textBoxPlayers
            // 
            textBoxPlayers.Location = new Point(30, 158);
            textBoxPlayers.Margin = new Padding(3, 4, 3, 4);
            textBoxPlayers.Name = "textBoxPlayers";
            textBoxPlayers.Size = new Size(135, 27);
            textBoxPlayers.TabIndex = 2;
            // 
            // textBoxCustomerPhone
            // 
            textBoxCustomerPhone.Location = new Point(30, 213);
            textBoxCustomerPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            textBoxCustomerPhone.Size = new Size(135, 27);
            textBoxCustomerPhone.TabIndex = 1;
            // 
            // buttonCreateBooking
            // 
            buttonCreateBooking.Location = new Point(141, 335);
            buttonCreateBooking.Margin = new Padding(3, 4, 3, 4);
            buttonCreateBooking.Name = "buttonCreateBooking";
            buttonCreateBooking.Size = new Size(136, 31);
            buttonCreateBooking.TabIndex = 0;
            buttonCreateBooking.Text = "Opret Booking";
            buttonCreateBooking.UseVisualStyleBackColor = true;
            buttonCreateBooking.Click += buttonCreateBooking_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxDeleteBooking);
            groupBox3.Controls.Add(buttonDeleteBooking);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(885, 430);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(429, 208);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Slet Booking";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 23);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 0;
            label5.Text = "Indtast booking ID";
            // 
            // buttonDeleteBooking
            // 
            buttonDeleteBooking.Location = new Point(145, 79);
            buttonDeleteBooking.Name = "buttonDeleteBooking";
            buttonDeleteBooking.Size = new Size(132, 27);
            buttonDeleteBooking.TabIndex = 1;
            buttonDeleteBooking.Text = "slet booking";
            buttonDeleteBooking.UseVisualStyleBackColor = true;
            buttonDeleteBooking.Click += buttonDeleteBooking_Click;
            // 
            // textBoxDeleteBooking
            // 
            textBoxDeleteBooking.Location = new Point(145, 46);
            textBoxDeleteBooking.Name = "textBoxDeleteBooking";
            textBoxDeleteBooking.Size = new Size(132, 27);
            textBoxDeleteBooking.TabIndex = 2;
            // 
            // BookingMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 650);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookingMenu";
            Text = "BookingMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxFindBy;
        private Button buttonFindAll;
        private Button buttonFindCustomerByPhone;
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
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker bookingDay;
        private NumericUpDown numericUpDown1;
        private MaskedTextBox maskedTextBoxSetBookingDate;
        private MonthCalendar monthCalendar2;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Button buttonDeleteBooking;
        private TextBox textBoxDeleteBooking;
    }
}