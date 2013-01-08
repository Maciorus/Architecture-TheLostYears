using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostYears.Core.Entities;
using TheLostYears.Core.Entities.Interfaces;

namespace TheLostYears.Core.Repositories
{
    public interface IRepository<T>
        where T: IEntity
    {
        T GetById(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
