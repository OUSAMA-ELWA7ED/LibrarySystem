using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibrarySystem.Models
{
    public class Library_System
    {
        private string ConnectionString = "Data Source=LAPTOP-V5U29BT4;Initial Catalog = LibrarySystem; Integrated Security = True; Trust Server Certificate=True";
        public SqlConnection Con { get; set; }

        public Library_System()
        {
            Con = new SqlConnection(ConnectionString);
        }


        public void AddBookRecord(Book bookData)
        {
            string proc = "AddBookRecord";
            SqlCommand cmd = new SqlCommand(proc, Con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Con.Open();
                
               
                cmd.Parameters.Add( new SqlParameter ("@book_ID", bookData.Id));
                cmd.Parameters.Add(new SqlParameter("@Name", bookData.Name));
                cmd.Parameters.Add(new SqlParameter("@AvailableCopies", bookData.AvailableCopies));
                cmd.Parameters.Add(new SqlParameter("@Publisher", bookData.Publisher));
                cmd.Parameters.Add(new SqlParameter("@LocationId", bookData.LocationId));
                cmd.Parameters.Add(new SqlParameter("@AuthorId", bookData.AuthorId));
                cmd.Parameters.Add(new SqlParameter("@CategoryId", bookData.CategoryId));

                
                cmd.ExecuteNonQuery();
                Console.WriteLine("Book Record Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public DataTable ReadBookData(string tableName)
        {

            DataTable bookData = new DataTable();
            string query = "SELECT b.name , b.publisher, b.available_copies FROM BOOK b; ";
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                bookData.Load(cmd.ExecuteReader());
            }

            catch (SqlException Ex)
            {

            }

            finally
            {
                Con.Close();
            }
            return bookData;
        }
         
        public int EditBook(Book B)
        {
            Console.WriteLine(B.Name);
            Console.WriteLine(B.AvailableCopies);
            Console.WriteLine(B.Publisher);
            string query = $"UPDATE Book SET [name] = '{B.Name}' , available_copies = {B.AvailableCopies}, publisher = '{B.Publisher}' WHERE [name] = '{B.Name}';";

            SqlCommand cmd = new SqlCommand(query, Con);
            int result = 0;
            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                result = 1;
                Console.WriteLine("Changes Successfully Completed");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = 0;
            }

            finally
            {
                Con.Close();
            }
            return result;

        }
        public void AddBorrowRecord(User_Borrow_Book BorrowData)
        {
            string proce = "AddBorrowRecord";
            SqlCommand cmd = new SqlCommand(proce, Con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Con.Open();

                BorrowData.BorrowId = MaxId() + 1;

                cmd.Parameters.Add(new SqlParameter("@BorrowId", BorrowData.BorrowId));
                cmd.Parameters.Add(new SqlParameter("@UserId", BorrowData.UserId));
                cmd.Parameters.Add(new SqlParameter("@book_id", BorrowData.BookId));
                cmd.Parameters.Add(new SqlParameter("@BorrowStatus", BorrowData.BorrowStatus));
                cmd.Parameters.Add(new SqlParameter("@BorrowDate", BorrowData.BorrowDate));
                cmd.Parameters.Add(new SqlParameter("@DueDate", BorrowData.DueDate));
                
                cmd.ExecuteNonQuery();
                Console.WriteLine("Borrow Record Added Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                 
            }
            finally
            {
                Con.Close();
            }

        }
        public int MaxId()
        {

            string q = "select max(BorrowID) from User_Borrow_Book; ";
            SqlCommand cmd = new SqlCommand(q, Con);
            int max;
            try
            {
                //Con.Open();
                max = (int)cmd.ExecuteScalar();
                return max;
            }
            catch (SqlException e)

            {
                Console.WriteLine(e.Message);
                throw e;

            }
            finally
            {
                //Con.Close();
            }

        }
    }
}

