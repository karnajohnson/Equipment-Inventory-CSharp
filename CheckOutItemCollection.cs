/*
 * Karna Johnson
 * CSC 237-040
 * Project #3 
 * Description: Making a collection of items to store in a collection
 *              and to put in a tree view.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace EquipmentInventory
{
    public class CheckOutItemCollection
    {
        //creating a list of checkoutitem
        private List<CheckOutItem> items;
        private int used;

        public CheckOutItemCollection()
        {
            used = 0;
            //instantiating the checkoutitem
            items = new List<CheckOutItem>();
        }
        //Having a method for reading the file
        public void ReadFile()
        {
            //declaring the stream reader
            StreamReader reader;
            //Declaring the record
            string record;
            //Creating a temporary checkoutitem
            CheckOutItem tmpCheck;
            //using a try catch block
            try
            {
                //the reader is a new streamreader
                reader = new StreamReader("Inventory.dat");
                //record is equal to what the reader reads
                
                //While it is not the end of the stream
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    //the temporary checkoutitem is new
                    tmpCheck = new CheckOutItem();
                    //the tmpcheck parses the record
                    tmpCheck.EmpParse(record);
                    //the items that are used are equal to the tmpcheck
                    items.Add(tmpCheck);
                    //items[used++] = tmpCheck;
                    //and the record reads the reader again
                    //record = reader.ReadLine();
                }
                //then the reader closes
                reader.Close();
            }
            //using the catch statement
            catch { }
        }
        //writing a write file
        public void WriteFile()
        {
            //using a try and catch block because something happens almost
            //everytime I exit the program. I try deleting and readding the 
            //inventory.dat file and it sometimes works and then sometimes it doesn't
            //so now I have this try catch block so that the program doesn't blow up
            try
            {
                //having a new streamwriter
                StreamWriter oStream = new StreamWriter("Inventory.dat");
                //using a for loop to get the used and put it into the collection
                for (int i = 0; i < items.Count; ++i)
                {
                    //this was something that James and I did because for a while it 
                    //wasn't working.
                    //So we create a string
                    string buff;
                    //the string equals the items in the record
                    buff = items[i].EmpRecord();
                    //and the stream writes the string
                    oStream.WriteLine(buff);
                }
                //then it closes
                oStream.Close();
            }//don't know why it throws this exception but I catch it
                //I know I am going to get docked for this but I don't know how to fix it
            catch (IOException)
            {
                MessageBox.Show("There seems to be a problem with the inventory.dat file!");
            }
        }
        //writng a add function
        public void Add(CheckOutItem item)
        {
            items.Add(item);
            //needed this because that was most of the problem
            ++used;
        }
        //writing a index with the object function
        public CheckOutItem objectat(int indexIn)
        {   
            return items.ElementAt(indexIn);
        }
        //writing a sort function
        public void sort()
        {
            items.Sort();
        }
        //writng a count function
        public int count()
        {
            int counting = 0;
            counting = items.Count;
            return counting;
        }
    }
}