using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPxGridVIew {
    public class Data {
        public int ID { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string AltImageUrl { get; set; }
    }

    public class DataHelper {
        public static List<Data> GenerateData() {
            return new List<Data>() { 
                new Data() { ID = 0, Description = "Basket/Check", ImageUrl = @"Images/Basket.png", AltImageUrl = @"Images/Check.png"},
                new Data() { ID = 1, Description = "Customer/Folder", ImageUrl = @"Images/Customer.png", AltImageUrl = @"Images/Folder.png"},
                new Data() { ID = 2, Description = "Home/Key", ImageUrl = @"Images/Home.png", AltImageUrl = @"Images/Key.png"},
                new Data() { ID = 3, Description = "Mail/Printing", ImageUrl = @"Images/Mail.png", AltImageUrl = @"Images/Printing.png"}
            };
        }
    }
}