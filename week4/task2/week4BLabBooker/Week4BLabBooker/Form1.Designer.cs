namespace Week4BLabBooker
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
            this.StartBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.maxEventButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(84, 81);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(100, 20);
            this.StartBox.TabIndex = 1;
            // 
            // EndBox
            // 
            this.EndBox.Location = new System.Drawing.Point(84, 125);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(100, 20);
            this.EndBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(251, 79);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(76, 21);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(451, 88);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(82, 13);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "Available space";
            // 
            // maxEventButton
            // 
            this.maxEventButton.Location = new System.Drawing.Point(252, 106);
            this.maxEventButton.Name = "maxEventButton";
            this.maxEventButton.Size = new System.Drawing.Size(75, 23);
            this.maxEventButton.TabIndex = 8;
            this.maxEventButton.Text = "Find events";
            this.maxEventButton.UseVisualStyleBackColor = true;
            this.maxEventButton.Click += new System.EventHandler(this.maxEventButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Efficient Scheduling";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(81, 43);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(13, 13);
            this.IDlabel.TabIndex = 10;
            this.IDlabel.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxEventButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndBox);
            this.Controls.Add(this.StartBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button maxEventButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IDlabel;
    }
}

