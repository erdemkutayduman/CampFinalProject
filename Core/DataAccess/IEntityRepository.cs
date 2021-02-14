using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // *****CORE KATMANLARI DİĞER KATMANLARI REFERANS ALMAZ.
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir ya da IEntity'i implemente eden bir nesne olabilir
    // namespace : isim uzayına koyduğumuz isimlere rahat ulaşabilelim diye var.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
