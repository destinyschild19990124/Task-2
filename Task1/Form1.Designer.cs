namespace Task1
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
            this.minwidthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minlengthBox = new System.Windows.Forms.TextBox();
            this.maxwidthBox = new System.Windows.Forms.TextBox();
            this.maxlengthBox = new System.Windows.Forms.TextBox();
            this.enemiesBox = new System.Windows.Forms.TextBox();
            this.startgameButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minwidthBox
            // 
            this.minwidthBox.Location = new System.Drawing.Point(104, 67);
            this.minwidthBox.Name = "minwidthBox";
            this.minwidthBox.Size = new System.Drawing.Size(140, 22);
            this.minwidthBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enemies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max Length";
            // 
            // minlengthBox
            // 
            this.minlengthBox.Location = new System.Drawing.Point(104, 157);
            this.minlengthBox.Name = "minlengthBox";
            this.minlengthBox.Size = new System.Drawing.Size(140, 22);
            this.minlengthBox.TabIndex = 6;
            // 
            // maxwidthBox
            // 
            this.maxwidthBox.Location = new System.Drawing.Point(350, 67);
            this.maxwidthBox.Name = "maxwidthBox";
            this.maxwidthBox.Size = new System.Drawing.Size(140, 22);
            this.maxwidthBox.TabIndex = 7;
            // 
            // maxlengthBox
            // 
            this.maxlengthBox.Location = new System.Drawing.Point(350, 157);
            this.maxlengthBox.Name = "maxlengthBox";
            this.maxlengthBox.Size = new System.Drawing.Size(140, 22);
            this.maxlengthBox.TabIndex = 8;
            // 
            // enemiesBox
            // 
            this.enemiesBox.Location = new System.Drawing.Point(104, 232);
            this.enemiesBox.Name = "enemiesBox";
            this.enemiesBox.Size = new System.Drawing.Size(140, 22);
            this.enemiesBox.TabIndex = 9;
            // 
            // startgameButton
            // 
            this.startgameButton.Location = new System.Drawing.Point(147, 287);
            this.startgameButton.Name = "startgameButton";
            this.startgameButton.Size = new System.Drawing.Size(197, 71);
            this.startgameButton.TabIndex = 10;
            this.startgameButton.Text = "Start Game";
            this.startgameButton.UseVisualStyleBackColor = true;
            this.startgameButton.Click += new System.EventHandler(this.startgameButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(263, 237);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.startgameButton);
            this.Controls.Add(this.enemiesBox);
            this.Controls.Add(this.maxlengthBox);
            this.Controls.Add(this.maxwidthBox);
            this.Controls.Add(this.minlengthBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minwidthBox);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minwidthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minlengthBox;
        private System.Windows.Forms.TextBox maxwidthBox;
        private System.Windows.Forms.TextBox maxlengthBox;
        private System.Windows.Forms.TextBox enemiesBox;
        private System.Windows.Forms.Button startgameButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

