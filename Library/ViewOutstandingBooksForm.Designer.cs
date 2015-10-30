namespace Proga_01
{
    partial class issued_fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issued_fm));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.issued_ok = new System.Windows.Forms.Button();
            this.issued_grid = new System.Windows.Forms.DataGridView();
            this.issued_login = new System.Windows.Forms.TextBox();
            this.issued_fio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.issued_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ФИО";
            // 
            // issued_ok
            // 
            this.issued_ok.Location = new System.Drawing.Point(186, 173);
            this.issued_ok.Name = "issued_ok";
            this.issued_ok.Size = new System.Drawing.Size(75, 23);
            this.issued_ok.TabIndex = 5;
            this.issued_ok.Text = "Ок";
            this.issued_ok.UseVisualStyleBackColor = true;
            this.issued_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // issued_grid
            // 
            this.issued_grid.AllowUserToAddRows = false;
            this.issued_grid.AllowUserToDeleteRows = false;
            this.issued_grid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.issued_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issued_grid.Location = new System.Drawing.Point(24, 35);
            this.issued_grid.Name = "issued_grid";
            this.issued_grid.ReadOnly = true;
            this.issued_grid.Size = new System.Drawing.Size(397, 121);
            this.issued_grid.TabIndex = 6;
            // 
            // issued_login
            // 
            this.issued_login.Enabled = false;
            this.issued_login.Location = new System.Drawing.Point(65, 6);
            this.issued_login.Name = "issued_login";
            this.issued_login.Size = new System.Drawing.Size(100, 20);
            this.issued_login.TabIndex = 7;
            // 
            // issued_fio
            // 
            this.issued_fio.Enabled = false;
            this.issued_fio.Location = new System.Drawing.Point(243, 6);
            this.issued_fio.Name = "issued_fio";
            this.issued_fio.Size = new System.Drawing.Size(178, 20);
            this.issued_fio.TabIndex = 8;
            // 
            // issued_fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 208);
            this.Controls.Add(this.issued_fio);
            this.Controls.Add(this.issued_login);
            this.Controls.Add(this.issued_grid);
            this.Controls.Add(this.issued_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "issued_fm";
            this.Text = "Просмотр выдач пользователю";
            ((System.ComponentModel.ISupportInitialize)(this.issued_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button issued_ok;
        private System.Windows.Forms.DataGridView issued_grid;
        private System.Windows.Forms.TextBox issued_login;
        private System.Windows.Forms.TextBox issued_fio;
    }
}