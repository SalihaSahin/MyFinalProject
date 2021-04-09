 using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Kullanıcıya erişim anahtarı vereceimizi yer
   public class AccessToken
    {
        public string Token { get; set; } //kullanıcının erişim anahtarı veiceğimiz değer
        public DateTime Expiration { get; set; } //erişimi bitiş zamanını verdiğimiz değer 
    }
}
