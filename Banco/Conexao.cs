using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conexao
    { 
        private string conexao = "Data Source=DESKTOP-C29AGAT;Initial Catalog=Hotelaria_Excellencia;Integrated Security=True";

        public string Conectar() {
            return conexao;
        }
    }
}

