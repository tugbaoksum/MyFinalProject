using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper //user için token oluştur,ilgili kullanıcı için jwt üretecek.
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
