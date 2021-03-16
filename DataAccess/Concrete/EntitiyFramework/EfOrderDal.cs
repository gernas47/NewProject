using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
