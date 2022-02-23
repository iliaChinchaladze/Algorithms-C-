namespace LinkedList_actual_one
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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.outputLable = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.ISBMtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(71, 35);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(114, 20);
            this.wordTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLable
            // 
            this.outputLable.AutoSize = true;
            this.outputLable.Location = new System.Drawing.Point(431, 38);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(43, 13);
            this.outputLable.TabIndex = 2;
            this.outputLable.Text = "INPUT:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(242, 67);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ISBMtextBox
            // 
            this.ISBMtextBox.Location = new System.Drawing.Point(71, 70);
            this.ISBMtextBox.Name = "ISBMtextBox";
            this.ISBMtextBox.Size = new System.Drawing.Size(114, 20);
            this.ISBMtextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ISBMtextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.wordTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label outputLable;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox ISBMtextBox;
    }
}

