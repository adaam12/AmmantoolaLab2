using System;

namespace AmmantoolaLab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset_Click = new System.Windows.Forms.Button();
            this.btnCalculate_Click = new System.Windows.Forms.Button();
            this.lblShowAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnExit_Click = new System.Windows.Forms.Button();
            this.btnData_Click = new System.Windows.Forms.Button();
            this.btnHide_Click = new System.Windows.Forms.Button();
            this.btnPicture_Click = new System.Windows.Forms.Button();
            this.picImage_Click = new System.Windows.Forms.PictureBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage_Click)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset_Click);
            this.groupBox1.Controls.Add(this.btnCalculate_Click);
            this.groupBox1.Controls.Add(this.lblShowAnswer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMultiplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplier";
            // 
            // btnReset_Click
            // 
            this.btnReset_Click.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset_Click.Location = new System.Drawing.Point(118, 308);
            this.btnReset_Click.Name = "btnReset_Click";
            this.btnReset_Click.Size = new System.Drawing.Size(90, 37);
            this.btnReset_Click.TabIndex = 4;
            this.btnReset_Click.Text = "&Reset";
            this.btnReset_Click.UseVisualStyleBackColor = true;
            this.btnReset_Click.Click += new System.EventHandler(this.btnReset_Click_Click);
            // 
            // btnCalculate_Click
            // 
            this.btnCalculate_Click.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate_Click.Location = new System.Drawing.Point(13, 308);
            this.btnCalculate_Click.Name = "btnCalculate_Click";
            this.btnCalculate_Click.Size = new System.Drawing.Size(90, 37);
            this.btnCalculate_Click.TabIndex = 3;
            this.btnCalculate_Click.Text = "&Calculate";
            this.btnCalculate_Click.UseVisualStyleBackColor = true;
            this.btnCalculate_Click.Click += new System.EventHandler(this.btnCalculate_Click_Click);
            // 
            // lblShowAnswer
            // 
            this.lblShowAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.lblShowAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowAnswer.Location = new System.Drawing.Point(87, 267);
            this.lblShowAnswer.Name = "lblShowAnswer";
            this.lblShowAnswer.Size = new System.Drawing.Size(99, 22);
            this.lblShowAnswer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer :";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(86, 170);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplier.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Multiplier :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(86, 71);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTopic);
            this.groupBox2.Controls.Add(this.btnExit_Click);
            this.groupBox2.Controls.Add(this.btnData_Click);
            this.groupBox2.Controls.Add(this.btnHide_Click);
            this.groupBox2.Controls.Add(this.btnPicture_Click);
            this.groupBox2.Controls.Add(this.picImage_Click);
            this.groupBox2.Controls.Add(this.lbltext);
            this.groupBox2.Location = new System.Drawing.Point(251, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // lblTopic
            // 
            this.lblTopic.Location = new System.Drawing.Point(209, 18);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(131, 23);
            this.lblTopic.TabIndex = 2;
            this.lblTopic.Text = "Maurituis Beaches\r\n";
            // 
            // btnExit_Click
            // 
            this.btnExit_Click.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit_Click.Location = new System.Drawing.Point(425, 294);
            this.btnExit_Click.Name = "btnExit_Click";
            this.btnExit_Click.Size = new System.Drawing.Size(103, 37);
            this.btnExit_Click.TabIndex = 3;
            this.btnExit_Click.Text = "E&xit";
            this.btnExit_Click.UseVisualStyleBackColor = true;
            this.btnExit_Click.Click += new System.EventHandler(this.btnExit_Click_Click);
            // 
            // btnData_Click
            // 
            this.btnData_Click.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnData_Click.Location = new System.Drawing.Point(157, 294);
            this.btnData_Click.Name = "btnData_Click";
            this.btnData_Click.Size = new System.Drawing.Size(103, 37);
            this.btnData_Click.TabIndex = 1;
            this.btnData_Click.Text = "&Data";
            this.btnData_Click.UseVisualStyleBackColor = true;
            this.btnData_Click.Click += new System.EventHandler(this.btnData_Click_Click);
            // 
            // btnHide_Click
            // 
            this.btnHide_Click.Location = new System.Drawing.Point(291, 294);
            this.btnHide_Click.Name = "btnHide_Click";
            this.btnHide_Click.Size = new System.Drawing.Size(103, 37);
            this.btnHide_Click.TabIndex = 2;
            this.btnHide_Click.Text = "&Hide";
            this.btnHide_Click.UseVisualStyleBackColor = true;
            this.btnHide_Click.Click += new System.EventHandler(this.btnHide_Click_Click);
            // 
            // btnPicture_Click
            // 
            this.btnPicture_Click.Location = new System.Drawing.Point(23, 294);
            this.btnPicture_Click.Name = "btnPicture_Click";
            this.btnPicture_Click.Size = new System.Drawing.Size(103, 37);
            this.btnPicture_Click.TabIndex = 0;
            this.btnPicture_Click.Text = "&Picture";
            this.btnPicture_Click.UseVisualStyleBackColor = true;
            this.btnPicture_Click.Click += new System.EventHandler(this.btnPicture_Click_Click);
            // 
            // picImage_Click
            // 
            this.picImage_Click.Image = ((System.Drawing.Image)(resources.GetObject("picImage_Click.Image")));
            this.picImage_Click.Location = new System.Drawing.Point(23, 44);
            this.picImage_Click.Name = "picImage_Click";
            this.picImage_Click.Size = new System.Drawing.Size(505, 224);
            this.picImage_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage_Click.TabIndex = 0;
            this.picImage_Click.TabStop = false;
            this.picImage_Click.Visible = false;
            this.picImage_Click.Click += new System.EventHandler(this.picImage_Click_Click);
            // 
            // lbltext
            // 
            this.lbltext.Location = new System.Drawing.Point(23, 41);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(505, 227);
            this.lbltext.TabIndex = 4;
            this.lbltext.Visible = false;
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.IndianRed;
            this.btnMessage.Location = new System.Drawing.Point(463, 372);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(154, 33);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "message";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture_Click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnReset_Click;
            this.ClientSize = new System.Drawing.Size(839, 407);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 by Yassine Adaam Ammantoola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage_Click)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPicture_Click;
        private System.Windows.Forms.PictureBox picImage_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnExit_Click;
        private System.Windows.Forms.Button btnData_Click;
        private System.Windows.Forms.Button btnHide_Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnReset_Click;
        private System.Windows.Forms.Button btnCalculate_Click;
        private System.Windows.Forms.Label lblShowAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button btnMessage;
    }
}

