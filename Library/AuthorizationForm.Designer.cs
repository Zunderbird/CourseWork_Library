namespace Proga_01
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.login_tf = new System.Windows.Forms.TextBox();
            this.pass_tf = new System.Windows.Forms.TextBox();
            this.login_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancell_login_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_tf
            // 
            this.login_tf.Location = new System.Drawing.Point(76, 12);
            this.login_tf.Name = "login_tf";
            this.login_tf.Size = new System.Drawing.Size(100, 20);
            this.login_tf.TabIndex = 0;
            // 
            // pass_tf
            // 
            this.pass_tf.HideSelection = false;
            this.pass_tf.Location = new System.Drawing.Point(76, 38);
            this.pass_tf.Name = "pass_tf";
            this.pass_tf.PasswordChar = '*';
            this.pass_tf.Size = new System.Drawing.Size(100, 20);
            this.pass_tf.TabIndex = 1;
            // 
            // login_bt
            // 
            this.login_bt.Location = new System.Drawing.Point(28, 74);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(75, 23);
            this.login_bt.TabIndex = 2;
            this.login_bt.Text = "Войти";
            this.login_bt.UseVisualStyleBackColor = true;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // cancell_login_bt
            // 
            this.cancell_login_bt.Location = new System.Drawing.Point(116, 74);
            this.cancell_login_bt.Name = "cancell_login_bt";
            this.cancell_login_bt.Size = new System.Drawing.Size(75, 23);
            this.cancell_login_bt.TabIndex = 5;
            this.cancell_login_bt.Text = "Отмена";
            this.cancell_login_bt.UseVisualStyleBackColor = true;
            this.cancell_login_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 110);
            this.Controls.Add(this.cancell_login_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.pass_tf);
            this.Controls.Add(this.login_tf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tf;
        private System.Windows.Forms.TextBox pass_tf;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancell_login_bt;
    }
}