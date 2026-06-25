namespace AlBarilWindow.UI.Manager1
{
    partial class EmployeeManager
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Roletxt = new System.Windows.Forms.TextBox();
            this.Salarytxt = new System.Windows.Forms.TextBox();
            this.EmployeeIdtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(970, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 58);
            this.button3.TabIndex = 41;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(970, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 58);
            this.button2.TabIndex = 40;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(970, 220);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(141, 58);
            this.Button1.TabIndex = 39;
            this.Button1.Text = "Add";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Roletxt
            // 
            this.Roletxt.Location = new System.Drawing.Point(462, 580);
            this.Roletxt.Name = "Roletxt";
            this.Roletxt.Size = new System.Drawing.Size(230, 26);
            this.Roletxt.TabIndex = 38;
            // 
            // Salarytxt
            // 
            this.Salarytxt.Location = new System.Drawing.Point(462, 535);
            this.Salarytxt.Name = "Salarytxt";
            this.Salarytxt.Size = new System.Drawing.Size(230, 26);
            this.Salarytxt.TabIndex = 37;
            // 
            // EmployeeIdtxt
            // 
            this.EmployeeIdtxt.Location = new System.Drawing.Point(462, 493);
            this.EmployeeIdtxt.Name = "EmployeeIdtxt";
            this.EmployeeIdtxt.Size = new System.Drawing.Size(230, 26);
            this.EmployeeIdtxt.TabIndex = 36;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(462, 451);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(230, 26);
            this.Nametxt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(321, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(321, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(321, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "EmployeeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(321, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Name";
            // 
            // Table1
            // 
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.Location = new System.Drawing.Point(211, 25);
            this.Table1.Name = "Table1";
            this.Table1.RowHeadersWidth = 62;
            this.Table1.RowTemplate.Height = 28;
            this.Table1.Size = new System.Drawing.Size(741, 414);
            this.Table1.TabIndex = 30;
            this.Table1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table1_CellClick);
            this.Table1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(515, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 58);
            this.button4.TabIndex = 42;
            this.button4.Text = "back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 707);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Roletxt);
            this.Controls.Add(this.Salarytxt);
            this.Controls.Add(this.EmployeeIdtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table1);
            this.Name = "EmployeeManager";
            this.Text = "EmployeeManager";
            this.Load += new System.EventHandler(this.EmployeeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox Roletxt;
        private System.Windows.Forms.TextBox Salarytxt;
        private System.Windows.Forms.TextBox EmployeeIdtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.Button button4;
    }
}