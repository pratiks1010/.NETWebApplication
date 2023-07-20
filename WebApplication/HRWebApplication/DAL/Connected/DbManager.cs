using BOL;
using MySql.Data.MySqlClient;

namespace DAL.Connected;
    public class DbManager
    {
    public static string conString = @"server=localhost;port=3306;user=root; password=root123; database=dotnet";



    public static List<Hr> GetAllHr()
    {
        List<Hr> GetAllHrLists =  new List<Hr>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "SELECT * FROM hr";
        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int id = int.Parse(reader["ID"].ToString());
                string name = reader["FULLNAME"].ToString();
               
                string city = reader["CITY"].ToString();
                float salary = float.Parse(reader["SALARY"].ToString());
                string email = reader["EMAIL"].ToString();
                int deptNo = int.Parse(reader["DEPTNO"].ToString());

                Hr theHr = new Hr
                {
                   ID = id,
                    FullName = name,
                    City = city,
                    Salary = salary,
                    Email = email,
                    DeptNO = deptNo,

                };

                GetAllHrLists.Add(theHr);



            }
        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        finally
        {
            con.Close();
        }

        return GetAllHrLists;

    }



    }

