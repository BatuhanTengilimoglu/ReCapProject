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
        internal static string CustomerAdded = "Müşteri başarılı bir şekilde eklendi";
        internal static string CustomerIsAlreadyExisting = "Olan bir müşteriyi ekleyemezsin";
        internal static string CustomerDeleted = "Müşteri başarılı bir şekilde silindi";
        internal static string CustomersListedByCompanyName = "Müşteriler şirket isimlerine göre başırılı bir şekilde listelendi";
        internal static string CustomerUpdated = "Müşteri başırılı bir şekilde güncellendi";
        internal static string RentalDeleted = "Kiralık araba başırılı bir şekilde silindi";
        internal static string RentalUpdated = "Kiralık araba başırılı bir şekilde güncellendi";
        internal static string CarIsAlreadyOnRent = "Kiralanmış arabayı tekrar ekleyemezsin";
        internal static string UserAdded = "Kullanıcı başırılı bir şekilde eklendi";
        internal static string UserValuesCantBeNull = "Kullanıcı özellikleri boş bırakılmaz lütfen kontrol ediniz.";
        internal static string UserDeleted = "Kullanıcı başırılı bir şekilde silindi";
        internal static string UserUpdated = "Kullanıcı başırılı bir şekilde güncellendi";
    }
}
