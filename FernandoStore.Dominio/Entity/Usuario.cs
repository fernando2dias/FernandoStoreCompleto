using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Dominio.Entity
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        // Um usuario pode ter nenhum ou muitos pedidos
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Email não foi informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não foi informado");
            }

        }
    }
}
