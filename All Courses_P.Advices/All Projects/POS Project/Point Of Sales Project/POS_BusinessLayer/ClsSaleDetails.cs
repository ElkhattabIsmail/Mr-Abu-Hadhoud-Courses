using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;
namespace POS_BusinessLayer
{
    public class ClsSaleDetails
    {
        public class SaleDetails
        {
            public enum Mode { Add, Update }
            public Mode mode;
            public int SaleID { get; set; }
            public int CustomerID { get; set; }
            public int FK_ProductID { get; set; }
            public int FK_UserID { get; set; }
            public int PaimentMethodID { get; set; }
            public int ProductQuantity { get; set; }
            public DateTime SaleDate { get; set; }

            public SaleDetails()
            {
                this.SaleID = 0;
                this.CustomerID = 0;
                this.FK_ProductID = 0;
                this.FK_UserID = 0;
                this.PaimentMethodID = 0;
                this.ProductQuantity = 0;
                this.SaleDate = DateTime.MinValue;

                mode = Mode.Add;
            }
            private SaleDetails(int SaleID, int CustomerID, int FK_ProductID, int FK_UserID, int PaimentMethodID, int ProductQuantity, DateTime SaleDate)
            {
                this.SaleID = SaleID;
                this.CustomerID = CustomerID;
                this.FK_ProductID = FK_ProductID;
                this.FK_UserID = FK_UserID;
                this.PaimentMethodID = PaimentMethodID;
                this.ProductQuantity = ProductQuantity;
                this.SaleDate = SaleDate;


                mode = Mode.Update;
            }
            private bool _AddNew()
            {
                this.SaleID =
                            ClsSalesDetailsData.AddNew(this.CustomerID, this.FK_ProductID, this.FK_UserID, this.PaimentMethodID, this.ProductQuantity, this.SaleDate);
                return (this.SaleID != -1);
            }

            private bool _Update()
            {
                return ClsSalesDetailsData.Update(this.SaleID, this.CustomerID, this.FK_ProductID, this.FK_UserID, this.PaimentMethodID, this.ProductQuantity, this.SaleDate);
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
            public static bool IsExist(int SaleID)
            {
                return ClsSalesDetailsData.IsExist(SaleID);
            }
            public static bool Delete(int SaleID)
            {
                if (!IsExist(SaleID))
                {
                    return false;
                }
                else { return ClsSalesDetailsData.Delete(SaleID); }
            }
            public static DataTable GetAll()
            {
                return ClsSalesDetailsData.GetAll();
            }
            public SaleDetails Find(int SaleID)
            {
                int CustomerID = -1;
                int FK_ProductID = -1;
                int FK_UserID = -1;
                int PaimentMethodID = -1;
                int ProductQuantity = 0;
                DateTime SaleDate = DateTime.MinValue;

                if (ClsSalesDetailsData.GetPersonBy( SaleID, ref CustomerID, ref FK_ProductID, ref FK_UserID, ref PaimentMethodID, ref ProductQuantity, ref SaleDate))
                {
                    return new SaleDetails(SaleID, CustomerID, FK_ProductID, FK_UserID, PaimentMethodID, ProductQuantity, SaleDate);
                }
                return null;
            }
        }



    }
}
