using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public static class Messages
    {
        public static string InvalidName = "Araç adı 2'den az karakter içeremez";
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string InvalidUpdate = "Araç adı 2'den asz karakter içeremez";
        public static string InvalidBrand = "Marka adı 2'den az karakter içermez ";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string UpdateInvalid = "Marka 2'den az karakter içeremez";
        public static string BrandUpdated = "Marka güncellendi";
        public static string InvalidColor = "Renk adı 3'den az karakter içeremez";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDelete = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi";
        public static string CarNotReturned = "Kiralanan araç henüz geri dönmedi";
        public static string ImageLimitError = "Görsel ekelem limiti doldu";
        public static string ImageAdded = "Görsel eklendi";
        public static string ImageUploadError = "Görsel yükleme başarısız";
        public static string UserJWTAdded = "Kullanıcı eklendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı zaten kayıtlı";
        public static string UserRegistered="Kullanıcı eklendi";
        public static string AccessTokenCreated="AccesToken başarıyla oluşturuldu";
        public static string CardAdded="Kart Başarıyla Eklendi";
        public static string CardDeleted="Kart Silindi";
        public static string CardUpdated="Kart Güncellendi";
        public static string CardLengthError="Kart Numaranız Eksik";
    }
}
