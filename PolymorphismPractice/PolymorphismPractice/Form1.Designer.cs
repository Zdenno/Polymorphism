namespace PolymorphismPractice
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
            this.Hidebutton2 = new System.Windows.Forms.Button();
            this.GoHerebtn = new System.Windows.Forms.Button();
            this.GoThroughThatDoor = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.ExitscomboBox1 = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hidebutton2
            // 
            this.Hidebutton2.Location = new System.Drawing.Point(361, 415);
            this.Hidebutton2.Name = "Hidebutton2";
            this.Hidebutton2.Size = new System.Drawing.Size(75, 23);
            this.Hidebutton2.TabIndex = 0;
            this.Hidebutton2.Text = "Hide";
            this.Hidebutton2.UseVisualStyleBackColor = true;
            this.Hidebutton2.Click += new System.EventHandler(this.Hidebutton2_Click);
            // 
            // GoHerebtn
            // 
            this.GoHerebtn.Location = new System.Drawing.Point(65, 275);
            this.GoHerebtn.Name = "GoHerebtn";
            this.GoHerebtn.Size = new System.Drawing.Size(75, 23);
            this.GoHerebtn.TabIndex = 1;
            this.GoHerebtn.Text = "Go here";
            this.GoHerebtn.UseVisualStyleBackColor = true;
            this.GoHerebtn.Click += new System.EventHandler(this.GoHerebtn_Click);
            // 
            // GoThroughThatDoor
            // 
            this.GoThroughThatDoor.Location = new System.Drawing.Point(171, 321);
            this.GoThroughThatDoor.Name = "GoThroughThatDoor";
            this.GoThroughThatDoor.Size = new System.Drawing.Size(479, 23);
            this.GoThroughThatDoor.TabIndex = 2;
            this.GoThroughThatDoor.Text = "Go through that door";
            this.GoThroughThatDoor.UseVisualStyleBackColor = true;
            this.GoThroughThatDoor.Click += new System.EventHandler(this.GoThroughThatDoor_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(245, 368);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(320, 23);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ExitscomboBox1
            // 
            this.ExitscomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExitscomboBox1.FormattingEnabled = true;
            this.ExitscomboBox1.Location = new System.Drawing.Point(525, 275);
            this.ExitscomboBox1.Name = "ExitscomboBox1";
            this.ExitscomboBox1.Size = new System.Drawing.Size(183, 21);
            this.ExitscomboBox1.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(65, 26);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(643, 187);
            this.description.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description);
            this.Controls.Add(this.ExitscomboBox1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.GoThroughThatDoor);
            this.Controls.Add(this.GoHerebtn);
            this.Controls.Add(this.Hidebutton2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hidebutton2;
        private System.Windows.Forms.Button GoHerebtn;
        private System.Windows.Forms.Button GoThroughThatDoor;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.ComboBox ExitscomboBox1;
        private System.Windows.Forms.TextBox description;
    }
}