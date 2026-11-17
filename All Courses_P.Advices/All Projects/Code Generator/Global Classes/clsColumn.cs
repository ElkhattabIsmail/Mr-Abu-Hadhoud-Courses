using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Classes
{
    public class clsColumn
    {

        private string _columnname;
        public string ColumnName {

            get
            {
                return _columnname.Replace(" ", "");
            }


            set
            {
                _columnname = value;
            }
        }

        public string ColumnType { get; set; }

        public bool IsNullable { get; set; }

        public bool IsPrimaryKey { get; set; }


        public clsColumn(string ColumnName, string ColumnType, bool IsNullable, bool IsPrimaryKey)
        {
            this.ColumnName = ColumnName;
            this.ColumnType = ColumnType;
            this.IsNullable = IsNullable;
            this.IsPrimaryKey = IsPrimaryKey;


        }

        public clsColumn()
        {
            this.ColumnName = default;
            this.ColumnType = default;
            this.IsNullable = false;
            this.IsPrimaryKey = false;
        }


    }
}
