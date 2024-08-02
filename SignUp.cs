using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Database
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {         
            this.genreTableAdapter.Fill(this.onlineLibraryDataSet.Genre); 
            this.book_GenreTableAdapter.Fill(this.libraryDataSet.Book_Genre);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string userName = Name.Text;
            string userEmail = Email.Text;
            string password = Password.Text;
            DateTime birthdate = DOB.Value;
            string date = birthdate.ToString("yyyy-MM-dd");
            string userType = Type.SelectedItem.ToString();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO [User] VALUES('"+userName+"','"+password+"','"+userEmail+"','"+date+"','"+userType+"')";
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("User added successfully");

                sqlConnection.Close();

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string userName = Name.Text;
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM [User] WHERE Name = '" + userName + "'";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("User deleted successfully");
            sqlConnection.Close();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string userName = Name.Text;
            string userEmail = Email.Text;
            string password = Password.Text;
            DateTime birthdate = DOB.Value;
            string date = birthdate.ToString("yyyy-MM-dd");
            string userType = Type.SelectedItem.ToString();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE [User] SET Email = '"+userEmail+"', Password = '"+password+"', BDate = '"+date+"', Type = '"+userType+"' WHERE Name = '"+userName+"'";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("User updated successfully");

            sqlConnection.Close();
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            this.userTableAdapter1.Fill(this.onlineLibraryDataSet.User);
        }

        private void GenreBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            List<string> genres = new List<string>();
            foreach (var item in GenreList.SelectedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    string genre = dataRowView.Row["Genre_Name"].ToString();
                    genres.Add(genre);
                }
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select book.* from book, book_genre where book.title = book_genre.Book_Name and Genre_Name = @Genre", sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Genre", genres[0]);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            BookGrid.DataSource = dataTable;



            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select book.* from book, book_genre where book.title = book_genre.Book_Name and Genre_Name ='" + genres[0] +"'";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.onlineLibraryDataSet.Book);
        }

        private void BookGenreBtn_Click(object sender, EventArgs e)
        {
            this.book_GenreTableAdapter1.Fill(this.onlineLibraryDataSet.Book_Genre);
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string title = Title.Text;
            string isbn = ISBN.Text;
            string author = Author.Text;
            string pubYear = PublishYear.Text;
            List<string> genres = new List<string>();
            foreach (var item in GenreList.SelectedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null){
                    string genre = dataRowView.Row["Genre_Name"].ToString();
                    genres.Add(genre);
                }
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO [Book] (Title,ISBN,Author,Publish_Year)  VALUES('" + title + "','" + isbn + "','" + author + "','" + pubYear + "');";
            foreach (var item in genres)
            {

                //MessageBox.Show(item);
                sqlCommand.CommandText += "INSERT INTO [Book_Genre] (Book_Name,Genre_Name)  VALUES('" + title + "','" + item + "');";
            }
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Book added successfully");

            sqlConnection.Close();
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string title = Title.Text;
            string isbn = ISBN.Text;
            string author = Author.Text;
            string pubYear = PublishYear.Text;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE [Book] SET ISBN = '" + isbn + "', Author = '" + author + "', Publish_Year = '" + pubYear + "' WHERE Title = '" + title + "'";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Book updated successfully");

            sqlConnection.Close();
        }

        private void RemoveBook_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string title = Title.Text;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM [Book_Genre] WHERE Book_Name = '" + title + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "DELETE FROM [Book] WHERE Title = '" + title + "'";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Book deleted successfully");
            sqlConnection.Close();
        }

        private void AddGenreBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string genre = GenreTxt.Text;

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO [Genre] VALUES('" + genre + "')";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Genre added successfully");

            sqlConnection.Close();
        }

        private void TitleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string title = Title.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Book] WHERE Title =@Title", sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Title", title);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            BookGrid.DataSource = dataTable;
        }

        private void AuthorBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=FatmaAtta;Initial Catalog=OnlineLibrary;Integrated Security=True;Encrypt=False");
            string author = Author.Text;


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Book] WHERE Author = @Author", sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Author", author);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            BookGrid.DataSource = dataTable;

        }
    }
}
