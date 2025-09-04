namespace _241202071
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            label2 = new Label();
            textBoxLength = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            label6 = new Label();
            textBoxEdge = new TextBox();
            label7 = new Label();
            checkBoxCCW = new CheckBox();
            label8 = new Label();
            textBoxAngle = new TextBox();
            buttonDraw = new Button();
            buttonRotate = new Button();
            buttonReset = new Button();
            listBox1 = new ListBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(27, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 541);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(644, 51);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Center (x,y)";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(722, 48);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(834, 48);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 93);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Length";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(768, 93);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(717, 147);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Red";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 197);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Green";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(717, 259);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Blue";
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(784, 147);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(104, 45);
            trackBarRed.TabIndex = 5;
            trackBarRed.TickFrequency = 10;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(784, 197);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(104, 45);
            trackBarGreen.TabIndex = 5;
            trackBarGreen.TickFrequency = 10;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(784, 248);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(104, 45);
            trackBarBlue.TabIndex = 5;
            trackBarBlue.TickFrequency = 10;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(678, 316);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "Edge";
            // 
            // textBoxEdge
            // 
            textBoxEdge.Location = new Point(735, 308);
            textBoxEdge.Name = "textBoxEdge";
            textBoxEdge.Size = new Size(100, 23);
            textBoxEdge.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(850, 333);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 14;
            label7.Text = "CCW";
            // 
            // checkBoxCCW
            // 
            checkBoxCCW.AutoSize = true;
            checkBoxCCW.Location = new Point(898, 333);
            checkBoxCCW.Name = "checkBoxCCW";
            checkBoxCCW.Size = new Size(15, 14);
            checkBoxCCW.TabIndex = 15;
            checkBoxCCW.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(703, 370);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 16;
            label8.Text = "Angle ";
            // 
            // textBoxAngle
            // 
            textBoxAngle.Location = new Point(768, 370);
            textBoxAngle.Name = "textBoxAngle";
            textBoxAngle.Size = new Size(100, 23);
            textBoxAngle.TabIndex = 17;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(722, 554);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(166, 50);
            buttonDraw.TabIndex = 18;
            buttonDraw.Text = "DRAW";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // buttonRotate
            // 
            buttonRotate.Location = new Point(722, 624);
            buttonRotate.Name = "buttonRotate";
            buttonRotate.Size = new Size(166, 46);
            buttonRotate.TabIndex = 19;
            buttonRotate.Text = "ROTATE";
            buttonRotate.UseVisualStyleBackColor = true;
            buttonRotate.Click += buttonRotate_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(722, 685);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(166, 43);
            buttonReset.TabIndex = 20;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(717, 454);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 94);
            listBox1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(788, 427);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 22;
            label9.Text = "Edge Coordinates";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(717, 406);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 51);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 820);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(buttonReset);
            Controls.Add(buttonRotate);
            Controls.Add(buttonDraw);
            Controls.Add(textBoxAngle);
            Controls.Add(label8);
            Controls.Add(checkBoxCCW);
            Controls.Add(label7);
            Controls.Add(textBoxEdge);
            Controls.Add(label6);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxLength);
            Controls.Add(label2);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Label label2;
        private TextBox textBoxLength;
        private Label label3;
        private Label label4;
        private Label label5;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Label label6;
        private TextBox textBoxEdge;
        private Label label7;
        private CheckBox checkBoxCCW;
        private Label label8;
        private TextBox textBoxAngle;
        private Button buttonDraw;
        private Button buttonRotate;
        private Button buttonReset;
        private ListBox listBox1;
        private Label label9;
        private PictureBox pictureBox2;
    }
}
