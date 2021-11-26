using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ReservaBLL
    {
        public int ID { get; set; }
        public DateTime Reserva { get; set; }
        public int idFormaPagamento { get; set; }
        public int idQuarto{ get; set; }
        public string Quarto { get; set; }
        public int _LOGIN { get; set; }
        public int _FUNCIONARIO { get; set; }
        public int _HOSPEDE { get; set; }
    }
}
