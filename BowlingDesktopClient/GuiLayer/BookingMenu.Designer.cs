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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProcessBooking = new System.Windows.Forms.Label();
            this.textBoxFindBy = new System.Windows.Forms.TextBox();
            this.buttonFindAll = new System.Windows.Forms.Button();
            this.buttonFindCustomerByPhone = new System.Windows.Forms.Button();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelProcessCreateBooking = new System.Windows.Forms.Label();
            this.labelProcessSaved = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHoursToPlay = new System.Windows.Forms.TextBox();
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.buttonCreateBooking = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelProcessBooking);
            this.groupBox1.Controls.Add(this.textBoxFindBy);
            this.groupBox1.Controls.Add(this.buttonFindAll);
            this.groupBox1.Controls.Add(this.buttonFindCustomerByPhone);
            this.groupBox1.Controls.Add(this.listBoxBookings);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1037, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Bookinger";
            // 
            // labelProcessBooking
            // 
            this.labelProcessBooking.AutoSize = true;
            this.labelProcessBooking.Location = new System.Drawing.Point(7, 531);
            this.labelProcessBooking.Name = "labelProcessBooking";
            this.labelProcessBooking.Size = new System.Drawing.Size(93, 20);
            this.labelProcessBooking.TabIndex = 4;
            this.labelProcessBooking.Text = "Good or Not";
            // 
            // textBoxFindBy
            // 
            this.textBoxFindBy.Location = new System.Drawing.Point(7, 44);
            this.textBoxFindBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFindBy.Name = "textBoxFindBy";
            this.textBoxFindBy.Size = new System.Drawing.Size(213, 27);
            this.textBoxFindBy.TabIndex = 3;
            // 
            // buttonFindAll
            // 
            this.buttonFindAll.Location = new System.Drawing.Point(320, 44);
            this.buttonFindAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindAll.Name = "buttonFindAll";
            this.buttonFindAll.Size = new System.Drawing.Size(158, 31);
            this.buttonFindAll.TabIndex = 2;
            this.buttonFindAll.Text = "Find alle";
            this.buttonFindAll.UseVisualStyleBackColor = true;
            this.buttonFindAll.Click += new System.EventHandler(this.buttonFindAll_Click_1);
            // 
            // buttonFindCustomerByPhone
            // 
            this.buttonFindCustomerByPhone.Location = new System.Drawing.Point(227, 44);
            this.buttonFindCustomerByPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindCustomerByPhone.Name = "buttonFindCustomerByPhone";
            this.buttonFindCustomerByPhone.Size = new System.Drawing.Size(86, 31);
            this.buttonFindCustomerByPhone.TabIndex = 1;
            this.buttonFindCustomerByPhone.Text = "Søg";
            this.buttonFindCustomerByPhone.UseVisualStyleBackColor = true;
            this.buttonFindCustomerByPhone.Click += new System.EventHandler(this.buttonFindCusByPhone);
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.ItemHeight = 20;
            this.listBoxBookings.Location = new System.Drawing.Point(7, 129);
            this.listBoxBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(1001, 384);
            this.listBoxBookings.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelProcessCreateBooking);
            this.groupBox2.Controls.Add(this.labelProcessSaved);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxHoursToPlay);
            this.groupBox2.Controls.Add(this.textBoxPlayers);
            this.groupBox2.Controls.Add(this.textBoxCustomerPhone);
            this.groupBox2.Controls.Add(this.buttonCreateBooking);
            this.groupBox2.Location = new System.Drawing.Point(1106, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(208, 568);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Booking";
            // 
            // labelProcessCreateBooking
            // 
            this.labelProcessCreateBooking.AutoSize = true;
            this.labelProcessCreateBooking.Location = new System.Drawing.Point(52, 382);
            this.labelProcessCreateBooking.Name = "labelProcessCreateBooking";
            this.labelProcessCreateBooking.Size = new System.Drawing.Size(93, 20);
            this.labelProcessCreateBooking.TabIndex = 8;
            this.labelProcessCreateBooking.Text = "Good or Not";
            // 
            // labelProcessSaved
            // 
            this.labelProcessSaved.AutoSize = true;
            this.labelProcessSaved.Location = new System.Drawing.Point(115, 405);
            this.labelProcessSaved.Name = "labelProcessSaved";
            this.labelProcessSaved.Size = new System.Drawing.Size(0, 20);
            this.labelProcessSaved.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kundes Mobil Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antal Spillere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spille Timer";
            // 
            // textBoxHoursToPlay
            // 
            this.textBoxHoursToPlay.Location = new System.Drawing.Point(31, 157);
            this.textBoxHoursToPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHoursToPlay.Name = "textBoxHoursToPlay";
            this.textBoxHoursToPlay.Size = new System.Drawing.Size(135, 27);
            this.textBoxHoursToPlay.TabIndex = 3;
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.Location = new System.Drawing.Point(31, 212);
            this.textBoxPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.Size = new System.Drawing.Size(135, 27);
            this.textBoxPlayers.TabIndex = 2;
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(31, 267);
            this.textBoxCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(135, 27);
            this.textBoxCustomerPhone.TabIndex = 1;
            // 
            // buttonCreateBooking
            // 
            this.buttonCreateBooking.Location = new System.Drawing.Point(30, 302);
            this.buttonCreateBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateBooking.Name = "buttonCreateBooking";
            this.buttonCreateBooking.Size = new System.Drawing.Size(136, 31);
            this.buttonCreateBooking.TabIndex = 0;
            this.buttonCreateBooking.Text = "Opret Booking";
            this.buttonCreateBooking.UseVisualStyleBackColor = true;
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingMenu";
            this.Text = "BookingMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}