using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid= "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride maximum 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu ürün ismi zaten mevcut.";
        public static string CategoryLimitExceeded="Kategori limiti aşıldığı için yeni ürün eklenemeiyor.";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}
