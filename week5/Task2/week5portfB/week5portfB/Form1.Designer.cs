namespace week5portfB
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
            this.AirportInput = new System.Windows.Forms.TextBox();
            this.secondLink = new System.Windows.Forms.TextBox();
            this.firstLink = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LinkButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.AirportLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AirportInput
            // 
            this.AirportInput.Location = new System.Drawing.Point(40, 117);
            this.AirportInput.Name = "AirportInput";
            this.AirportInput.Size = new System.Drawing.Size(100, 20);
            this.AirportInput.TabIndex = 0;
            this.AirportInput.Text = "mo";
            // 
            // secondLink
            // 
            this.secondLink.Location = new System.Drawing.Point(171, 215);
            this.secondLink.Name = "secondLink";
            this.secondLink.Size = new System.Drawing.Size(100, 20);
            this.secondLink.TabIndex = 1;
            // 
            // firstLink
            // 
            this.firstLink.Location = new System.Drawing.Point(40, 215);
            this.firstLink.Name = "firstLink";
            this.firstLink.Size = new System.Drawing.Size(100, 20);
            this.firstLink.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(191, 115);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(113, 289);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LinkButton
            // 
            this.LinkButton.Location = new System.Drawing.Point(113, 251);
            this.LinkButton.Name = "LinkButton";
            this.LinkButton.Size = new System.Drawing.Size(75, 23);
            this.LinkButton.TabIndex = 5;
            this.LinkButton.Text = "Link";
            this.LinkButton.UseVisualStyleBackColor = true;
            this.LinkButton.Click += new System.EventHandler(this.LinkButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(525, 74);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(23, 13);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "null";
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(526, 120);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(23, 13);
            this.outputLabel2.TabIndex = 7;
            this.outputLabel2.Text = "null";
            // 
            // AirportLabel
            // 
            this.AirportLabel.AutoSize = true;
            this.AirportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportLabel.Location = new System.Drawing.Point(107, 57);
            this.AirportLabel.Name = "AirportLabel";
            this.AirportLabel.Size = new System.Drawing.Size(94, 31);
            this.AirportLabel.TabIndex = 8;
            this.AirportLabel.Text = "Airport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Possible Connections";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Conections To Airport";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(191, 144);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start Point";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AirportLabel);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.LinkButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.firstLink);
            this.Controls.Add(this.secondLink);
            this.Controls.Add(this.AirportInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AirportInput;
        private System.Windows.Forms.TextBox secondLink;
        private System.Windows.Forms.TextBox firstLink;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button LinkButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label AirportLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
    }
}

