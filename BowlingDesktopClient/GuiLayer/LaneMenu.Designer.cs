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
            groupBox1 = new GroupBox();
            buttonCreateLane = new Button();
            buttonGetAllLanes = new Button();
            buttonGetLane = new Button();
            textBoxFindBy = new TextBox();
            listBoxLanes = new ListBox();
            groupBoxUpdateLane = new GroupBox();
            buttonUpdateLane = new Button();
            textBoxNewLaneNumber = new TextBox();
            label2 = new Label();
            textBoxFindByID = new TextBox();
            label1 = new Label();
            labelProcessText = new Label();
            groupBox2 = new GroupBox();
            buttonDeleteLane = new Button();
            textBoxLaneToDelete = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBoxUpdateLane.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCreateLane);
            groupBox1.Controls.Add(buttonGetAllLanes);
            groupBox1.Controls.Add(buttonGetLane);
            groupBox1.Controls.Add(textBoxFindBy);
            groupBox1.Controls.Add(listBoxLanes);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(550, 535);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Find Bane";
            // 
            // buttonCreateLane
            // 
            buttonCreateLane.Location = new Point(450, 42);
            buttonCreateLane.Name = "buttonCreateLane";
            buttonCreateLane.Size = new Size(94, 29);
            buttonCreateLane.TabIndex = 4;
            buttonCreateLane.Text = "Opret Bane";
            buttonCreateLane.UseVisualStyleBackColor = true;
            buttonCreateLane.Click += buttonCreateLane_Click_1;
            // 
            // buttonGetAllLanes
            // 
            buttonGetAllLanes.Location = new Point(297, 41);
            buttonGetAllLanes.Name = "buttonGetAllLanes";
            buttonGetAllLanes.Size = new Size(94, 29);
            buttonGetAllLanes.TabIndex = 3;
            buttonGetAllLanes.Text = "Find alle";
            buttonGetAllLanes.UseVisualStyleBackColor = true;
            // 
            // buttonGetLane
            // 
            buttonGetLane.Location = new Point(187, 40);
            buttonGetLane.Margin = new Padding(3, 4, 3, 4);
            buttonGetLane.Name = "buttonGetLane";
            buttonGetLane.Size = new Size(104, 31);
            buttonGetLane.TabIndex = 2;
            buttonGetLane.Text = "Søg";
            buttonGetLane.UseVisualStyleBackColor = true;
            // 
            // textBoxFindBy
            // 
            textBoxFindBy.Location = new Point(7, 41);
            textBoxFindBy.Margin = new Padding(3, 4, 3, 4);
            textBoxFindBy.Name = "textBoxFindBy";
            textBoxFindBy.Size = new Size(173, 27);
            textBoxFindBy.TabIndex = 1;
            // 
            // listBoxLanes
            // 
            listBoxLanes.FormattingEnabled = true;
            listBoxLanes.ItemHeight = 20;
            listBoxLanes.Location = new Point(7, 197);
            listBoxLanes.Margin = new Padding(3, 4, 3, 4);
            listBoxLanes.Name = "listBoxLanes";
            listBoxLanes.Size = new Size(442, 324);
            listBoxLanes.TabIndex = 0;
            // 
            // groupBoxUpdateLane
            // 
            groupBoxUpdateLane.Controls.Add(buttonUpdateLane);
            groupBoxUpdateLane.Controls.Add(textBoxNewLaneNumber);
            groupBoxUpdateLane.Controls.Add(label2);
            groupBoxUpdateLane.Controls.Add(textBoxFindByID);
            groupBoxUpdateLane.Controls.Add(label1);
            groupBoxUpdateLane.Location = new Point(605, 16);
            groupBoxUpdateLane.Margin = new Padding(3, 4, 3, 4);
            groupBoxUpdateLane.Name = "groupBoxUpdateLane";
            groupBoxUpdateLane.Padding = new Padding(3, 4, 3, 4);
            groupBoxUpdateLane.Size = new Size(295, 201);
            groupBoxUpdateLane.TabIndex = 1;
            groupBoxUpdateLane.TabStop = false;
            groupBoxUpdateLane.Text = "Opdater Bane";
            // 
            // buttonUpdateLane
            // 
            buttonUpdateLane.Location = new Point(99, 133);
            buttonUpdateLane.Name = "buttonUpdateLane";
            buttonUpdateLane.Size = new Size(94, 29);
            buttonUpdateLane.TabIndex = 4;
            buttonUpdateLane.Text = "Opdater Lane";
            buttonUpdateLane.UseVisualStyleBackColor = true;
            // 
            // textBoxNewLaneNumber
            // 
            textBoxNewLaneNumber.Location = new Point(80, 100);
            textBoxNewLaneNumber.Name = "textBoxNewLaneNumber";
            textBoxNewLaneNumber.Size = new Size(125, 27);
            textBoxNewLaneNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 77);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 2;
            label2.Text = "Indtast nye Bane Nummer";
            // 
            // textBoxFindByID
            // 
            textBoxFindByID.Location = new Point(80, 47);
            textBoxFindByID.Name = "textBoxFindByID";
            textBoxFindByID.Size = new Size(125, 27);
            textBoxFindByID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 24);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Skriv banes ID";
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(21, 555);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(93, 20);
            labelProcessText.TabIndex = 2;
            labelProcessText.Text = "Good or Not";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDeleteLane);
            groupBox2.Controls.Add(textBoxLaneToDelete);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(605, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 275);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Slet bane";
            // 
            // buttonDeleteLane
            // 
            buttonDeleteLane.Location = new Point(99, 97);
            buttonDeleteLane.Name = "buttonDeleteLane";
            buttonDeleteLane.Size = new Size(94, 29);
            buttonDeleteLane.TabIndex = 2;
            buttonDeleteLane.Text = "Slet bane";
            buttonDeleteLane.UseVisualStyleBackColor = true;
            // 
            // textBoxLaneToDelete
            // 
            textBoxLaneToDelete.Location = new Point(80, 64);
            textBoxLaneToDelete.Name = "textBoxLaneToDelete";
            textBoxLaneToDelete.Size = new Size(125, 27);
            textBoxLaneToDelete.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 41);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "Skriv banes ID";
            // 
            // LaneMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(labelProcessText);
            Controls.Add(groupBoxUpdateLane);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LaneMenu";
            Text = "LaneMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxUpdateLane.ResumeLayout(false);
            groupBoxUpdateLane.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonGetLane;
        private TextBox textBoxFindBy;
        private ListBox listBoxLanes;
        private GroupBox groupBoxUpdateLane;
        private Label labelProcessText;
        private Button buttonGetAllLanes;
        private Button buttonCreateLane;
        private TextBox textBoxFindByID;
        private Label label1;
        private Label label2;
        private TextBox textBoxNewLaneNumber;
        private Button buttonUpdateLane;
        private GroupBox groupBox2;
        private Button buttonDeleteLane;
        private TextBox textBoxLaneToDelete;
        private Label label3;
    }
}