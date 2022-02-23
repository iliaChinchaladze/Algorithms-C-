namespace week5portA
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
            this.AddButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.TextBox();
            this.joinBox = new System.Windows.Forms.TextBox();
            this.joinBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nodeLabel = new System.Windows.Forms.Label();
            this.edgeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(109, 155);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(109, 259);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(378, 97);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(81, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Nodes in Graph";
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(94, 129);
            this.addBox.MaxLength = 1;
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(100, 20);
            this.addBox.TabIndex = 3;
            this.addBox.Text = "a";
            // 
            // joinBox
            // 
            this.joinBox.Location = new System.Drawing.Point(32, 233);
            this.joinBox.Name = "joinBox";
            this.joinBox.Size = new System.Drawing.Size(100, 20);
            this.joinBox.TabIndex = 4;
            // 
            // joinBox2
            // 
            this.joinBox2.Location = new System.Drawing.Point(161, 233);
            this.joinBox2.Name = "joinBox2";
            this.joinBox2.Size = new System.Drawing.Size(100, 20);
            this.joinBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edges In Graph";
            // 
            // nodeLabel
            // 
            this.nodeLabel.AutoSize = true;
            this.nodeLabel.Location = new System.Drawing.Point(400, 132);
            this.nodeLabel.Name = "nodeLabel";
            this.nodeLabel.Size = new System.Drawing.Size(23, 13);
            this.nodeLabel.TabIndex = 7;
            this.nodeLabel.Text = "null";
            // 
            // edgeLabel
            // 
            this.edgeLabel.AutoSize = true;
            this.edgeLabel.Location = new System.Drawing.Point(550, 132);
            this.edgeLabel.Name = "edgeLabel";
            this.edgeLabel.Size = new System.Drawing.Size(23, 13);
            this.edgeLabel.TabIndex = 8;
            this.edgeLabel.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edgeLabel);
            this.Controls.Add(this.nodeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joinBox2);
            this.Controls.Add(this.joinBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.TextBox joinBox;
        private System.Windows.Forms.TextBox joinBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nodeLabel;
        private System.Windows.Forms.Label edgeLabel;
    }
}

