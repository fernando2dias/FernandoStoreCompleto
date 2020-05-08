using FernandoStore.Dominio.Entity;
using FernandoStore.Dominio.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using FernandoStore.Repositorio.Contexto;

namespace FernandoStore.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(FernandoStoreContexto fernandoStoreContexto) : base(fernandoStoreContexto)
        {
        }
    }
}
