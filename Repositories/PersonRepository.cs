using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGet.Models;
using System.Data.SqlClient;

namespace TechGet.Repositories
{
    public class PersonRepository
    {

        public static Employee GetPerson(string username)
        {
            string sql=$"SELECT * FROM Zaposlenici WHERE Korisnicko_ime='{username}'";
            return FetchPerson(sql);
            
        }

        public static Employee GetPerson (int id)
        {
            string sql = $"SELECT * FROM Zaposlenici WHERE Id={id}";
            return FetchPerson(sql);
        }

        private static Employee FetchPerson(string sql)
        {
            DB.SetConfiguration("mfriscic20_DB", "mfriscic20", "'3;Y!xv0?'");
            DB.OpenConnection();
            
            var reader=DB.GetDataReader(sql);
            Employee person = null;

            if (reader.HasRows==true)
            {
                reader.Read();
                person = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return person;
        }

        private static Employee CreateObject(SqlDataReader reader)
        {
            int id=int.Parse(reader["Id"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString(); ;
            string username=reader["Korisnicko_ime"].ToString();
            string password=reader["Lozinka"].ToString();
            string ulogeId = reader["UlogeId"].ToString();

            var person = new Employee
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Korisnicko_ime=username,
                Lozinka=password,
                UlogeId = ulogeId,
                
                

            };

            return person;
        }
    }
}
