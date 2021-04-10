using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService //kategori ile ilgli neyi servis etmek istiyorsam yazıyorum.
    {
        IDataResult<List<Category>>GetAll();
        IDataResult<Category> GetById(int categoryId);

    }
}
