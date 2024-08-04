using System;
using System.Data.SqlClient;
namespace LunchMate;
class Program()
{
    static void Main(string[] args)
    {
        SqlConnection sqlConnection;
         string connectionString = @"Data Source=Zebronics\SQLEXPRESS;Initial Catalog=LunchMate;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        //string connectionString = @"Data Source=Zebronics\SQLEXPRESS;Initial Catalog=LunchMate;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        try
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Conection Has established sucesfully");

            /*Console.WriteLine("Enter the food name :");
            string foodname = Console.ReadLine();
            Console.WriteLine("Enter the Food Price :");
            int foodprice = int.Parse(Console.ReadLine());    
            string insert = "INSERT INTO FOOD(food_name,food_price) VALUES('" +foodname +"'," + foodprice +")";
            SqlCommand insertCommand = new SqlCommand(insert, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data is SucessFully insterted into tabel");*/

            // retrive = R
            /*string display = "select * from FOOD";
            SqlCommand displaycommand = new SqlCommand(display, sqlConnection);
            SqlDataReader datareader = displaycommand.ExecuteReader();

            while (datareader.Read())
            {
                Console.WriteLine("Id  :" + datareader.GetValue(0).ToString());
                Console.WriteLine("Name  :" + datareader.GetValue(1).ToString());
                Console.WriteLine("Price  :" + datareader.GetValue(2).ToString());
            }
                datareader.Close();

            // Update = U
            Console.WriteLine("Enter the Food Id to Change");
            int food_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price to change");
            int food_price = Convert.ToInt32(Console.ReadLine());

            string update = "update FOOD  set food_price =  "+ food_price +"where food_id =" + food_id ;
            SqlCommand updatecommand = new SqlCommand(update, sqlConnection);  
            updatecommand.ExecuteNonQuery();
            Console.WriteLine("data has modifiedd sucessfully");
            */


            // dalete = D
            Console.WriteLine("Enter the Id to delete :");
            int del_id = Convert.ToInt32(Console.ReadLine());

            string delete = "delete FOOD  where food_id = " + del_id;
            SqlCommand deletecommand = new SqlCommand(delete,sqlConnection);
            deletecommand.ExecuteNonQuery();
            Console.WriteLine("Data base Updated ....");
            sqlConnection.Close();
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);  
    }
}
    }
