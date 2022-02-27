using DataAcsesslayer.Abstract;
using DataAcsesslayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>,ICategoryDAL
    {

    }
}
