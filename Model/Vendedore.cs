using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01.Model
{
    class Vendedore
    {

        public int ID { get; set; }
        public string Nome { get; set; }

        public double ComissaoPorcentagem { get; set; }

        public Venda[] Vendas { get; set; }

        public Vendedore(int id)
        {
            this.ID = id;
            this.Nome = "";
            this.ComissaoPorcentagem = 0;
            this.Vendas = null;

        }





    }
}
