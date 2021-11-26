using System;
namespace Banco
{
    public class Conexao
    { 
        private string maquina = "Data Source=" + Environment.MachineName;
        private string bancoDados = "HotelariaExcellencia";

        public string Conectar() {
            string banco = maquina + ";Initial Catalog=" + bancoDados + "; Integrated Security = True";
            return banco;
        }
    }
}

