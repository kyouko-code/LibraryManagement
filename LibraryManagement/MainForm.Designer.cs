namespace LibraryManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearchBook = new System.Windows.Forms.GroupBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.btnClearBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearchMember = new System.Windows.Forms.GroupBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.btnClearMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.dgvBorrowings = new System.Windows.Forms.DataGridView();
            this.colBorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBorrowInfo = new System.Windows.Forms.GroupBox();
            this.btnRefreshBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grpReportButtons = new System.Windows.Forms.GroupBox();
            this.btnReportBorrowings = new System.Windows.Forms.Button();
            this.btnReportMembers = new System.Windows.Forms.Button();
            this.btnReportBooks = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.grpSearchBook.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            this.tabMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.grpSearchMember.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).BeginInit();
            this.grpBorrowInfo.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.grpReportButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabBorrow);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.grpSearchBook);
            this.tabBooks.Controls.Add(this.grpBookInfo);
            this.tabBooks.Location = new System.Drawing.Point(4, 24);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(1092, 622);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookID,
            this.colTitle,
            this.colAuthor,
            this.colCategory,
            this.colISBN,
            this.colQuantity});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 177);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(1086, 442);
            this.dgvBooks.TabIndex = 4;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // colBookID
            // 
            this.colBookID.DataPropertyName = "BookID";
            this.colBookID.HeaderText = "Book ID";
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            this.colBookID.Width = 70;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 250;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 180;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 130;
            // 
            // colISBN
            // 
            this.colISBN.DataPropertyName = "ISBN";
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 120;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 80;
            // 
            // grpSearchBook
            // 
            this.grpSearchBook.Controls.Add(this.btnSearchBook);
            this.grpSearchBook.Controls.Add(this.txtSearchBook);
            this.grpSearchBook.Controls.Add(this.lblSearchBook);
            this.grpSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchBook.Location = new System.Drawing.Point(3, 128);
            this.grpSearchBook.Name = "grpSearchBook";
            this.grpSearchBook.Size = new System.Drawing.Size(1086, 49);
            this.grpSearchBook.TabIndex = 3;
            this.grpSearchBook.TabStop = false;
            this.grpSearchBook.Text = "Search Book";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(420, 16);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(90, 25);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(150, 18);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(250, 23);
            this.txtSearchBook.TabIndex = 1;
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Location = new System.Drawing.Point(20, 21);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(110, 17);
            this.lblSearchBook.TabIndex = 0;
            this.lblSearchBook.Text = "Title / Author / ISBN:";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.btnClearBook);
            this.grpBookInfo.Controls.Add(this.btnDeleteBook);
            this.grpBookInfo.Controls.Add(this.btnUpdateBook);
            this.grpBookInfo.Controls.Add(this.btnAddBook);
            this.grpBookInfo.Controls.Add(this.txtQuantity);
            this.grpBookInfo.Controls.Add(this.lblQuantity);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.lblISBN);
            this.grpBookInfo.Controls.Add(this.txtCategory);
            this.grpBookInfo.Controls.Add(this.lblCategory);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Controls.Add(this.txtTitle);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBookInfo.Location = new System.Drawing.Point(3, 3);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(1086, 125);
            this.grpBookInfo.TabIndex = 2;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Information";
            // 
            // btnClearBook
            // 
            this.btnClearBook.Location = new System.Drawing.Point(920, 68);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(90, 30);
            this.btnClearBook.TabIndex = 13;
            this.btnClearBook.Text = "Clear";
            this.btnClearBook.UseVisualStyleBackColor = true;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(820, 68);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteBook.TabIndex = 12;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(720, 68);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateBook.TabIndex = 11;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(620, 68);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(90, 30);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(410, 65);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 23);
            this.txtQuantity.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(320, 68);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(110, 65);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(180, 23);
            this.txtISBN.TabIndex = 7;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(20, 68);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(42, 17);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(720, 25);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(180, 23);
            this.txtCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(620, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(410, 25);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(180, 23);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(320, 28);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(110, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(180, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.dgvMembers);
            this.tabMembers.Controls.Add(this.grpSearchMember);
            this.tabMembers.Controls.Add(this.grpMemberInfo);
            this.tabMembers.Location = new System.Drawing.Point(4, 24);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(1092, 622);
            this.tabMembers.TabIndex = 1;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AutoGenerateColumns = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colFullName,
            this.colGender,
            this.colPhone,
            this.colEmail});
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(3, 143);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1086, 476);
            this.dgvMembers.TabIndex = 4;
            this.dgvMembers.SelectionChanged += new System.EventHandler(this.dgvMembers_SelectionChanged);
            // 
            // colMemberID
            // 
            this.colMemberID.DataPropertyName = "MemberID";
            this.colMemberID.HeaderText = "Member ID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Width = 80;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 220;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 90;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 120;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 220;
            // 
            // grpSearchMember
            // 
            this.grpSearchMember.Controls.Add(this.btnSearchMember);
            this.grpSearchMember.Controls.Add(this.txtSearchMember);
            this.grpSearchMember.Controls.Add(this.lblSearchMember);
            this.grpSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchMember.Location = new System.Drawing.Point(3, 94);
            this.grpSearchMember.Name = "grpSearchMember";
            this.grpSearchMember.Size = new System.Drawing.Size(1086, 49);
            this.grpSearchMember.TabIndex = 3;
            this.grpSearchMember.TabStop = false;
            this.grpSearchMember.Text = "Search Member";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(420, 16);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(90, 25);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(150, 18);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(250, 23);
            this.txtSearchMember.TabIndex = 1;
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Location = new System.Drawing.Point(20, 21);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(128, 17);
            this.lblSearchMember.TabIndex = 0;
            this.lblSearchMember.Text = "Name / Phone / Email:";
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.btnClearMember);
            this.grpMemberInfo.Controls.Add(this.btnDeleteMember);
            this.grpMemberInfo.Controls.Add(this.btnUpdateMember);
            this.grpMemberInfo.Controls.Add(this.btnAddMember);
            this.grpMemberInfo.Controls.Add(this.txtEmail);
            this.grpMemberInfo.Controls.Add(this.lblEmail);
            this.grpMemberInfo.Controls.Add(this.txtPhone);
            this.grpMemberInfo.Controls.Add(this.lblPhone);
            this.grpMemberInfo.Controls.Add(this.cmbGender);
            this.grpMemberInfo.Controls.Add(this.lblGender);
            this.grpMemberInfo.Controls.Add(this.txtFullName);
            this.grpMemberInfo.Controls.Add(this.lblFullName);
            this.grpMemberInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMemberInfo.Location = new System.Drawing.Point(3, 3);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Size = new System.Drawing.Size(1086, 91);
            this.grpMemberInfo.TabIndex = 2;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Information";
            // 
            // btnClearMember
            // 
            this.btnClearMember.Location = new System.Drawing.Point(920, 50);
            this.btnClearMember.Name = "btnClearMember";
            this.btnClearMember.Size = new System.Drawing.Size(90, 28);
            this.btnClearMember.TabIndex = 11;
            this.btnClearMember.Text = "Clear";
            this.btnClearMember.UseVisualStyleBackColor = true;
            this.btnClearMember.Click += new System.EventHandler(this.btnClearMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(820, 50);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(90, 28);
            this.btnDeleteMember.TabIndex = 10;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(720, 50);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(90, 28);
            this.btnUpdateMember.TabIndex = 9;
            this.btnUpdateMember.Text = "Update";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(620, 50);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(90, 28);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(895, 18);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(820, 21);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(630, 18);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 23);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(550, 21);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 17);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(420, 18);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 25);
            this.cmbGender.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(330, 21);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 17);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(120, 18);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 21);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(72, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // tabBorrow
            // 
            this.tabBorrow.Controls.Add(this.dgvBorrowings);
            this.tabBorrow.Controls.Add(this.grpBorrowInfo);
            this.tabBorrow.Location = new System.Drawing.Point(4, 24);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrow.Size = new System.Drawing.Size(1092, 622);
            this.tabBorrow.TabIndex = 2;
            this.tabBorrow.Text = "Borrow / Return";
            this.tabBorrow.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowings
            // 
            this.dgvBorrowings.AllowUserToAddRows = false;
            this.dgvBorrowings.AllowUserToDeleteRows = false;
            this.dgvBorrowings.AutoGenerateColumns = false;
            this.dgvBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBorrowID,
            this.colBookTitle,
            this.colMemberName,
            this.colBorrowDate,
            this.colDueDate,
            this.colReturnDate,
            this.colStatus});
            this.dgvBorrowings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowings.Location = new System.Drawing.Point(3, 97);
            this.dgvBorrowings.MultiSelect = false;
            this.dgvBorrowings.Name = "dgvBorrowings";
            this.dgvBorrowings.ReadOnly = true;
            this.dgvBorrowings.RowHeadersVisible = false;
            this.dgvBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowings.Size = new System.Drawing.Size(1086, 522);
            this.dgvBorrowings.TabIndex = 3;
            // 
            // colBorrowID
            // 
            this.colBorrowID.DataPropertyName = "BorrowID";
            this.colBorrowID.HeaderText = "Borrow ID";
            this.colBorrowID.Name = "colBorrowID";
            this.colBorrowID.ReadOnly = true;
            this.colBorrowID.Width = 80;
            // 
            // colBookTitle
            // 
            this.colBookTitle.DataPropertyName = "BookTitle";
            this.colBookTitle.HeaderText = "Book Title";
            this.colBookTitle.Name = "colBookTitle";
            this.colBookTitle.ReadOnly = true;
            this.colBookTitle.Width = 230;
            // 
            // colMemberName
            // 
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.HeaderText = "Member Name";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Width = 200;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.DataPropertyName = "BorrowDate";
            this.colBorrowDate.HeaderText = "Borrow Date";
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            this.colBorrowDate.Width = 110;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Width = 110;
            // 
            // colReturnDate
            // 
            this.colReturnDate.DataPropertyName = "ReturnDate";
            this.colReturnDate.HeaderText = "Return Date";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Width = 110;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 110;
            // 
            // grpBorrowInfo
            // 
            this.grpBorrowInfo.Controls.Add(this.btnRefreshBorrow);
            this.grpBorrowInfo.Controls.Add(this.btnReturn);
            this.grpBorrowInfo.Controls.Add(this.btnBorrow);
            this.grpBorrowInfo.Controls.Add(this.dtpDueDate);
            this.grpBorrowInfo.Controls.Add(this.lblDueDate);
            this.grpBorrowInfo.Controls.Add(this.dtpBorrowDate);
            this.grpBorrowInfo.Controls.Add(this.lblBorrowDate);
            this.grpBorrowInfo.Controls.Add(this.cmbMember);
            this.grpBorrowInfo.Controls.Add(this.lblMember);
            this.grpBorrowInfo.Controls.Add(this.cmbBook);
            this.grpBorrowInfo.Controls.Add(this.lblBook);
            this.grpBorrowInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBorrowInfo.Location = new System.Drawing.Point(3, 3);
            this.grpBorrowInfo.Name = "grpBorrowInfo";
            this.grpBorrowInfo.Size = new System.Drawing.Size(1086, 94);
            this.grpBorrowInfo.TabIndex = 2;
            this.grpBorrowInfo.TabStop = false;
            this.grpBorrowInfo.Text = "Borrow / Return a Book";
            // 
            // btnRefreshBorrow
            // 
            this.btnRefreshBorrow.Location = new System.Drawing.Point(920, 30);
            this.btnRefreshBorrow.Name = "btnRefreshBorrow";
            this.btnRefreshBorrow.Size = new System.Drawing.Size(90, 30);
            this.btnRefreshBorrow.TabIndex = 10;
            this.btnRefreshBorrow.Text = "Refresh";
            this.btnRefreshBorrow.UseVisualStyleBackColor = true;
            this.btnRefreshBorrow.Click += new System.EventHandler(this.btnRefreshBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(820, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 30);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(720, 30);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(90, 30);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(450, 55);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(220, 23);
            this.dtpDueDate.TabIndex = 7;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(360, 58);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(66, 17);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(110, 55);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(220, 23);
            this.dtpBorrowDate.TabIndex = 5;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(20, 58);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(86, 17);
            this.lblBorrowDate.TabIndex = 4;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // cmbMember
            // 
            this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(450, 18);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(220, 25);
            this.cmbMember.TabIndex = 3;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(360, 21);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(58, 17);
            this.lblMember.TabIndex = 2;
            this.lblMember.Text = "Member:";
            // 
            // cmbBook
            // 
            this.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(110, 18);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(220, 25);
            this.cmbBook.TabIndex = 1;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(20, 21);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(43, 17);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Book:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.reportViewer1);
            this.tabReports.Controls.Add(this.grpReportButtons);
            this.tabReports.Location = new System.Drawing.Point(4, 24);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(1092, 622);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1086, 567);
            this.reportViewer1.TabIndex = 1;
            // 
            // grpReportButtons
            // 
            this.grpReportButtons.Controls.Add(this.btnReportBorrowings);
            this.grpReportButtons.Controls.Add(this.btnReportMembers);
            this.grpReportButtons.Controls.Add(this.btnReportBooks);
            this.grpReportButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpReportButtons.Location = new System.Drawing.Point(3, 3);
            this.grpReportButtons.Name = "grpReportButtons";
            this.grpReportButtons.Size = new System.Drawing.Size(1086, 49);
            this.grpReportButtons.TabIndex = 0;
            this.grpReportButtons.TabStop = false;
            this.grpReportButtons.Text = "Reports";
            // 
            // btnReportBorrowings
            // 
            this.btnReportBorrowings.Location = new System.Drawing.Point(320, 16);
            this.btnReportBorrowings.Name = "btnReportBorrowings";
            this.btnReportBorrowings.Size = new System.Drawing.Size(130, 25);
            this.btnReportBorrowings.TabIndex = 2;
            this.btnReportBorrowings.Text = "Borrowing Report";
            this.btnReportBorrowings.UseVisualStyleBackColor = true;
            this.btnReportBorrowings.Click += new System.EventHandler(this.btnReportBorrowings_Click);
            // 
            // btnReportMembers
            // 
            this.btnReportMembers.Location = new System.Drawing.Point(180, 16);
            this.btnReportMembers.Name = "btnReportMembers";
            this.btnReportMembers.Size = new System.Drawing.Size(130, 25);
            this.btnReportMembers.TabIndex = 1;
            this.btnReportMembers.Text = "Member Report";
            this.btnReportMembers.UseVisualStyleBackColor = true;
            this.btnReportMembers.Click += new System.EventHandler(this.btnReportMembers_Click);
            // 
            // btnReportBooks
            // 
            this.btnReportBooks.Location = new System.Drawing.Point(20, 16);
            this.btnReportBooks.Name = "btnReportBooks";
            this.btnReportBooks.Size = new System.Drawing.Size(130, 25);
            this.btnReportBooks.TabIndex = 0;
            this.btnReportBooks.Text = "Book Report";
            this.btnReportBooks.UseVisualStyleBackColor = true;
            this.btnReportBooks.Click += new System.EventHandler(this.btnReportBooks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.grpSearchBook.ResumeLayout(false);
            this.grpSearchBook.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.tabMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.grpSearchMember.ResumeLayout(false);
            this.grpSearchMember.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.tabBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).EndInit();
            this.grpBorrowInfo.ResumeLayout(false);
            this.grpBorrowInfo.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.grpReportButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox grpSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.GroupBox grpSearchMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Button btnClearMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.DataGridView dgvBorrowings;
        private System.Windows.Forms.GroupBox grpBorrowInfo;
        private System.Windows.Forms.Button btnRefreshBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.TabPage tabReports;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox grpReportButtons;
        private System.Windows.Forms.Button btnReportBorrowings;
        private System.Windows.Forms.Button btnReportMembers;
        private System.Windows.Forms.Button btnReportBooks;
    }
}
