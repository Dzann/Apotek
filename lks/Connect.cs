using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lks.models;

namespace lks.models
{
    class Connect
    {
        public static SqlConnection con = new SqlConnection("Data Source=GIDZANE;Initial Catalog=db_apotek;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();

        public static void openCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static int executeWrite(string sql, Dictionary<string, object> args)
        {
            try
            {
                int numberOfRowsAffected;
                openCon();
                //open a new command
                using (cmd = new SqlCommand(sql, con))
                {
                    //set the arguments given in the query
                    foreach (var pair in args)
                    {
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    //execute the query and get the number of row affected
                    Console.WriteLine(cmd.CommandText);
                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }
                closeCon();
                return numberOfRowsAffected;
            }
            catch (Exception ex)
            {
                closeCon();
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        //public static int executeWrite(string sql)
        //{
        //    try
        //    {
        //        int numberOfRowsAffected;
        //        openCon();
        //        open a new command
        //            numberOfRowsAffected = cmd.ExecuteNonQuery();
        //        closeCon();
        //        return numberOfRowsAffected;
        //    }
        //    catch (Exception ex)
        //    {
        //        closeCon();
        //        Console.WriteLine(ex.ToString());
        //        return 0;
        //    }
        //}

        public static DataTable getData(string sql)
       {
            Console.WriteLine(sql);
            DataTable data = new DataTable();
            openCon();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(data);
            closeCon();
            return data;
       }

        public static int insertLog(string aktifitas)
        {
            try
            {
                int rows = 0;
                openCon();
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
                cmd = new SqlCommand($"INSERT INTO log values('{DateTime.Now.ToString("yyyy-MM-dd")}', '{aktifitas}', '{LoginSession.id}')", con);
                rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    Console.WriteLine("Gagal menginsert log");
                else
                    Console.WriteLine("Berhasil menginsert log");

                return rows;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
