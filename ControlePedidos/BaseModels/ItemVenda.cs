﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class ItemVenda
    {
        public int ItemVendaID { get; set; }
        public int QuantidadeItemVenda { get; set; }
        public int QuantidadeEstoqueAtual { get; set; }
        public double PrecoUnitario { get; set; }

        //Relacionamente ItemVenda --> Produto 
        [ForeignKey("_Produto")]
        public int ProdutoID { get; set; }
        public virtual Produto _Produto { get; set; }

        //Relacionamente ItemVenda --> Embalagem
        [ForeignKey("_Embalagem")]
        public int EmbalagemID { get; set; }
        public virtual Embalagem _Embalagem { get; set; }

        //Relacionamente ItemVenda --> Embalagem
        [ForeignKey("_Categoria")]
        public int CategoriaID { get; set; }
        public virtual Categoria _Categoria { get; set; }
    }
}
