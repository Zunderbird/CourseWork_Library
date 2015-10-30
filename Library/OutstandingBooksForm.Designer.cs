namespace Proga_01
{
    partial class add_issue_fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_issue_fm));
            this.add_rent_userid = new System.Windows.Forms.TextBox();
            this.add_rent_date_picker = new System.Windows.Forms.DateTimePicker();
            this.add_rent_ok = new System.Windows.Forms.Button();
            this.add_rent_cancell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_rent_book_name = new System.Windows.Forms.TextBox();
            this.add_rent_book_author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_rent_userid
            // 
            this.add_rent_userid.Location = new System.Drawing.Point(129, 64);
            this.add_rent_userid.Name = "add_rent_userid";
            this.add_rent_userid.Size = new System.Drawing.Size(129, 20);
            this.add_rent_userid.TabIndex = 0;
            // 
            // add_rent_date_picker
            // 
            this.add_rent_date_picker.Enabled = false;
            this.add_rent_date_picker.Location = new System.Drawing.Point(26, 108);
            this.add_rent_date_picker.Name = "add_rent_date_picker";
            this.add_rent_date_picker.Size = new System.Drawing.Size(200, 20);
            this.add_rent_date_picker.TabIndex = 1;
            // 
            // add_rent_ok
            // 
            this.add_rent_ok.Location = new System.Drawing.Point(44, 144);
            this.add_rent_ok.Name = "add_rent_ok";
            this.add_rent_ok.Size = new System.Drawing.Size(75, 23);
            this.add_rent_ok.TabIndex = 2;
            this.add_rent_ok.Text = "Ок";
            this.add_rent_ok.UseVisualStyleBackColor = true;
            this.add_rent_ok.Click += new System.EventHandler(this.add_rent_ok_Click);
            // 
            // add_rent_cancell
            // 
            this.add_rent_cancell.Location = new System.Drawing.Point(136, 144);
            this.add_rent_cancell.Name = "add_rent_cancell";
            this.add_rent_cancell.Size = new System.Drawing.Size(75, 23);
            this.add_rent_cancell.TabIndex = 3;
            this.add_rent_cancell.Text = "Отмена";
            this.add_rent_cancell.UseVisualStyleBackColor = true;
            this.add_rent_cancell.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "№ читательского";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата выдачи:";
            // 
            // add_rent_book_name
            // 
            this.add_rent_book_name.AllowDrop = true;
            this.add_rent_book_name.Enabled = false;
            this.add_rent_book_name.Location = new System.Drawing.Point(129, 12);
            this.add_rent_book_name.Name = "add_rent_book_name";
            this.add_rent_book_name.Size = new System.Drawing.Size(129, 20);
            this.add_rent_book_name.TabIndex = 7;
            // 
            // add_rent_book_author
            // 
            this.add_rent_book_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.add_rent_book_author.Enabled = false;
            this.add_rent_book_author.Location = new System.Drawing.Point(129, 38);
            this.add_rent_book_author.Name = "add_rent_book_author";
            this.add_rent_book_author.Size = new System.Drawing.Size(129, 20);
            this.add_rent_book_author.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Автор книги";
            // 
            // add_issue_fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 179);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_rent_book_author);
            this.Controls.Add(this.add_rent_book_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_rent_cancell);
            this.Controls.Add(this.add_rent_ok);
            this.Controls.Add(this.add_rent_date_picker);
            this.Controls.Add(this.add_rent_userid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_issue_fm";
            this.Text = "Выдать книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_rent_userid;
        private System.Windows.Forms.DateTimePicker add_rent_date_picker;
        private System.Windows.Forms.Button add_rent_ok;
        private System.Windows.Forms.Button add_rent_cancell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox add_rent_book_name;
        public System.Windows.Forms.TextBox add_rent_book_author;


    }
}