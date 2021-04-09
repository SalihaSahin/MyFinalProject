using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//Core katmanı diğer katmanları referans almaz
namespace Core.DataAccess
{
   // generic constraint 
   //class: referans tip
   //IEntity: IEntitiy olabilir veya IEntity in implementleri olabilir
   //new(): newlenebilir olması gerekiyor diyerek Entities içindeki concrete klasörünün içindeki classları seçmemizi sağlar başka bir şey yazınca hata veriri
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

      
    }
}
