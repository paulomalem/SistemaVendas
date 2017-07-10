using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.WPF.Models
{
    public class ItemVenda
    {   
        public int Id { get; set; }
        public int Id_Venda { get; set; }
        public int Id_Produto { get; set; }
        public string Descricao_Produto { get; set; }
        public double Valor_Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
