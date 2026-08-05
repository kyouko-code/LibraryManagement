using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadBooks();
            LoadMembers();
            LoadBorrowings();
            LoadBooksCombo();
            LoadMembersCombo();
        }

        private DataTable GetTable(string sql)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void ExecuteNonQuery(string sql, SqlCommand cmd = null)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand command = (cmd != null) ? cmd : new SqlCommand(sql, con);
                command.Connection = con;
                con.Open();
                command.ExecuteNonQuery();
            }
        }

        // ================== BOOKS ==================

        private void LoadBooks()
        {
            dgvBooks.DataSource = GetTable("SELECT BookID, Title, Author, Category, ISBN, Quantity FROM Book ORDER BY BookID");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!ValidateBookFields()) return;

            string sql = "INSERT INTO Book (Title, Author, Category, ISBN, Quantity) " +
                         "VALUES (@title, @author, @category, @isbn, @quantity)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
            cmd.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text.Trim()));
            ExecuteNonQuery(sql, cmd);

            MessageBox.Show("Book added successfully.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBookFields();
            LoadBooks();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book first.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateBookFields()) return;

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["colBookID"].Value);

            string sql = "UPDATE Book SET Title = @title, Author = @author, Category = @category, " +
                         "ISBN = @isbn, Quantity = @quantity WHERE BookID = @bookId";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
            cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
            cmd.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text.Trim()));
            cmd.Parameters.AddWithValue("@bookId", bookId);
            ExecuteNonQuery(sql, cmd);

            MessageBox.Show("Book updated successfully.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearBookFields();
            LoadBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book first.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["colBookID"].Value);

            if (MessageBox.Show("Delete this book?", "Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = "DELETE FROM Book WHERE BookID = @bookId";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                ExecuteNonQuery(sql, cmd);

                MessageBox.Show("Book deleted successfully.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBookFields();
                LoadBooks();
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot delete this book because it has borrow records.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchBook.Text.Trim();
            if (keyword.Length == 0)
            {
                LoadBooks();
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT BookID, Title, Author, Category, ISBN, Quantity FROM Book " +
                             "WHERE Title LIKE @kw OR Author LIKE @kw OR Category LIKE @kw OR ISBN LIKE @kw " +
                             "ORDER BY BookID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                txtTitle.Text = Convert.ToString(dgvBooks.CurrentRow.Cells["colTitle"].Value);
                txtAuthor.Text = Convert.ToString(dgvBooks.CurrentRow.Cells["colAuthor"].Value);
                txtCategory.Text = Convert.ToString(dgvBooks.CurrentRow.Cells["colCategory"].Value);
                txtISBN.Text = Convert.ToString(dgvBooks.CurrentRow.Cells["colISBN"].Value);
                txtQuantity.Text = Convert.ToString(dgvBooks.CurrentRow.Cells["colQuantity"].Value);
            }
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            ClearBookFields();
        }

        private void ClearBookFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtISBN.Clear();
            txtQuantity.Clear();
            dgvBooks.ClearSelection();
        }

        private bool ValidateBookFields()
        {
            if (txtTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the book title.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int quantity;
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                MessageBox.Show("Quantity must be a whole number.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ================== MEMBERS ==================

        private void LoadMembers()
        {
            dgvMembers.DataSource = GetTable("SELECT MemberID, FullName, Gender, Phone, Email FROM Member ORDER BY MemberID");
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (!ValidateMemberFields()) return;

            string sql = "INSERT INTO Member (FullName, Gender, Phone, Email) VALUES (@fullName, @gender, @phone, @email)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            ExecuteNonQuery(sql, cmd);

            MessageBox.Show("Member added successfully.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearMemberFields();
            LoadMembers();
            LoadMembersCombo();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Please select a member first.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateMemberFields()) return;

            int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["colMemberID"].Value);

            string sql = "UPDATE Member SET FullName = @fullName, Gender = @gender, Phone = @phone, Email = @email " +
                         "WHERE MemberID = @memberId";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@memberId", memberId);
            ExecuteNonQuery(sql, cmd);

            MessageBox.Show("Member updated successfully.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearMemberFields();
            LoadMembers();
            LoadMembersCombo();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Please select a member first.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["colMemberID"].Value);

            if (MessageBox.Show("Delete this member?", "Members", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = "DELETE FROM Member WHERE MemberID = @memberId";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@memberId", memberId);
                ExecuteNonQuery(sql, cmd);

                MessageBox.Show("Member deleted successfully.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMemberFields();
                LoadMembers();
                LoadMembersCombo();
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot delete this member because they have borrow records.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchMember.Text.Trim();
            if (keyword.Length == 0)
            {
                LoadMembers();
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT MemberID, FullName, Gender, Phone, Email FROM Member " +
                             "WHERE FullName LIKE @kw OR Phone LIKE @kw OR Email LIKE @kw " +
                             "ORDER BY MemberID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                txtFullName.Text = Convert.ToString(dgvMembers.CurrentRow.Cells["colFullName"].Value);
                cmbGender.SelectedItem = Convert.ToString(dgvMembers.CurrentRow.Cells["colGender"].Value);
                txtPhone.Text = Convert.ToString(dgvMembers.CurrentRow.Cells["colPhone"].Value);
                txtEmail.Text = Convert.ToString(dgvMembers.CurrentRow.Cells["colEmail"].Value);
            }
        }

        private void btnClearMember_Click(object sender, EventArgs e)
        {
            ClearMemberFields();
        }

        private void ClearMemberFields()
        {
            txtFullName.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            dgvMembers.ClearSelection();
        }

        private bool ValidateMemberFields()
        {
            if (txtFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the member name.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Members", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ================== BORROW / RETURN ==================

        private void LoadBooksCombo()
        {
            DataTable dt = GetTable("SELECT BookID, Title FROM Book ORDER BY Title");
            cmbBook.DataSource = dt;
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "BookID";
            cmbBook.SelectedIndex = -1;
        }

        private void LoadMembersCombo()
        {
            DataTable dt = GetTable("SELECT MemberID, FullName FROM Member ORDER BY FullName");
            cmbMember.DataSource = dt;
            cmbMember.DisplayMember = "FullName";
            cmbMember.ValueMember = "MemberID";
            cmbMember.SelectedIndex = -1;
        }

        private void LoadBorrowings()
        {
            string sql = "SELECT bo.BorrowID, bo.BookID, b.Title AS BookTitle, bo.MemberID, m.FullName AS MemberName, " +
                         "bo.BorrowDate, bo.DueDate, bo.ReturnDate, " +
                         "CASE WHEN bo.ReturnDate IS NULL THEN 'Not Returned' ELSE 'Returned' END AS Status " +
                         "FROM Borrow bo " +
                         "JOIN Book b ON bo.BookID = b.BookID " +
                         "JOIN Member m ON bo.MemberID = m.MemberID " +
                         "ORDER BY bo.BorrowID";
            dgvBorrowings.DataSource = GetTable(sql);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbBook.SelectedValue == null || cmbMember.SelectedValue == null)
            {
                MessageBox.Show("Please select a book and a member.", "Borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime borrowDate = dtpBorrowDate.Value.Date;
            DateTime dueDate = dtpDueDate.Value.Date;

            if (dueDate < borrowDate)
            {
                MessageBox.Show("Due date cannot be before the borrow date.", "Borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO Borrow (BookID, MemberID, BorrowDate, DueDate) VALUES (@bookId, @memberId, @borrowDate, @dueDate)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@bookId", Convert.ToInt32(cmbBook.SelectedValue));
            cmd.Parameters.AddWithValue("@memberId", Convert.ToInt32(cmbMember.SelectedValue));
            cmd.Parameters.AddWithValue("@borrowDate", borrowDate);
            cmd.Parameters.AddWithValue("@dueDate", dueDate);
            ExecuteNonQuery(sql, cmd);

            MessageBox.Show("Book borrowed successfully.", "Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbBook.SelectedIndex = -1;
            cmbMember.SelectedIndex = -1;
            LoadBorrowings();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowings.CurrentRow == null)
            {
                MessageBox.Show("Please select a borrowing record first.", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int borrowId = Convert.ToInt32(dgvBorrowings.CurrentRow.Cells["colBorrowID"].Value);

            string sql = "UPDATE Borrow SET ReturnDate = GETDATE() WHERE BorrowID = @borrowId AND ReturnDate IS NULL";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@borrowId", borrowId);

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                cmd.Connection = con;
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Book returned successfully.", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("This book was already returned.", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadBorrowings();
        }

        private void btnRefreshBorrow_Click(object sender, EventArgs e)
        {
            LoadBorrowings();
        }

        // ================== REPORTS ==================

        private void LoadReport(string reportResource, string sql)
        {
            DataTable dt = GetTable(sql);

            reportViewer1.LocalReport.ReportEmbeddedResource = reportResource;
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnReportBooks_Click(object sender, EventArgs e)
        {
            LoadReport("LibraryManagement.RptBooks.rdlc",
                "SELECT BookID, Title, Author, Category, ISBN, Quantity FROM Book ORDER BY BookID");
        }

        private void btnReportMembers_Click(object sender, EventArgs e)
        {
            LoadReport("LibraryManagement.RptMembers.rdlc",
                "SELECT MemberID, FullName, Gender, Phone, Email FROM Member ORDER BY MemberID");
        }

        private void btnReportBorrowings_Click(object sender, EventArgs e)
        {
            LoadReport("LibraryManagement.RptBorrowings.rdlc",
                "SELECT bo.BorrowID, b.Title AS BookTitle, m.FullName AS MemberName, " +
                "bo.BorrowDate, bo.DueDate, " +
                "CASE WHEN bo.ReturnDate IS NULL THEN 'Not Returned' ELSE 'Returned' END AS Status " +
                "FROM Borrow bo " +
                "JOIN Book b ON bo.BookID = b.BookID " +
                "JOIN Member m ON bo.MemberID = m.MemberID " +
                "ORDER BY bo.BorrowID");
        }
    }
}
