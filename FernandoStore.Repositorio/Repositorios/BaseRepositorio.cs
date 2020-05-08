using FernandoStore.Dominio.Contracts;
using FernandoStore.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoStore.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity: class{
        protected readonly FernandoStoreContexto FernandoStoreContexto;
        public BaseRepositorio(FernandoStoreContexto fernandoStoreContexto)
        {
            FernandoStoreContexto = fernandoStoreContexto;
        }
        public void Adicionar(TEntity entity)
        {
            FernandoStoreContexto.Set<TEntity>().Add(entity);
            FernandoStoreContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            FernandoStoreContexto.Set<TEntity>().Update(entity);
            FernandoStoreContexto.SaveChanges();
        }

        
        public TEntity ObterPorId(int id)
        {
            return FernandoStoreContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return FernandoStoreContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            FernandoStoreContexto.Remove(entity);
            FernandoStoreContexto.SaveChanges();
        }

        public void Dispose()
        {
            FernandoStoreContexto.Dispose();
        }

    }

    
}
