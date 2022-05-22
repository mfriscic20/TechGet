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
            int Klasa = int.Parse(reader["klasa"].ToString());
            int Ur_broj = int.Parse(reader["ur_broj"].ToString());
            string Opis_predmeta_nabave = reader["Opis_predmeta_nabave"].ToString();
            string P1_ponuditelj = reader["p1_ponuditelj"].ToString();
            float P1_cijena = float.Parse(reader["p1_cijena"].ToString());
            int P1_odabrano = int.Parse(reader["p1_odabrano"].ToString());
            string P2_ponuditelj = reader["p2_ponuditelj"].ToString();
            float P2_cijena = float.Parse(reader["p2_cijena"].ToString());
            int P2_odabrano = int.Parse(reader["p2_odabrano"].ToString());
            int Br_projekta = int.Parse(reader["br_projekta"].ToString());
            string Naziv_projekta = reader["naziv_projekta"].ToString();
            string Dodatna_pojasnjenja = reader["dodatna_pojasnjenja"].ToString();




            var procuration = new Procuration
            {
                Id = id,
                FinanciranjeId = FinanciranjeId,
                Realizirano = Realizirano,
                Datum = datum,
                ZaposlenikId = ZaposlenikId,
                klasa=Klasa,
                ur_broj=Ur_broj,
                Opis_predmeta_nabave=Opis_predmeta_nabave,
                p1_ponuditelj=P1_ponuditelj,
                p1_cijena=P1_cijena,
                p1_odabrano=P1_odabrano,
                p2_ponuditelj=P2_ponuditelj,
                p2_cijena=P2_cijena,
                p2_odabrano=P2_odabrano,
                br_projekta=Br_projekta,
                naziv_projekta=Naziv_projekta,
                dodatna_pojasnjenja=Dodatna_pojasnjenja,
                

            };

            return procuration;
        }
    }
}

