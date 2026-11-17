using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_BusinessLayer
{
    public class ClsCategory
    {
        public class Categories
        {
            public enum Mode { Add, Update }
            public Mode mode;
            public int CategoryID { get; set; }
            public string CategoyName { get; set; }

            public Categories()
            {
                this.CategoryID = 0;
                this.CategoyName = string.Empty;

                mode = Mode.Add;
            }
            private Categories(int CategoryID, string CategoyName)
            {
                this.CategoryID = CategoryID;
                this.CategoyName = CategoyName;


                mode = Mode.Update;
            }
            private bool _AddNew()
            {
                this.CategoryID =
                            CategoriesData.AddNew(this.CategoyName);
                return (this.CategoryID != -1);
            }

            private bool _Update()
            {
                return CategoriesData.Update(this.CategoryID, this.CategoyName);
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
            public static bool IsExist(int CategoryID)
            {
                return CategoriesData.IsExist(CategoryID);
            }
            public static bool Delete(int CategoryID)
            {
                if (!IsExist(CategoryID))
                {
                    return false;
                }
                else { return CategoriesData.Delete(CategoryID); }
            }
            public static DataTable GetAll()
            {
                return CategoriesData.GetAll();
            }
            public Categories Find(int CategoryID)
            {
                string CategoyName = string.Empty;

                if (CategoriesData.GetPersonBy( CategoryID, ref CategoyName))
                {
                    return new Categories(CategoryID, CategoyName);
                }
                return null;
            }
        }


    }
}
