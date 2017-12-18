using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// MysqlDatabase için özet açıklama
/// </summary>
public class MysqlDatabase
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    public string[] i1;
    public string[] i2;



    //Constructor
    public MysqlDatabase()
    {
        i1 =  new string[128];
        i2 = new string[128];
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "db353.cuhyc2prztfl.eu-west-1.rds.amazonaws.com";
        database = "db353";
        uid = "db353";
        password = "01480148";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    //open connection to database
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    Console.WriteLine("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    Console.WriteLine("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public void getResultKeyOnly(string key)
    {
        string query = "select * from resultWord where title like '%"+key+"%';";
        OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();
        int i = 0;
        while (dataReader.Read())
        {
            i1[i] = dataReader["title"].ToString();
            i1[i+1] = dataReader["date"].ToString();
            i1[i+2] = dataReader["username"].ToString();
            i1[i+3] = dataReader["subname"].ToString();
            i=i+4;
        }
        dataReader.Close();
        this.CloseConnection();
    }
    public void getResultwithDate(string key, string date1, string date2)
    {
        string query = "select * from resultWord where resultWord.date between '"+date1+"' and '"+date2+"';";
        OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();
        int i = 0;

        while (dataReader.Read())
        {
            i2[i] = dataReader["title"].ToString();
            i2[i + 1] = dataReader["date"].ToString();
            i2[i + 2] = dataReader["username"].ToString();
            i2[i + 3] = dataReader["subname"].ToString();
            i=i+4;
        }

        dataReader.Close();
        this.CloseConnection();
    }

    //Insert statement

}
