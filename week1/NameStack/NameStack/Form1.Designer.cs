namespace NameStack
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.Label();
            this.allNames = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(201, 61);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(201, 113);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(22, 61);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 20);
            this.nameBox.TabIndex = 2;
            // 
            // countBox
            // 
            this.countBox.AutoSize = true;
            this.countBox.Location = new System.Drawing.Point(77, 113);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(50, 13);
            this.countBox.TabIndex = 3;
            this.countBox.Text = "Count - 0";
            // 
            // allNames
            // 
            this.allNames.AutoSize = true;
            this.allNames.Location = new System.Drawing.Point(379, 66);
            this.allNames.Name = "allNames";
            this.allNames.Size = new System.Drawing.Size(0, 13);
            this.allNames.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Names";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allNames);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label countBox;
        private System.Windows.Forms.Label allNames;
        private System.Windows.Forms.Label label1;
    }
}

