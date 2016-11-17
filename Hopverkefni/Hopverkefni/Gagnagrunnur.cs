using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Hopverkefni
{
    class Gagnagrunnur
    {
        private string server;

        private string database;

        private string uid;

        private string password;

        string tengistrengur = null;

        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqlLesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "3001992599_skilaverkefni6";
            uid = "3001992599";
            password = "mypassword";

            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }


        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }


        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }



        /* 
         * Demo um fyrirspurn
        public List<string> LesaNofnUrSQLToflu()
        {
            List<string> faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT nafn FROM gestur";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqlLesari = nySQLskipun.ExecuteReader();
                while (sqlLesari.Read())
                {
                    for (int i = 0; i < sqlLesari.FieldCount; i++)
                    {
                        lina += (sqlLesari.GetValue(i).ToString()) + ":";
                    }
                    faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return faerslur;
            }
            return faerslur;
        }
         */
    }
}
