using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            //using (RentACarContext context = new RentACarContext())
            //{
            //    var addedEntity = context.Entry(entity);
            //    addedEntity.State = EntityState.Added;
            //    context.SaveChanges();
            //}
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            //using (RentACarContext context = new RentACarContext())
            //{
            //    var deletedEntity = context.Entry(entity);
            //    deletedEntity.State = EntityState.Deleted;
            //    context.SaveChanges();
            //}
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            //using (RentACarContext context = new RentACarContext())
            //{
            //    return context.Set<Color>().SingleOrDefault(filter);
            //}
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            //using (RentACarContext context = new RentACarContext())
            //{
            //    return filter == null
            //        ? context.Set<Color>().ToList()
            //        : context.Set<Color>().Where(filter).ToList();
            //}
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            //using (RentACarContext context = new RentACarContext())
            //{
            //    var updatedEntity = context.Entry(entity);
            //    updatedEntity.State = EntityState.Modified;
            //    context.SaveChanges();
            //}
            throw new NotImplementedException();
        }
    }
}
