using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarAdded = "Araba başarılı bir şekilde eklendi";
        public static string CarPriceInvalid = $"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. ";
        public static string CarDeleted = "Araba başarılı bir şekilde silindi.";
        public static string CarsListed = "Arabalar başarılı bir şekilde listelendi";
        public static string CarUpdated = "Araba başarılı bir şekilde güncellendi";
        public static string BrandNameInvalid = "Marka ismi 2 den fazla harf içermelidir";
        public static string BrandAdded = "Marka başarılı bir şekilde eklendi";
        public static string BrandDeleted = "Marka başarılı bir şekilde silindi";
        public static string BrandUpdated = "Marka başarılı bir şekilde güncellendi";
        public static string ColorAdded = "Renk başarılı bir şekilde eklendi";
        public static string ColorNameInvalid = "Renk ismi 2 den fazla harf içermelidir";
        public static string ColorDeleted = "Renk başarılı bir şekilde silindi";
        public static string ColorUpdated = "Renk başarılı bir şekilde güncellendi";
        public static string CarRented = "Kiralanmış arabayı ekleyemezsin";
        public static string RentalAdded = "Araba başırılı bir şekilde kiralıklara eklendi";
        public static string NoRentals= "Kiralık araba bulunmamaktadır";
        public static string CustomerAdded = "Müşteri başarılı bir şekilde eklendi";
        public static string CustomerIsAlreadyExisting = "Olan bir müşteriyi ekleyemezsin";
        public static string CustomerDeleted = "Müşteri başarılı bir şekilde silindi";
        public static string CustomersListedByCompanyName = "Müşteriler şirket isimlerine göre başırılı bir şekilde listelendi";
        public static string CustomerUpdated = "Müşteri başırılı bir şekilde güncellendi";
        public static string RentalDeleted = "Kiralık araba başırılı bir şekilde silindi";
        public static string RentalUpdated = "Kiralık araba başırılı bir şekilde güncellendi";
        public static string CarIsAlreadyOnRent = "Kiralanmış arabayı tekrar ekleyemezsin";
        public static string UserAdded = "Kullanıcı başırılı bir şekilde eklendi";
        public static string UserValuesCantBeNull = "Kullanıcı özellikleri boş bırakılmaz lütfen kontrol ediniz.";
        public static string UserDeleted = "Kullanıcı başırılı bir şekilde silindi";
        public static string UserUpdated = "Kullanıcı başırılı bir şekilde güncellendi";
        public static string ImageAdded = "Fotoğraf başarılı bir şekilde eklendi";
        public static string ImageDeleted = "Fotoğraf başarılı bir şekilde silindi";
        public static string ImageUpdated = "Fotoğraf başarılı bir şekilde güncellendi";
        public static string ImageLimitReached = "Maksimum fotoğraf sayısına ulaşıldı (5)";
        public static string ImageNotFound = "Fotoğraf bulunamadı";
        public static string ImageDoesNotFound = "Fotoğraf bulunamadı";
        public static string ImageFormatIsNotCorrect = "Kullanılan format yanlış";
        
    }
}
