using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int brandId);
    }
}
