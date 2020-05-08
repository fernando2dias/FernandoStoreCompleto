using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Dominio.Entity
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
            {
                AdicionarCritica("Atenção: Não foi identificado a referencia do produto");
            }

            if (Quantidade == 0)
            {
                AdicionarCritica("Atenção: Quantidade não foi informado");
            }
        }
    }
}
