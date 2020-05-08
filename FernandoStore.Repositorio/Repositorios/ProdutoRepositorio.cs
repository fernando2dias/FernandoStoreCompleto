using FernandoStore.Dominio.Contracts;
using FernandoStore.Dominio.Entity;
using FernandoStore.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(FernandoStoreContexto fernandoStoreContexto) : base(fernandoStoreContexto)
        {
        }
    }
}
