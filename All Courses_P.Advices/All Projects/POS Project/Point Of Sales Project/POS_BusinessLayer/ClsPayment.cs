using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_BusinessLayer
{
    class ClsPayment
    {
        public class Payments
        {
            public enum Mode { Add, Update }
            public Mode mode;
            public int PaymentID { get; set; }
            public string PaymentMethod { get; set; }
            public DateTime TransactionDate { get; set; }
            public int SaleID { get; set; }


            public Payments()
            {
                this.PaymentID = 0;
                this.PaymentMethod = string.Empty;
                this.TransactionDate = DateTime.MinValue;
                this.SaleID = -1;

                mode = Mode.Add;
            }
            private Payments(int PaymentID, string PaymentMethod)
            {
                this.PaymentID = PaymentID;
                this.PaymentMethod = PaymentMethod;


                mode = Mode.Update;
            }
            private bool _AddNew()
            {
                this.PaymentID =
                            ClsPaymentsData.AddNew(this.PaymentMethod,this.TransactionDate ,this .SaleID );
                return (this.PaymentID != -1);
            }

            private bool _Update()
            {
                return ClsPaymentsData.Update(this.PaymentID, this.PaymentMethod, this.TransactionDate, this.SaleID);
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
            public static bool IsExist(int PaymentID)
            {
                return ClsPaymentsData.IsExist(PaymentID);
            }
            public static bool Delete(int PaymentID)
            {
                if (!IsExist(PaymentID))
                {
                    return false;
                }
                else { return ClsPaymentsData.Delete(PaymentID); }
            }
            public static DataTable GetAll()
            {
                return ClsPaymentsData.GetAll();
            }
            public Payments Find(int PaymentID)
            {
                string PaymentMethod = string.Empty;
                DateTime TransactionDate = DateTime.MinValue;
                int SaleID = -1;

                if (ClsPaymentsData.GetPersonBy( PaymentID, ref PaymentMethod,ref TransactionDate , ref SaleID ))
                {
                    return new Payments(PaymentID, PaymentMethod);
                }
                return null;
            }
        }


    }
}
