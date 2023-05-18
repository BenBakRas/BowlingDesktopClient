namespace BowlingDesktopClient.GuiLayer
{
    partial class LaneMenu
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
            this.buttonGetLanes = new System.Windows.Forms.Button();
            this.buttonGetLane = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxLanes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelProcessSaved = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetLanes);
            this.groupBox1.Controls.Add(this.buttonGetLane);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listBoxLanes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Bane";
            // 
            // buttonGetLanes
            // 
            this.buttonGetLanes.Location = new System.Drawing.Point(261, 30);
            this.buttonGetLanes.Name = "buttonGetLanes";
            this.buttonGetLanes.Size = new System.Drawing.Size(132, 23);
            this.buttonGetLanes.TabIndex = 3;
            this.buttonGetLanes.Text = "Find alle";
            this.buttonGetLanes.UseVisualStyleBackColor = true;
            // 
            // buttonGetLane
            // 
            this.buttonGetLane.Location = new System.Drawing.Point(164, 30);
            this.buttonGetLane.Name = "buttonGetLane";
            this.buttonGetLane.Size = new System.Drawing.Size(91, 23);
            this.buttonGetLane.TabIndex = 2;
            this.buttonGetLane.Text = "Søg";
            this.buttonGetLane.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 1;
            // 
            // listBoxLanes
            // 
            this.listBoxLanes.FormattingEnabled = true;
            this.listBoxLanes.ItemHeight = 15;
            this.listBoxLanes.Location = new System.Drawing.Point(6, 148);
            this.listBoxLanes.Name = "listBoxLanes";
            this.listBoxLanes.Size = new System.Drawing.Size(387, 244);
            this.listBoxLanes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 401);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // labelProcessSaved
            // 
            this.labelProcessSaved.AutoSize = true;
            this.labelProcessSaved.Location = new System.Drawing.Point(18, 416);
            this.labelProcessSaved.Name = "labelProcessSaved";
            this.labelProcessSaved.Size = new System.Drawing.Size(73, 15);
            this.labelProcessSaved.TabIndex = 2;
            this.labelProcessSaved.Text = "Good or Not";
            // 
            // LaneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProcessSaved);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LaneMenu";
            this.Text = "LaneMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonGetLanes;
        private Button buttonGetLane;
        private TextBox textBox1;
        private ListBox listBoxLanes;
        private GroupBox groupBox2;
        private Label labelProcessSaved;
    }
}