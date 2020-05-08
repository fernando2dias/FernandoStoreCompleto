using FernandoStore.Dominio.Contracts;
using FernandoStore.Dominio.Entity;
using FernandoStore.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoStore.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(FernandoStoreContexto fernandoStoreContexto) : base(fernandoStoreContexto)
        {
        }
    }
}
