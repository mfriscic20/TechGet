using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGet.Models;

namespace TechGet.Repositories
{
    public class ProcurationRepository
    {
        public static Procuration GetProcuration(int id)
        {
            Procuration procuration = null;

            string sql = $"SELECT * FROM Nabave WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                procuration = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return procuration;
        }

        public static List<Procuration> GetProcurations()
        {
            var procurations = new List<Procuration>();

            string sql = "SELECT * FROM Nabave";
            DB.SetConfiguration("mfriscic20_DB", "mfriscic20", "'3;Y!xv0?'");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Procuration procuration = CreateObject(reader);
                procurations.Add(procuration);
            }

            reader.Close();
            DB.CloseConnection();

            return procurations;
        }

        private static Procuration CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            
            int Realizirano = int.Parse(reader["Realizirano"].ToString());
            string datum = reader["Datum"].ToString();
            Person ZaposlenikId = PersonRepository.GetPerson(int.Parse(reader["ZaposlenikId"].ToString()));
            FundingSource FinanciranjeId = FundingSourceRepository.GetFundingSource(int.Parse(reader["FinanciranjeId"].ToString()));

            var procuration = new Procuration
            {
                Id = id,
                FinanciranjeId = FinanciranjeId,
                Realizirano = Realizirano,
                Datum = datum,
                ZaposlenikId = ZaposlenikId,
            };

            return procuration;
        }
    }
}

