using FernandoStore.Dominio.Entity;
using FernandoStore.Dominio.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using FernandoStore.Repositorio.Contexto;
using System.Linq;

namespace FernandoStore.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(FernandoStoreContexto fernandoStoreContexto) : base(fernandoStoreContexto)
        {

        }

        public Usuario Obter(string email, string senha)
        {
            return FernandoStoreContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return FernandoStoreContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
