using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CargosBLL : FuncionarioBLL
    {
        #region Atributos
        private decimal salario;
        private string cargo, carga_horaria;
        private int id, n_permissao, id_departamento;
        #endregion
        #region Propriedades
        public int Id
        {   get { return id ; } 
            set { id = value; }
        }
        public int NivelPermissao
        {
            get { return n_permissao; }
            set { n_permissao = value; }
        }
        public int IdDepartamento
        {
            get { return id_departamento; }
            set { id_departamento = value; }
        }
        public string Cargo
        {   get { return cargo; }
            set { cargo = value; }
        }

        public string CargaHoraria
        {
            get { return carga_horaria; }
            set { carga_horaria = value; }
        }
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        #endregion
    }
}
