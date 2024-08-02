namespace Database
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.AddUser = new System.Windows.Forms.Button();
            this.RemoveUser = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.onlineLibraryDataSet = new Database.OnlineLibraryDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Database.LibraryDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.userTableAdapter = new Database.LibraryDataSetTableAdapters.UserTableAdapter();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new Database.OnlineLibraryDataSetTableAdapters.UserTableAdapter();
            this.PublishYear = new System.Windows.Forms.TextBox();
            this.PubYearLabel = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BookLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreList = new System.Windows.Forms.ListBox();
            this.genreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateBook = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.RemoveBook = new System.Windows.Forms.Button();
            this.BookGrid = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookBtn = new System.Windows.Forms.Button();
            this.TitleBtn = new System.Windows.Forms.Button();
            this.AuthorBtn = new System.Windows.Forms.Button();
            this.GenreBtn = new System.Windows.Forms.Button();
            this.GenreTxt = new System.Windows.Forms.TextBox();
            this.GenreTxtLabel = new System.Windows.Forms.Label();
            this.AddGenreBtn = new System.Windows.Forms.Button();
            this.BookGenre = new System.Windows.Forms.DataGridView();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookGenreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Database.OnlineLibraryDataSetTableAdapters.BookTableAdapter();
            this.bookGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_GenreTableAdapter = new Database.LibraryDataSetTableAdapters.Book_GenreTableAdapter();
            this.book_GenreTableAdapter1 = new Database.OnlineLibraryDataSetTableAdapters.Book_GenreTableAdapter();
            this.genreTableAdapter = new Database.OnlineLibraryDataSetTableAdapters.GenreTableAdapter();
            this.BookGenreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookGenreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookGenreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(33, 159);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(953, 45);
            this.Name.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(33, 268);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(953, 45);
            this.Email.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(33, 371);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(953, 45);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date of Birth";
            // 
            // DOB
            // 
            this.DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(33, 499);
            this.DOB.Margin = new System.Windows.Forms.Padding(4);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(953, 39);
            this.DOB.TabIndex = 10;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(33, 661);
            this.AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(312, 78);
            this.AddUser.TabIndex = 14;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // RemoveUser
            // 
            this.RemoveUser.Location = new System.Drawing.Point(674, 661);
            this.RemoveUser.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(312, 78);
            this.RemoveUser.TabIndex = 15;
            this.RemoveUser.Text = "Remove User";
            this.RemoveUser.UseVisualStyleBackColor = true;
            this.RemoveUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.Location = new System.Drawing.Point(354, 661);
            this.UpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(312, 78);
            this.UpdateUser.TabIndex = 16;
            this.UpdateUser.Text = "Update User";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 778);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(955, 420);
            this.dataGridView1.TabIndex = 17;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 175;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 175;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 175;
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "BDate";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "BDate";
            this.bDateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            this.bDateDataGridViewTextBoxColumn.Width = 175;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 175;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataMember = "User";
            this.userBindingSource2.DataSource = this.onlineLibraryDataSet;
            // 
            // onlineLibraryDataSet
            // 
            this.onlineLibraryDataSet.DataSetName = "OnlineLibraryDataSet";
            this.onlineLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 1208);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(957, 78);
            this.button3.TabIndex = 18;
            this.button3.Text = "Show Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.Type.Location = new System.Drawing.Point(33, 582);
            this.Type.Margin = new System.Windows.Forms.Padding(6);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(319, 40);
            this.Type.TabIndex = 19;
            this.Type.Text = "Type";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.onlineLibraryDataSet;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // PublishYear
            // 
            this.PublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYear.Location = new System.Drawing.Point(1048, 507);
            this.PublishYear.Margin = new System.Windows.Forms.Padding(4);
            this.PublishYear.Name = "PublishYear";
            this.PublishYear.Size = new System.Drawing.Size(627, 45);
            this.PublishYear.TabIndex = 44;
            // 
            // PubYearLabel
            // 
            this.PubYearLabel.AutoSize = true;
            this.PubYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PubYearLabel.Location = new System.Drawing.Point(1040, 448);
            this.PubYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PubYearLabel.Name = "PubYearLabel";
            this.PubYearLabel.Size = new System.Drawing.Size(176, 32);
            this.PubYearLabel.TabIndex = 43;
            this.PubYearLabel.Text = "Publish Year";
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(1046, 370);
            this.Author.Margin = new System.Windows.Forms.Padding(4);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(627, 45);
            this.Author.TabIndex = 42;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(1039, 326);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(98, 32);
            this.AuthorLabel.TabIndex = 41;
            this.AuthorLabel.Text = "Author";
            // 
            // ISBN
            // 
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(1046, 267);
            this.ISBN.Margin = new System.Windows.Forms.Padding(4);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(627, 45);
            this.ISBN.TabIndex = 40;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(1039, 222);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(79, 32);
            this.ISBNLabel.TabIndex = 39;
            this.ISBNLabel.Text = "ISBN";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(1046, 158);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(627, 45);
            this.Title.TabIndex = 38;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(1040, 113);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(69, 32);
            this.TitleLabel.TabIndex = 37;
            this.TitleLabel.Text = "Title";
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLabel.Location = new System.Drawing.Point(1035, 23);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(154, 64);
            this.BookLabel.TabIndex = 36;
            this.BookLabel.Text = "Book";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(1043, 578);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(93, 32);
            this.GenreLabel.TabIndex = 49;
            this.GenreLabel.Text = "Genre";
            // 
            // GenreList
            // 
            this.GenreList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genreBindingSource1, "Genre_Name", true));
            this.GenreList.DataSource = this.genreBindingSource;
            this.GenreList.DisplayMember = "Genre_Name";
            this.GenreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreList.FormattingEnabled = true;
            this.GenreList.ItemHeight = 32;
            this.GenreList.Location = new System.Drawing.Point(1051, 630);
            this.GenreList.Margin = new System.Windows.Forms.Padding(6);
            this.GenreList.Name = "GenreList";
            this.GenreList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GenreList.Size = new System.Drawing.Size(622, 196);
            this.GenreList.TabIndex = 48;
            this.GenreList.ValueMember = "Genre_Name";
            // 
            // genreBindingSource1
            // 
            this.genreBindingSource1.DataMember = "Genre";
            this.genreBindingSource1.DataSource = this.onlineLibraryDataSet;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.onlineLibraryDataSet;
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(1260, 866);
            this.UpdateBook.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(204, 78);
            this.UpdateBook.TabIndex = 47;
            this.UpdateBook.Text = "Update Book";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(1047, 866);
            this.AddBook.Margin = new System.Windows.Forms.Padding(4);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(204, 78);
            this.AddBook.TabIndex = 45;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // RemoveBook
            // 
            this.RemoveBook.Location = new System.Drawing.Point(1474, 866);
            this.RemoveBook.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBook.Name = "RemoveBook";
            this.RemoveBook.Size = new System.Drawing.Size(204, 78);
            this.RemoveBook.TabIndex = 46;
            this.RemoveBook.Text = "Remove Book";
            this.RemoveBook.UseVisualStyleBackColor = true;
            this.RemoveBook.Click += new System.EventHandler(this.RemoveBook_Click);
            // 
            // BookGrid
            // 
            this.BookGrid.AutoGenerateColumns = false;
            this.BookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publishYearDataGridViewTextBoxColumn,
            this.bookStateDataGridViewTextBoxColumn});
            this.BookGrid.DataSource = this.bookBindingSource;
            this.BookGrid.Location = new System.Drawing.Point(1730, 23);
            this.BookGrid.Margin = new System.Windows.Forms.Padding(6);
            this.BookGrid.Name = "BookGrid";
            this.BookGrid.RowHeadersWidth = 72;
            this.BookGrid.Size = new System.Drawing.Size(779, 716);
            this.BookGrid.TabIndex = 50;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 175;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 175;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 175;
            // 
            // publishYearDataGridViewTextBoxColumn
            // 
            this.publishYearDataGridViewTextBoxColumn.DataPropertyName = "Publish_Year";
            this.publishYearDataGridViewTextBoxColumn.HeaderText = "Publish_Year";
            this.publishYearDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
            this.publishYearDataGridViewTextBoxColumn.Width = 175;
            // 
            // bookStateDataGridViewTextBoxColumn
            // 
            this.bookStateDataGridViewTextBoxColumn.DataPropertyName = "Book_State";
            this.bookStateDataGridViewTextBoxColumn.HeaderText = "Book_State";
            this.bookStateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.bookStateDataGridViewTextBoxColumn.Name = "bookStateDataGridViewTextBoxColumn";
            this.bookStateDataGridViewTextBoxColumn.Width = 175;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.onlineLibraryDataSet;
            // 
            // BookBtn
            // 
            this.BookBtn.Location = new System.Drawing.Point(2332, 772);
            this.BookBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(179, 78);
            this.BookBtn.TabIndex = 54;
            this.BookBtn.Text = "Show Data";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // TitleBtn
            // 
            this.TitleBtn.Location = new System.Drawing.Point(2135, 772);
            this.TitleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBtn.Name = "TitleBtn";
            this.TitleBtn.Size = new System.Drawing.Size(179, 78);
            this.TitleBtn.TabIndex = 53;
            this.TitleBtn.Text = "Search by Title";
            this.TitleBtn.UseVisualStyleBackColor = true;
            this.TitleBtn.Click += new System.EventHandler(this.TitleBtn_Click);
            // 
            // AuthorBtn
            // 
            this.AuthorBtn.Location = new System.Drawing.Point(1935, 772);
            this.AuthorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorBtn.Name = "AuthorBtn";
            this.AuthorBtn.Size = new System.Drawing.Size(179, 78);
            this.AuthorBtn.TabIndex = 52;
            this.AuthorBtn.Text = "Search by Author";
            this.AuthorBtn.UseVisualStyleBackColor = true;
            this.AuthorBtn.Click += new System.EventHandler(this.AuthorBtn_Click);
            // 
            // GenreBtn
            // 
            this.GenreBtn.Location = new System.Drawing.Point(1732, 772);
            this.GenreBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenreBtn.Name = "GenreBtn";
            this.GenreBtn.Size = new System.Drawing.Size(179, 78);
            this.GenreBtn.TabIndex = 51;
            this.GenreBtn.Text = "Search by Genre";
            this.GenreBtn.UseVisualStyleBackColor = true;
            this.GenreBtn.Click += new System.EventHandler(this.GenreBtn_Click);
            // 
            // GenreTxt
            // 
            this.GenreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTxt.Location = new System.Drawing.Point(1049, 1144);
            this.GenreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTxt.Name = "GenreTxt";
            this.GenreTxt.Size = new System.Drawing.Size(627, 45);
            this.GenreTxt.TabIndex = 58;
            // 
            // GenreTxtLabel
            // 
            this.GenreTxtLabel.AutoSize = true;
            this.GenreTxtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTxtLabel.Location = new System.Drawing.Point(1043, 1091);
            this.GenreTxtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreTxtLabel.Name = "GenreTxtLabel";
            this.GenreTxtLabel.Size = new System.Drawing.Size(93, 32);
            this.GenreTxtLabel.TabIndex = 57;
            this.GenreTxtLabel.Text = "Genre";
            // 
            // AddGenreBtn
            // 
            this.AddGenreBtn.Location = new System.Drawing.Point(1047, 1208);
            this.AddGenreBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddGenreBtn.Name = "AddGenreBtn";
            this.AddGenreBtn.Size = new System.Drawing.Size(629, 78);
            this.AddGenreBtn.TabIndex = 56;
            this.AddGenreBtn.Text = "Add Genre";
            this.AddGenreBtn.UseVisualStyleBackColor = true;
            this.AddGenreBtn.Click += new System.EventHandler(this.AddGenreBtn_Click);
            // 
            // BookGenre
            // 
            this.BookGenre.AutoGenerateColumns = false;
            this.BookGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNameDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn});
            this.BookGenre.DataSource = this.bookGenreBindingSource1;
            this.BookGenre.Location = new System.Drawing.Point(1732, 882);
            this.BookGenre.Margin = new System.Windows.Forms.Padding(6);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.RowHeadersWidth = 72;
            this.BookGenre.Size = new System.Drawing.Size(764, 307);
            this.BookGenre.TabIndex = 55;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // genreNameDataGridViewTextBoxColumn
            // 
            this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "Genre_Name";
            this.genreNameDataGridViewTextBoxColumn.HeaderText = "Genre_Name";
            this.genreNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
            this.genreNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // bookGenreBindingSource1
            // 
            this.bookGenreBindingSource1.DataMember = "Book_Genre";
            this.bookGenreBindingSource1.DataSource = this.onlineLibraryDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookGenreBindingSource
            // 
            this.bookGenreBindingSource.DataMember = "Book_Genre";
            this.bookGenreBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // book_GenreTableAdapter
            // 
            this.book_GenreTableAdapter.ClearBeforeFill = true;
            // 
            // book_GenreTableAdapter1
            // 
            this.book_GenreTableAdapter1.ClearBeforeFill = true;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // BookGenreBtn
            // 
            this.BookGenreBtn.Location = new System.Drawing.Point(1730, 1208);
            this.BookGenreBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BookGenreBtn.Name = "BookGenreBtn";
            this.BookGenreBtn.Size = new System.Drawing.Size(764, 78);
            this.BookGenreBtn.TabIndex = 59;
            this.BookGenreBtn.Text = "Show Book Genre";
            this.BookGenreBtn.UseVisualStyleBackColor = true;
            this.BookGenreBtn.Click += new System.EventHandler(this.BookGenreBtn_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2524, 1406);
            this.Controls.Add(this.BookGenreBtn);
            this.Controls.Add(this.GenreTxt);
            this.Controls.Add(this.GenreTxtLabel);
            this.Controls.Add(this.AddGenreBtn);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.TitleBtn);
            this.Controls.Add(this.AuthorBtn);
            this.Controls.Add(this.GenreBtn);
            this.Controls.Add(this.BookGrid);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.GenreList);
            this.Controls.Add(this.UpdateBook);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.RemoveBook);
            this.Controls.Add(this.PublishYear);
            this.Controls.Add(this.PubYearLabel);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.RemoveUser);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "User";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookGenreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookGenreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button RemoveUser;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LibraryDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private OnlineLibraryDataSet onlineLibraryDataSet;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private OnlineLibraryDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.TextBox PublishYear;
        private System.Windows.Forms.Label PubYearLabel;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.ListBox GenreList;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button RemoveBook;
        private System.Windows.Forms.DataGridView BookGrid;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button TitleBtn;
        private System.Windows.Forms.Button AuthorBtn;
        private System.Windows.Forms.Button GenreBtn;
        private System.Windows.Forms.TextBox GenreTxt;
        private System.Windows.Forms.Label GenreTxtLabel;
        private System.Windows.Forms.Button AddGenreBtn;
        private System.Windows.Forms.DataGridView BookGenre;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private OnlineLibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookGenreBindingSource;
        private LibraryDataSetTableAdapters.Book_GenreTableAdapter book_GenreTableAdapter;
        private System.Windows.Forms.BindingSource bookGenreBindingSource1;
        private OnlineLibraryDataSetTableAdapters.Book_GenreTableAdapter book_GenreTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private OnlineLibraryDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource genreBindingSource1;
        private System.Windows.Forms.Button BookGenreBtn;
    }
}

