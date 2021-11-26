using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LoginBLL : CargosBLL
    {
        public string Email { get; set; }
        public string _Login { get; set; }
        public string Senha { get; set; }
        public int Usuario { get; set; }
        public byte[] Foto { get; set; }
    }
}
