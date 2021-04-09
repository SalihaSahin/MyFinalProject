using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //verilen password un salt ve hash değerleri oluşturulur burada
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) //girilen password HCMAC512 algoritmasıyla hashleniyor
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //girilen pasword byte türünden bir değer olan passwordHash e aktarılacağı için  buşekilde byte a çevrilerek passwordHash e aktarılır.
            }
        }
        //burada passwordHash için doğrulama yapılır 
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//kullanılan key nedir onu vermek zorundayız bu yüzden passwordSalt ı veriyoruz
            {
               var computedHash= hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }

                }
                return true;
            }
         
        }
    }
}
