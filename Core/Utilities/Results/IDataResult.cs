using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //hangi tipi döndüreceğini yazdık. //Iresulttaki şeyleri tekrar yazmadık!
    {
        T Data { get;  }
    }
}
