using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten var";
        public static string CategoryLimitExceded = "Kategori Limiti Doldu";
        public static string AuthorizationDenied="Bu işlemi gerçekleştirmek için yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı Oluşturuldu.";
        public static string PasswordError="Kullanıcı Adı veya Parola Yanlış";
        public static string SuccessfulLogin = "Başarılı Giriş.";
        public static string UserAlreadyExists ="Kullanıcı Adı Önceden Alınmış.";
        public static string AccessTokenCreated = "AccessToken Oluşturuldu.";
        public static string UserNotFound ="Kullanıcı Bulunamadı.";
    }
}
