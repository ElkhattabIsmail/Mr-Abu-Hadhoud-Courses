using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_BusinessLayer
{
    public class ClsProduct
    {
        public class Products
        {
            private enum Mode { Add, Update }
            private Mode mode;
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }

            public int FK_CategoryID { get; set; }

            public int ProductQuantityInStock { get; set; }
            public string ImageUrl { get; set; }
            public DateTime DateAdded { get; set; }
            public DateTime LastUpdatedDate { get; set; }

            public Products()
            {
                this.ProductID = -1;
                this.ProductName = string.Empty;
                this.Price = 0;
                this.FK_CategoryID = 0;
                this.Description = string.Empty;
                this.ProductQuantityInStock = -1;
                this.ImageUrl = string.Empty;
                this.DateAdded = DateTime.MinValue;
                this.LastUpdatedDate  = DateTime.MinValue;

                mode = Mode.Add;
            }
            private Products(int ProductID, string ProductName, decimal Price, int FK_CategoryID, string Description,
                int ProductQuantityInStock,string ImageUrl, DateTime DateAdded, DateTime LastUpdateDate)
            {
                this.ProductID = ProductID;
                this.ProductName = ProductName;
                this.Price = Price;
                this.FK_CategoryID = FK_CategoryID;
                this.Description = Description;
                this.ProductQuantityInStock = ProductQuantityInStock;
                this.ImageUrl = ImageUrl;
                this.DateAdded = DateAdded;
                this.LastUpdatedDate = LastUpdatedDate;

                mode = Mode.Update;
            }
            private bool _AddNew()
            {
                this.ProductID =
                            ClsProductsData.AddNew(this.ProductName, this.Price, this.FK_CategoryID, this.Description,
                            this.ProductQuantityInStock, this.ImageUrl, this.DateAdded, this.LastUpdatedDate);

                return (this.ProductID != -1);
            }

            private bool _Update()
            {
                return ClsProductsData.Update(this.ProductID, this.ProductName, this.Price, this.FK_CategoryID, this.Description,
                            this.ProductQuantityInStock, this.ImageUrl, this.DateAdded, this.LastUpdatedDate);
            }
            public bool Save()
            {

                switch (mode)
                {
                    case Mode.Add:
                        {
                            mode = Mode.Update;
                            return _AddNew();
                        }
                    case Mode.Update: return _Update();
                }
                return false;
            }
            public static bool IsExist(int ProductID)
            {
                return ClsProductsData.IsExist(ProductID);
            }
            public static bool Delete(int ProductID)
            {
                if (!IsExist(ProductID))
                {
                    return false;
                }
                else { return ClsProductsData.Delete(ProductID); }
            }
            public static DataTable GetAll()
            {
                return ClsProductsData.GetAll();
            }
            public Products Find(int ProductID)
            {

                string ProductName = string.Empty;
                decimal Price = 0;
                int FK_CategoryID = -1;
                string Description = string.Empty;
                int ProductQuantityInStock = 0;
                string ImageUrl = string.Empty;
                DateTime DateAdded = DateTime.MinValue;
                DateTime LastUpdatedDate = DateTime.MinValue;
                if (ClsProductsData.GetProductBYID( ProductID, ref ProductName, ref Price, ref FK_CategoryID, ref Description,
                    ref ProductQuantityInStock ,ref ImageUrl ,ref DateAdded , ref LastUpdatedDate ))
                {
                    return new Products(ProductID, ProductName, Price, FK_CategoryID, Description,ProductQuantityInStock ,
                        ImageUrl ,DateAdded ,LastUpdatedDate );
                }
                return null;
            }
        }


    }
}
