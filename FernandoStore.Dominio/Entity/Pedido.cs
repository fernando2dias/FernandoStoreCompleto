using FernandoStore.Dominio.Entity.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoStore.Dominio.Entity
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; } 

        // Pedido deve ter pelo menos um item de pedido ou muitos
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
            {
                 AdicionarCritica("Atenção: Pedido nao pode ficar sem itens de pedido!");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Atenção: CEP não pode ser vazio!");
            }
          

            if (string.IsNullOrEmpty(EnderecoCompleto))
            {
                AdicionarCritica("Atenção: O endereço deve ser preenchido!");
            }

            if (FormaPagamentoId == 0)
            {
                AdicionarCritica("Atenção: Não foi informado a forma de pagamento");
            }
        }
    }
}
