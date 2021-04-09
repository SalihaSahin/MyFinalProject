using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Token üretecek mekanizmamız User için oluştur ve hangi yetkileri koyacağını söylemelisin oda OperationClaim
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
