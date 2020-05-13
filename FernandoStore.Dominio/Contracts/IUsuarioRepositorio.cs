using FernandoStore.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Dominio.Contracts
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
