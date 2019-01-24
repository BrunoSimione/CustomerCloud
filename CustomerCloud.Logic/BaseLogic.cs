using AutoMapper;
using CustomerCloud.Entities;
using CustomerCloud.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Logic
{
    public class BaseLogic<TEntity, TDTO> : ILogic<TDTO> where TEntity : class, IEntity
    {
        private Repository<TEntity> _repo;

        public BaseLogic()
        {
            _repo = new Repository<TEntity>();
        }

        public void Create(TDTO item)
        {
            TEntity entity = Mapper.Map<TEntity>(item);
            _repo.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _repo.Delete(Id);
        }

        public TDTO Read(Guid Id)
        {
            return Mapper.Map<TDTO>(_repo.Read(Id));
        }

        public void Update(TDTO item)
        {
            TEntity entity = Mapper.Map<TEntity>(item);
            _repo.Update(entity);
        }
    }
}
