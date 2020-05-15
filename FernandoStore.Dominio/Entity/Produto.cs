using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Dominio.Entity
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Atenção o produto precisa de um nome!");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Atenção o produto precisa de uma descrição!");
            }
        }
    }
}
