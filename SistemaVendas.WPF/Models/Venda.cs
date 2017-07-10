using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.WPF.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Id_cliente { get; set; }
        public double Numero { get; set; }
        public double ValorTotal { get; set; }

        //CAMPO VIRTUAL
        public string Nome { get; set; }

    }
}
