using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_BusinessLayer
{
    public class ClsPerson
    {
        public enum Mode { Add, Update }
        public Mode mode;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ClsPerson()
        {
            this.PersonID = 0;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.Address = string.Empty;

            mode = Mode.Add;
        }
        private ClsPerson(int PersonID, string FirstName, string LastName, string Phone, string Email, string Address)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;


            mode = Mode.Update;
        }
        private bool _AddNewNewPerson()
        {
            this.PersonID =
                        ClsPeopleData.AddNewNewPerson(this.FirstName, this.LastName, this.Phone, this.Email, this.Address);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return ClsPeopleData.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Phone, this.Email, this.Address);
        }
        public bool Save()
        {

            switch (mode)
            {
                case Mode.Add:
                    {
                        mode = Mode.Update;
                        return _AddNewNewPerson();
                    }
                case Mode.Update: return _UpdatePerson();
            }
            return false;
        }
        public static bool IsExist(int PersonID)
        {
            return ClsPeopleData.IsPersonIsExist(PersonID);
        }
        public static bool Delete(int PersonID)
        {
            if (!IsExist(PersonID))
            {
                return false;
            }
            else { return ClsPeopleData.Delete(PersonID); }
        }
        public static DataTable GetGetAllPeople()
        {
            return ClsPeopleData.GetPersonByGetAllPeopleFromDb();
        }
        static public ClsPerson Find(int PersonID)
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string Address = string.Empty;

            if (ClsPeopleData.GetPersonBy(PersonID, ref FirstName, ref LastName, ref Phone, ref Email, ref Address))
            {
                return new ClsPerson(PersonID, FirstName, LastName, Phone, Email, Address);
            }
            return null;
        }
    }
}
