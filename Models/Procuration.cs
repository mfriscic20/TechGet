using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGet.Models
{
    public class Procuration
    {
        public int Id { get; set; }

        public FundingSource FinanciranjeId { get; set; }

        public int Realizirano { get; set; }

        public string Datum { get; set; }

        public Person ZaposlenikId { get; set; }
    }
}
