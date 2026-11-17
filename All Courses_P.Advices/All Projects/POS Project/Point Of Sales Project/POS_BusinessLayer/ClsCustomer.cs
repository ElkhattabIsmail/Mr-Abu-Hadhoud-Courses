using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_BusinessLayer
{
    public class ClsCustomer
    {
        public class Customers
        {
            public enum Mode { Add, Update }
            public Mode mode;
            public int CustomerID { get; set; }
            public int PersonID { get; set; }

            public Customers()
            {
                this.CustomerID = 0;
                this.PersonID = 0;

                mode = Mode.Add;
            }
            private Customers(int CustomerID, int PersonID)
            {
                this.CustomerID = CustomerID;
                this.PersonID = PersonID;


                mode = Mode.Update;
            }
            private bool _AddNew()
            {
                this.CustomerID =
                            CustomersData.AddNew(this.PersonID);
                return (this.CustomerID != -1);
            }

            private bool _Update()
            {
                return CustomersData.Update(this.CustomerID, this.PersonID);
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
            public static bool IsExist(int CustomerID)
            {
                return CustomersData.IsExist(CustomerID);
            }
            public static bool Delete(int CustomerID)
            {
                if (!IsExist(CustomerID))
                {
                    return false;
                }
                else { return CustomersData.Delete(CustomerID); }
            }
            public static DataTable GetAll()
            {
                return CustomersData.GetAll();
            }
            public Customers Find(int CustomerID)
            {
                int PersonID = -1;

                if (CustomersData.GetPersonBy( CustomerID, ref PersonID))
                {
                    return new Customers(CustomerID, PersonID);
                }
                return null;
            }
        }


    }
}
