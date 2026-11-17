using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_BusinessLayer
{
    public  class ClsUser
    {
        public enum Mode { Add, Update }
        public Mode mode;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }

        public ClsUser()
        {
            this.UserID = 0;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Permission = 0;
            this.IsActive = false;
            this.PersonID = 0;

            mode = Mode.Add;
        }
        private ClsUser(int UserID, string UserName, string Password, int Permission, bool IsActive, int PersonID)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
            mode = Mode.Update;
        }
        private bool _AddNew()
        {
            this.UserID =
                        ClsUsersData.AddNew(this.UserName, this.Password, this.Permission, this.IsActive, this.PersonID);
            return (this.UserID != -1);
        }

        private bool _Update()
        {
            return ClsUsersData.Update(this.UserID, this.UserName, this.Password, this.Permission, this.IsActive, this.PersonID);
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
        public static bool IsExist(int UserID)
        {
            return ClsUsersData.Exist(UserID);
        }
        public static bool Delete(int UserID)
        {
            return ClsUsersData.Delete(UserID);
        }
        public static DataTable GetAll()
        {
            return ClsUsersData.GetAll();
        }
        static public ClsUser Find(int UserID)
        
        {
            string UserName = string.Empty;
            string Password = string.Empty;
            int Permission = 0;
            bool IsActive = false;
            int PersonID = -1;

            if (ClsUsersData.GetUserByID(UserID, ref UserName, ref Password, ref Permission, ref IsActive, ref PersonID))
            {
                return new ClsUser(UserID, UserName, Password, Permission, IsActive, PersonID);
            }
            return null;
        }
    }
}
