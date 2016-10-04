/*
 * Karna Johnson
 * CSC 237-040
 * Project 3 - Equipment Inventory
 * Description: This class is designed to get and set the 
 *              employee names.
 *              */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentInventory
{
    public class CheckOutItem : IComparable<CheckOutItem>
    {
        //fields
        private string empSNum;
        private string empFirst;
        private string empLast;
        private string empEmail;
        private string empItemDes;
        private string empTagNum;
        private string empDate;
        public CheckOutItem items;

        public CheckOutItem()
        {
            //declarations
            empSNum = "S00000000";
            empFirst = "Unknown";
            empLast = "Unknown";
            empEmail = "Unknown";
            empItemDes = "Unknown";
            empTagNum = "Unknown";
            empDate = "00/00/0000";
        }

        public CheckOutItem(string empSNumIn, string empFirstIn, string empLastIn,
            string empEmailIn, string empItemIn, string empTagNumIn, string empDateIn)
        {
            empSNum = empSNumIn;
            empFirst = empFirstIn;
            empLast = empLastIn;
            empEmail = empEmailIn;
            empItemDes = empItemIn;
            empTagNum = empTagNumIn;
            empDate = empDateIn;
        }
        //having a parse method for the streamreader
        public void EmpParse(string record)
        {
            int indexSpace = 0;
            string itemInfo = "";
            //if it contains a comma
            if (record.Contains(','))
            {
                //if it contains a colon
                if (record.Contains(':'))
                {
                    //then the record splits it
                    empSNum = record.Split(',')[0];
                    empFirst = record.Split(',')[1];
                    empLast = record.Split(',')[2];
                    empEmail = record.Split(',')[3];
                    itemInfo = record.Split(',')[4];
                    indexSpace = itemInfo.IndexOf(' ');
                    empItemDes = itemInfo.Substring(0, indexSpace - 1);
                    empTagNum = itemInfo.Substring(indexSpace + 1);
                    //empTagNum = record.Split(',')[5];
                    empDate = record.Split(',')[5];
                }
            }  
        }
        //having a method for the streamwriter
        public string EmpRecord()
        {
            //declaring the string
            string record;
            //having it what it should look like
            record = empSNum + "," + empFirst + "," + empLast + "," +
                empEmail  + "," + EmpItem + ": " + empTagNum +"," + empDate +",";
            //then returning it
            return record;       
        }
        //getting and setting the fields
        public string EmpSNum
        {
            get
            {
                return (empSNum);
            }
            set
            {
                empSNum = value;
            }
        }
        public string EmpFirst
        {
            get
            {
                return (empFirst);
            }
            set
            {
                empFirst = value;
            }
        }
        public string EmpLast
        {
            get
            {
                return (empLast);
            }
            set
            {
                empLast = value;
            }
        }
        public string EmpEmail
        {
            get
            {
                return (empEmail);
            }
            set
            {
                empEmail = value;
            }
        }
        public string EmpItem
        {
            get
            {
                return (empItemDes);
            }
            set
            {
                empItemDes = value;
            }
        }
        public string EmpTagNum
        {
            get
            {
                return (empTagNum);
            }
            set
            {
                empTagNum = value;
            }
        }
        public string EmpDate
        {
            get
            {
                return (empDate);
            }
            set
            {
                empDate = value;
            }
        }

        //comparing everything from the S number
        public int CompareTo(CheckOutItem obj)
        {
            return this.empSNum.CompareTo(obj.empSNum);
        }
        

        //making it so that the s number, last name, and first name are together
        public string EmpSNumFirstLast()
        {
            string empSNumFirstLast = "";
            empSNumFirstLast = EmpSNum + ": " + EmpLast + ", " + EmpFirst;
            return (empSNumFirstLast);
        }
        //making it so that the item description and the tag numbers are together
        public string EmpItemTag()
        {
            string empItemTag = "";
            empItemTag = EmpItem + ": " + empTagNum;
            return (empItemTag);
        }

        public static bool operator ==(CheckOutItem emp1, CheckOutItem emp2)
        {
            string empSNum1 = emp1.EmpSNumFirstLast();
            string empSNum2 = emp2.EmpSNumFirstLast();
            if (empSNum1.CompareTo(empSNum2) == 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(CheckOutItem emp1, CheckOutItem emp2)
        {
            return (!(emp1 == emp2));
        }
        public static bool operator >(CheckOutItem emp1, CheckOutItem emp2)
        {
            return ((emp1 < emp2));
        }
        public static bool operator <(CheckOutItem emp1, CheckOutItem emp2)
        {
            return (!(emp1 < emp2));
        }
        public static bool operator <=(CheckOutItem emp1, CheckOutItem emp2)
        {
            return ((emp1 <= emp2));
        }
        public static bool operator >=(CheckOutItem emp1, CheckOutItem emp2)
        {
            return (!(emp1 <= emp2));

        }
    }
}
