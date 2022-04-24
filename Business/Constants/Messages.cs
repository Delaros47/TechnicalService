using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public enum Proccess
    {
        Add,
        Update,
        Delete,
    }
    public static class Messages
    {
        public static string GetMessage(string formName,Proccess proccess)
        {
            string result = null;
            switch (proccess)
            {
                case Proccess.Add:
                    result = $"A new {formName} has successfully added";
                    break;
                case Proccess.Update:
                    result = $"A new {formName} has successfully updated";
                    break;
                case Proccess.Delete:
                    result = $"A new {formName} has successfully deleted";
                    break;
                default:
                    break;
            }
            return result;

        }


        public static string BankAdded = "A new Bank has successfully added";
        public static string BankUpdated = "Current Bank has successfully updated";
        public static string BankDeleted = "Current Bank has successfully deleted";
               
        public static string ProductAdded = "A new Product has successfully added";
        public static string ProductDeleted = "Current Product has successfully deleted";
        public static string ProductUpdated = "Current Product has successfully updated";
        
        public static string BrandAdded = "A new Brand has successfully added";
        public static string BrandDeleted = "Current Brand has successfully deleted";
        public static string BrandUpdated = "Current Brand has successfully updated";
        
        public static string CategoryAdded = "A new Category has successfully added";
        public static string CategoryDeleted = "Current Category has successfully deleted";
        public static string CategoryUpdated = "Current Category has successfully updated";

        public static string CustomerAdded= "A new Customer has successfully added";
        public static string CustomerDeleted = "Current Customer has successfully deleted";
        public static string CustomerUpdated = "Current Customer has successfully updated";

        public static string CityAdded = "A new City has successfully added";
        public static string CityDeleted = "Current City has successfully deleted";
        public static string CityUpdated = "Current City has successfully updated";

        public static string DepartmentAdded = "A new Department has successfully added";
        public static string DepartmentDeleted = "Current Department has successfully deleted";
        public static string DepartmentUpdated = "Current Department has successfully deleted";
    }
}
