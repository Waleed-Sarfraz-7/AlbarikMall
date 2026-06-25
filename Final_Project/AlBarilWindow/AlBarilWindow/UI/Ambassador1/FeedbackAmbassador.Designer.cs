namespace AlBarilWindow.UI.Ambassador1
{
    partial class FeedbackAmbassador
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
            this.button1 = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.List1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // List1
            // 
            this.List1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List1.Location = new System.Drawing.Point(222, 84);
            this.List1.Name = "List1";
            this.List1.RowHeadersWidth = 62;
            this.List1.RowTemplate.Height = 28;
            this.List1.Size = new System.Drawing.Size(674, 364);
            this.List1.TabIndex = 12;
            // 
            // FeedbackAmbassador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.List1);
            this.Name = "FeedbackAmbassador";
            this.Text = "FeedbackAmbassador";
            this.Load += new System.EventHandler(this.FeedbackAmbassador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView List1;
    }
}