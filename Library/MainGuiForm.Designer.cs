namespace Proga_01
{
    partial class Main_fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_fm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_main = new System.Windows.Forms.ToolStripMenuItem();
            this.auth_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.logout_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_books = new System.Windows.Forms.TabPage();
            this.add_issue_bt = new System.Windows.Forms.Button();
            this.grid_books = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.name_book_tf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.author_tf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publisher_tf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbn_tf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_users = new System.Windows.Forms.TabPage();
            this.issued_bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.login_tf = new System.Windows.Forms.TextBox();
            this.l_name_lb = new System.Windows.Forms.Label();
            this.user_name_lb = new System.Windows.Forms.Label();
            this.l_name_tf = new System.Windows.Forms.TextBox();
            this.f_name_tf = new System.Windows.Forms.TextBox();
            this.surname_lb = new System.Windows.Forms.Label();
            this.surname_tf = new System.Windows.Forms.TextBox();
            this.grid_readers = new System.Windows.Forms.DataGridView();
            this.tab_personal = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.p_login_tf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p_l_name_tf = new System.Windows.Forms.TextBox();
            this.p_f_name_tf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.p_surname_tf = new System.Windows.Forms.TextBox();
            this.grid_personal = new System.Windows.Forms.DataGridView();
            this.tab_issues = new System.Windows.Forms.TabPage();
            this.rent_search_search = new System.Windows.Forms.Button();
            this.rent_search_user_login = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rent_search_book_name = new System.Windows.Forms.TextBox();
            this.grid_issues = new System.Windows.Forms.DataGridView();
            this.tab_users_issues = new System.Windows.Forms.TabPage();
            this.grid_users_issues = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_book_tsbt = new System.Windows.Forms.ToolStripButton();
            this.edit_book_tsbt = new System.Windows.Forms.ToolStripButton();
            this.delete_book_tsbt = new System.Windows.Forms.ToolStripButton();
            this.role_lb = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_books)).BeginInit();
            this.tab_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_readers)).BeginInit();
            this.tab_personal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personal)).BeginInit();
            this.tab_issues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_issues)).BeginInit();
            this.tab_users_issues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users_issues)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_main});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_main
            // 
            this.menu_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auth_bt,
            this.logout_bt,
            this.exit_bt});
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(53, 20);
            this.menu_main.Text = "Меню";
            // 
            // auth_bt
            // 
            this.auth_bt.Name = "auth_bt";
            this.auth_bt.Size = new System.Drawing.Size(169, 22);
            this.auth_bt.Text = "Авторизация";
            this.auth_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // logout_bt
            // 
            this.logout_bt.Name = "logout_bt";
            this.logout_bt.Size = new System.Drawing.Size(169, 22);
            this.logout_bt.Text = "Завершить сеанс";
            this.logout_bt.Click += new System.EventHandler(this.logout_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(169, 22);
            this.exit_bt.Text = "Выход";
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_books);
            this.tab_main.Controls.Add(this.tab_users);
            this.tab_main.Controls.Add(this.tab_personal);
            this.tab_main.Controls.Add(this.tab_issues);
            this.tab_main.Controls.Add(this.tab_users_issues);
            this.tab_main.Location = new System.Drawing.Point(43, 27);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(753, 411);
            this.tab_main.TabIndex = 37;
            // 
            // tab_books
            // 
            this.tab_books.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_books.Controls.Add(this.add_issue_bt);
            this.tab_books.Controls.Add(this.grid_books);
            this.tab_books.Controls.Add(this.button1);
            this.tab_books.Controls.Add(this.name_book_tf);
            this.tab_books.Controls.Add(this.label4);
            this.tab_books.Controls.Add(this.author_tf);
            this.tab_books.Controls.Add(this.label3);
            this.tab_books.Controls.Add(this.publisher_tf);
            this.tab_books.Controls.Add(this.label2);
            this.tab_books.Controls.Add(this.isbn_tf);
            this.tab_books.Controls.Add(this.label1);
            this.tab_books.Location = new System.Drawing.Point(4, 22);
            this.tab_books.Name = "tab_books";
            this.tab_books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_books.Size = new System.Drawing.Size(745, 385);
            this.tab_books.TabIndex = 0;
            this.tab_books.Text = "Книги";
            this.tab_books.UseVisualStyleBackColor = true;
            // 
            // add_issue_bt
            // 
            this.add_issue_bt.BackColor = System.Drawing.Color.PowderBlue;
            this.add_issue_bt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_issue_bt.Image = ((System.Drawing.Image)(resources.GetObject("add_issue_bt.Image")));
            this.add_issue_bt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_issue_bt.Location = new System.Drawing.Point(671, 2);
            this.add_issue_bt.Name = "add_issue_bt";
            this.add_issue_bt.Size = new System.Drawing.Size(57, 43);
            this.add_issue_bt.TabIndex = 37;
            this.add_issue_bt.Text = "Выдать";
            this.add_issue_bt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.add_issue_bt.UseVisualStyleBackColor = false;
            this.add_issue_bt.Click += new System.EventHandler(this.add_issue_bt_Click);
            // 
            // grid_books
            // 
            this.grid_books.AccessibleName = "outpuGrid";
            this.grid_books.AllowUserToAddRows = false;
            this.grid_books.AllowUserToDeleteRows = false;
            this.grid_books.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_books.Location = new System.Drawing.Point(0, 47);
            this.grid_books.Name = "grid_books";
            this.grid_books.ReadOnly = true;
            this.grid_books.Size = new System.Drawing.Size(747, 337);
            this.grid_books.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.find_book_bt_Click);
            // 
            // name_book_tf
            // 
            this.name_book_tf.Location = new System.Drawing.Point(9, 18);
            this.name_book_tf.Name = "name_book_tf";
            this.name_book_tf.Size = new System.Drawing.Size(100, 20);
            this.name_book_tf.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "ISBN";
            // 
            // author_tf
            // 
            this.author_tf.Location = new System.Drawing.Point(115, 18);
            this.author_tf.Name = "author_tf";
            this.author_tf.Size = new System.Drawing.Size(100, 20);
            this.author_tf.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Издательство";
            // 
            // publisher_tf
            // 
            this.publisher_tf.Location = new System.Drawing.Point(221, 18);
            this.publisher_tf.Name = "publisher_tf";
            this.publisher_tf.Size = new System.Drawing.Size(100, 20);
            this.publisher_tf.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Автор";
            // 
            // isbn_tf
            // 
            this.isbn_tf.Location = new System.Drawing.Point(327, 18);
            this.isbn_tf.Name = "isbn_tf";
            this.isbn_tf.Size = new System.Drawing.Size(100, 20);
            this.isbn_tf.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Название книги";
            // 
            // tab_users
            // 
            this.tab_users.Controls.Add(this.issued_bt);
            this.tab_users.Controls.Add(this.button2);
            this.tab_users.Controls.Add(this.label5);
            this.tab_users.Controls.Add(this.login_tf);
            this.tab_users.Controls.Add(this.l_name_lb);
            this.tab_users.Controls.Add(this.user_name_lb);
            this.tab_users.Controls.Add(this.l_name_tf);
            this.tab_users.Controls.Add(this.f_name_tf);
            this.tab_users.Controls.Add(this.surname_lb);
            this.tab_users.Controls.Add(this.surname_tf);
            this.tab_users.Controls.Add(this.grid_readers);
            this.tab_users.Location = new System.Drawing.Point(4, 22);
            this.tab_users.Name = "tab_users";
            this.tab_users.Padding = new System.Windows.Forms.Padding(3);
            this.tab_users.Size = new System.Drawing.Size(745, 385);
            this.tab_users.TabIndex = 1;
            this.tab_users.Text = "Читатели";
            this.tab_users.UseVisualStyleBackColor = true;
            // 
            // issued_bt
            // 
            this.issued_bt.BackColor = System.Drawing.Color.PowderBlue;
            this.issued_bt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.issued_bt.Image = ((System.Drawing.Image)(resources.GetObject("issued_bt.Image")));
            this.issued_bt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.issued_bt.Location = new System.Drawing.Point(672, 3);
            this.issued_bt.Name = "issued_bt";
            this.issued_bt.Size = new System.Drawing.Size(57, 43);
            this.issued_bt.TabIndex = 38;
            this.issued_bt.Text = "Выдачи";
            this.issued_bt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.issued_bt.UseVisualStyleBackColor = false;
            this.issued_bt.Click += new System.EventHandler(this.issued_bt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.find_reader_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Логин";
            // 
            // login_tf
            // 
            this.login_tf.Location = new System.Drawing.Point(348, 21);
            this.login_tf.Name = "login_tf";
            this.login_tf.Size = new System.Drawing.Size(100, 20);
            this.login_tf.TabIndex = 7;
            // 
            // l_name_lb
            // 
            this.l_name_lb.AutoSize = true;
            this.l_name_lb.Location = new System.Drawing.Point(235, 5);
            this.l_name_lb.Name = "l_name_lb";
            this.l_name_lb.Size = new System.Drawing.Size(54, 13);
            this.l_name_lb.TabIndex = 6;
            this.l_name_lb.Text = "Отчество";
            // 
            // user_name_lb
            // 
            this.user_name_lb.AutoSize = true;
            this.user_name_lb.Location = new System.Drawing.Point(116, 5);
            this.user_name_lb.Name = "user_name_lb";
            this.user_name_lb.Size = new System.Drawing.Size(29, 13);
            this.user_name_lb.TabIndex = 5;
            this.user_name_lb.Text = "Имя";
            // 
            // l_name_tf
            // 
            this.l_name_tf.Location = new System.Drawing.Point(238, 21);
            this.l_name_tf.Name = "l_name_tf";
            this.l_name_tf.Size = new System.Drawing.Size(104, 20);
            this.l_name_tf.TabIndex = 4;
            // 
            // f_name_tf
            // 
            this.f_name_tf.Location = new System.Drawing.Point(119, 21);
            this.f_name_tf.Name = "f_name_tf";
            this.f_name_tf.Size = new System.Drawing.Size(113, 20);
            this.f_name_tf.TabIndex = 3;
            // 
            // surname_lb
            // 
            this.surname_lb.AutoSize = true;
            this.surname_lb.Location = new System.Drawing.Point(3, 5);
            this.surname_lb.Name = "surname_lb";
            this.surname_lb.Size = new System.Drawing.Size(56, 13);
            this.surname_lb.TabIndex = 2;
            this.surname_lb.Text = "Фамилия";
            // 
            // surname_tf
            // 
            this.surname_tf.Location = new System.Drawing.Point(6, 21);
            this.surname_tf.Name = "surname_tf";
            this.surname_tf.Size = new System.Drawing.Size(107, 20);
            this.surname_tf.TabIndex = 1;
            // 
            // grid_readers
            // 
            this.grid_readers.AllowUserToAddRows = false;
            this.grid_readers.AllowUserToDeleteRows = false;
            this.grid_readers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_readers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_readers.Location = new System.Drawing.Point(0, 47);
            this.grid_readers.Name = "grid_readers";
            this.grid_readers.ReadOnly = true;
            this.grid_readers.Size = new System.Drawing.Size(745, 338);
            this.grid_readers.TabIndex = 0;
            // 
            // tab_personal
            // 
            this.tab_personal.Controls.Add(this.button3);
            this.tab_personal.Controls.Add(this.label6);
            this.tab_personal.Controls.Add(this.p_login_tf);
            this.tab_personal.Controls.Add(this.label7);
            this.tab_personal.Controls.Add(this.label8);
            this.tab_personal.Controls.Add(this.p_l_name_tf);
            this.tab_personal.Controls.Add(this.p_f_name_tf);
            this.tab_personal.Controls.Add(this.label9);
            this.tab_personal.Controls.Add(this.p_surname_tf);
            this.tab_personal.Controls.Add(this.grid_personal);
            this.tab_personal.Location = new System.Drawing.Point(4, 22);
            this.tab_personal.Name = "tab_personal";
            this.tab_personal.Size = new System.Drawing.Size(745, 385);
            this.tab_personal.TabIndex = 2;
            this.tab_personal.Text = "Персонал";
            this.tab_personal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.find_personal_bt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Логин";
            // 
            // p_login_tf
            // 
            this.p_login_tf.Location = new System.Drawing.Point(348, 20);
            this.p_login_tf.Name = "p_login_tf";
            this.p_login_tf.Size = new System.Drawing.Size(100, 20);
            this.p_login_tf.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Имя";
            // 
            // p_l_name_tf
            // 
            this.p_l_name_tf.Location = new System.Drawing.Point(238, 20);
            this.p_l_name_tf.Name = "p_l_name_tf";
            this.p_l_name_tf.Size = new System.Drawing.Size(104, 20);
            this.p_l_name_tf.TabIndex = 14;
            // 
            // p_f_name_tf
            // 
            this.p_f_name_tf.Location = new System.Drawing.Point(119, 20);
            this.p_f_name_tf.Name = "p_f_name_tf";
            this.p_f_name_tf.Size = new System.Drawing.Size(113, 20);
            this.p_f_name_tf.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Фамилия";
            // 
            // p_surname_tf
            // 
            this.p_surname_tf.Location = new System.Drawing.Point(6, 20);
            this.p_surname_tf.Name = "p_surname_tf";
            this.p_surname_tf.Size = new System.Drawing.Size(107, 20);
            this.p_surname_tf.TabIndex = 11;
            // 
            // grid_personal
            // 
            this.grid_personal.AllowUserToAddRows = false;
            this.grid_personal.AllowUserToDeleteRows = false;
            this.grid_personal.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_personal.Location = new System.Drawing.Point(0, 47);
            this.grid_personal.Name = "grid_personal";
            this.grid_personal.ReadOnly = true;
            this.grid_personal.Size = new System.Drawing.Size(745, 338);
            this.grid_personal.TabIndex = 10;
            // 
            // tab_issues
            // 
            this.tab_issues.Controls.Add(this.rent_search_search);
            this.tab_issues.Controls.Add(this.rent_search_user_login);
            this.tab_issues.Controls.Add(this.label11);
            this.tab_issues.Controls.Add(this.label10);
            this.tab_issues.Controls.Add(this.rent_search_book_name);
            this.tab_issues.Controls.Add(this.grid_issues);
            this.tab_issues.Location = new System.Drawing.Point(4, 22);
            this.tab_issues.Name = "tab_issues";
            this.tab_issues.Size = new System.Drawing.Size(745, 385);
            this.tab_issues.TabIndex = 3;
            this.tab_issues.Text = "Выдачи";
            this.tab_issues.UseVisualStyleBackColor = true;
            // 
            // rent_search_search
            // 
            this.rent_search_search.Location = new System.Drawing.Point(243, 18);
            this.rent_search_search.Name = "rent_search_search";
            this.rent_search_search.Size = new System.Drawing.Size(75, 23);
            this.rent_search_search.TabIndex = 5;
            this.rent_search_search.Text = "Найти";
            this.rent_search_search.UseVisualStyleBackColor = true;
            this.rent_search_search.Click += new System.EventHandler(this.find_issues_bt_Click);
            // 
            // rent_search_user_login
            // 
            this.rent_search_user_login.Location = new System.Drawing.Point(137, 20);
            this.rent_search_user_login.Name = "rent_search_user_login";
            this.rent_search_user_login.Size = new System.Drawing.Size(100, 20);
            this.rent_search_user_login.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Читатель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Книга";
            // 
            // rent_search_book_name
            // 
            this.rent_search_book_name.Location = new System.Drawing.Point(7, 20);
            this.rent_search_book_name.Name = "rent_search_book_name";
            this.rent_search_book_name.Size = new System.Drawing.Size(124, 20);
            this.rent_search_book_name.TabIndex = 1;
            // 
            // grid_issues
            // 
            this.grid_issues.AllowUserToAddRows = false;
            this.grid_issues.AllowUserToDeleteRows = false;
            this.grid_issues.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_issues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_issues.Location = new System.Drawing.Point(1, 47);
            this.grid_issues.Name = "grid_issues";
            this.grid_issues.ReadOnly = true;
            this.grid_issues.Size = new System.Drawing.Size(743, 337);
            this.grid_issues.TabIndex = 0;
            // 
            // tab_users_issues
            // 
            this.tab_users_issues.Controls.Add(this.grid_users_issues);
            this.tab_users_issues.Location = new System.Drawing.Point(4, 22);
            this.tab_users_issues.Name = "tab_users_issues";
            this.tab_users_issues.Size = new System.Drawing.Size(745, 385);
            this.tab_users_issues.TabIndex = 4;
            this.tab_users_issues.Text = "Мои книги";
            this.tab_users_issues.UseVisualStyleBackColor = true;
            // 
            // grid_users_issues
            // 
            this.grid_users_issues.AllowUserToAddRows = false;
            this.grid_users_issues.AllowUserToDeleteRows = false;
            this.grid_users_issues.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_users_issues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users_issues.Location = new System.Drawing.Point(1, 47);
            this.grid_users_issues.Name = "grid_users_issues";
            this.grid_users_issues.ReadOnly = true;
            this.grid_users_issues.Size = new System.Drawing.Size(743, 337);
            this.grid_users_issues.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_book_tsbt,
            this.edit_book_tsbt,
            this.delete_book_tsbt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(44, 426);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_book_tsbt
            // 
            this.add_book_tsbt.AutoSize = false;
            this.add_book_tsbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_book_tsbt.Image = ((System.Drawing.Image)(resources.GetObject("add_book_tsbt.Image")));
            this.add_book_tsbt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_book_tsbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_book_tsbt.Margin = new System.Windows.Forms.Padding(0, 63, 0, 0);
            this.add_book_tsbt.Name = "add_book_tsbt";
            this.add_book_tsbt.Size = new System.Drawing.Size(44, 44);
            this.add_book_tsbt.Text = "добавить";
            this.add_book_tsbt.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.add_book_tsbt.Click += new System.EventHandler(this.add_tsbt_Click);
            // 
            // edit_book_tsbt
            // 
            this.edit_book_tsbt.AutoSize = false;
            this.edit_book_tsbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edit_book_tsbt.Image = ((System.Drawing.Image)(resources.GetObject("edit_book_tsbt.Image")));
            this.edit_book_tsbt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit_book_tsbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_book_tsbt.Margin = new System.Windows.Forms.Padding(0);
            this.edit_book_tsbt.Name = "edit_book_tsbt";
            this.edit_book_tsbt.Size = new System.Drawing.Size(44, 44);
            this.edit_book_tsbt.Text = "редактировать";
            this.edit_book_tsbt.Click += new System.EventHandler(this.edit_tsbt_Click);
            // 
            // delete_book_tsbt
            // 
            this.delete_book_tsbt.AutoSize = false;
            this.delete_book_tsbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete_book_tsbt.Image = ((System.Drawing.Image)(resources.GetObject("delete_book_tsbt.Image")));
            this.delete_book_tsbt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.delete_book_tsbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_book_tsbt.Margin = new System.Windows.Forms.Padding(0);
            this.delete_book_tsbt.Name = "delete_book_tsbt";
            this.delete_book_tsbt.Size = new System.Drawing.Size(44, 44);
            this.delete_book_tsbt.Text = "удалить";
            this.delete_book_tsbt.Click += new System.EventHandler(this.delete_tsbt_Click);
            // 
            // role_lb
            // 
            this.role_lb.AutoSize = true;
            this.role_lb.BackColor = System.Drawing.SystemColors.Control;
            this.role_lb.Location = new System.Drawing.Point(617, 9);
            this.role_lb.Name = "role_lb";
            this.role_lb.Size = new System.Drawing.Size(105, 13);
            this.role_lb.TabIndex = 39;
            this.role_lb.Text = "[Вход не выполнен]";
            // 
            // Main_fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.role_lb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_fm";
            this.Text = "БД библиотеки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_main.ResumeLayout(false);
            this.tab_books.ResumeLayout(false);
            this.tab_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_books)).EndInit();
            this.tab_users.ResumeLayout(false);
            this.tab_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_readers)).EndInit();
            this.tab_personal.ResumeLayout(false);
            this.tab_personal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personal)).EndInit();
            this.tab_issues.ResumeLayout(false);
            this.tab_issues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_issues)).EndInit();
            this.tab_users_issues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_users_issues)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem auth_bt;
        private System.Windows.Forms.DataGridView grid_readers;
        private System.Windows.Forms.ToolStripMenuItem exit_bt;
        private System.Windows.Forms.Label surname_lb;
        private System.Windows.Forms.TextBox surname_tf;
        public System.Windows.Forms.ToolStripMenuItem logout_bt;
        public System.Windows.Forms.ToolStripMenuItem menu_main;
        public System.Windows.Forms.TabControl tab_main;
        public System.Windows.Forms.TabPage tab_users;
        public System.Windows.Forms.TabPage tab_personal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton add_book_tsbt;
        private System.Windows.Forms.ToolStripButton edit_book_tsbt;
        private System.Windows.Forms.ToolStripButton delete_book_tsbt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_tf;
        private System.Windows.Forms.Label l_name_lb;
        private System.Windows.Forms.Label user_name_lb;
        private System.Windows.Forms.TextBox l_name_tf;
        private System.Windows.Forms.TextBox f_name_tf;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TabPage tab_books;
        public System.Windows.Forms.DataGridView grid_books;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_book_tf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox author_tf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publisher_tf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbn_tf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p_login_tf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p_l_name_tf;
        private System.Windows.Forms.TextBox p_f_name_tf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox p_surname_tf;
        private System.Windows.Forms.DataGridView grid_personal;
        private System.Windows.Forms.TabPage tab_issues;
        private System.Windows.Forms.TabPage tab_users_issues;
        private System.Windows.Forms.DataGridView grid_issues;
        private System.Windows.Forms.DataGridView grid_users_issues;
        private System.Windows.Forms.Button add_issue_bt;
        private System.Windows.Forms.Button issued_bt;
        private System.Windows.Forms.Label role_lb;
        private System.Windows.Forms.Button rent_search_search;
        private System.Windows.Forms.TextBox rent_search_user_login;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rent_search_book_name;

    }
}

