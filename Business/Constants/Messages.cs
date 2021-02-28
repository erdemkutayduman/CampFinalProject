using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError= "Kategoride en fazla 10 adet ürün olabilir.";
        public static string ProductUpdated = "Ürün güncellendi. ";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı.";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError= "Şifre Hatalı";
        public static string SuccessfulLogin = "Hoşgeldiniz.";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
