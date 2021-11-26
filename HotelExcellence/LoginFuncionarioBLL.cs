using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelExcellence.BLL
{
    public class LoginFuncionarioBLL
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int NPermissao { get; set; }
        public int  ID_FUNCIONARIO { get; set; }
        public int ID_HOSPEDE{ get; set; }
        public byte[] foto{ get; set; }

    }
}
