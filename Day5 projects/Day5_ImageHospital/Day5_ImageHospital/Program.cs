using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_ImageHospital
{
   class Hospital
    {
        public String HospitalID;
        public String HospitalName;
        public String HospitalAddress;
        public String Hospitalcontact;
        public String Hospitallocation;

        public void Addhospitaldetails()
        {

        }
        public void Edithospitaldetails()
        {

        }
        public void Displayhospitaldetails()
        {

        }
        
    }
    class Administration
    {
        public String patientID;
        public String patientName;
        public String patientType;
        public String patientRoomnumber;

        public void Addadministration()
        {

        }
        public void Editadministration()
        {

        }
        public void Deleteadminstration()
        {

        }
        public void Displayadminstrastion()
        {

        }
        class Employees
        {
            public String employeeID;
            public String employeeName;
            public String employeeDesignation;
            private int employeeSalary;

            public void AddEmployeedetails()
            {

            }
            public void EditEmployeedetails()
            {

            }
            public void DeleteEmployeedetails()
            {

            }
            public void DisplayEmployeedetails()
            {

            }
            class pharmacy
            {
                public String pharmacyName;
                public String MedicanName;
                public String Bill;
                public String ContactNumber;

                public void Addpharmacydetails()
                {

                }
                public void EditPharmacydetails()
                { 

                }
                public void Displaypharmacydetails()
                {
                }
                class Rooms
                {
                    public int TotalRoomnumber;
                    public int TotalICURoom;
                    public int TotalGendralwards;
                    public int TotalOperastionTheatre;

                    public void AddRoomsdetails()
                    {

                    }
                    public void EditRoomdetails()
                    {

                    }
                    public void DeleteRoomdetails()
                    {

                    }
                    public void DisplayRoomdetails()
                    {

                    }
                }

            }
            
        }

        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }         }
}
