using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class FuncionarioBLL : Pessoa
    {
        public string Status { get; set; }
        public byte[] Foto{ get; set; }
        public int IDcargo { get; set; }
        public string nomeDepartamento { get; set; }
        public string Cargo { get; set; }
    }
}
