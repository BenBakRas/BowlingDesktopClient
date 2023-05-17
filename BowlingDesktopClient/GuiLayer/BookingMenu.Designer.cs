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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFindAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.labelProcessBooking = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelProcessBooking);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonFindAll);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBoxBookings);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 3;
            // 
            // buttonFindAll
            // 
            this.buttonFindAll.Location = new System.Drawing.Point(280, 33);
            this.buttonFindAll.Name = "buttonFindAll";
            this.buttonFindAll.Size = new System.Drawing.Size(138, 23);
            this.buttonFindAll.TabIndex = 2;
            this.buttonFindAll.Text = "Find alle";
            this.buttonFindAll.UseVisualStyleBackColor = true;
            this.buttonFindAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Søg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.ItemHeight = 15;
            this.listBoxBookings.Location = new System.Drawing.Point(6, 172);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(764, 214);
            this.listBoxBookings.TabIndex = 0;
            // 
            // labelProcessBookng
            // 
            this.labelProcessBooking.AutoSize = true;
            this.labelProcessBooking.Location = new System.Drawing.Point(6, 398);
            this.labelProcessBooking.Name = "labelProcessBookng";
            this.labelProcessBooking.Size = new System.Drawing.Size(38, 15);
            this.labelProcessBooking.TabIndex = 4;
            this.labelProcessBooking.Text = "label1";
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookingMenu";
            this.Text = "BookingMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button buttonFindAll;
        private Button button1;
        private ListBox listBoxBookings;
        private Label labelProcessBooking;
    }
}