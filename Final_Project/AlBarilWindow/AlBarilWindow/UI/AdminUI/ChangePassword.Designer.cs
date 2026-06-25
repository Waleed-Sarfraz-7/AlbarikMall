namespace AlBarilWindow.UI.AdminUI
{
    partial class ChangePassword
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.NewPasswordtxt = new System.Windows.Forms.TextBox();
            this.PreviosPasswordtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(353, 294);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(120, 42);
            this.ChangeButton.TabIndex = 9;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // NewPasswordtxt
            // 
            this.NewPasswordtxt.Location = new System.Drawing.Point(409, 181);
            this.NewPasswordtxt.Name = "NewPasswordtxt";
            this.NewPasswordtxt.Size = new System.Drawing.Size(218, 26);
            this.NewPasswordtxt.TabIndex = 8;
            this.NewPasswordtxt.TextChanged += new System.EventHandler(this.NewPasswordtxt_TextChanged);
            // 
            // PreviosPasswordtxt
            // 
            this.PreviosPasswordtxt.Location = new System.Drawing.Point(409, 150);
            this.PreviosPasswordtxt.Name = "PreviosPasswordtxt";
            this.PreviosPasswordtxt.Size = new System.Drawing.Size(218, 26);
            this.PreviosPasswordtxt.TabIndex = 7;
            this.PreviosPasswordtxt.TextChanged += new System.EventHandler(this.PreviosPasswordtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(225, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New PAssword";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Previous Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(853, 486);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NewPasswordtxt);
            this.Controls.Add(this.PreviosPasswordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox NewPasswordtxt;
        private System.Windows.Forms.TextBox PreviosPasswordtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}