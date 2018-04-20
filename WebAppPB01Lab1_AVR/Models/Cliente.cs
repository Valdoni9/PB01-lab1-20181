using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPB01Lab1_AVR.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Cpf { get; set; }

        public String Email { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
