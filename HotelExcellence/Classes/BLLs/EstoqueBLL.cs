using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EstoqueBLL
    {

        private int id, quantidade;
        private string produto;
        private decimal preco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
