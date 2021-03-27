﻿using System;

namespace AppMVC.Business.Models
{
    public class VendaItem : Entity
    {
        public int Quantidade { get; set; }

        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public Guid VendaId { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
