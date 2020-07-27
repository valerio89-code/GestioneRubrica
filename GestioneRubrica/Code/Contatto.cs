using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Code
{
    public class Contatto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroTelefono { get; set; }
        public Contatto()
        {

        }
        public Contatto(string lineFromCsv)
        {
            var splittedLine = lineFromCsv.Split(',');
            Nome = splittedLine[0];
            Cognome = splittedLine[1];
            NumeroTelefono = splittedLine[2];
        }
    }
}
