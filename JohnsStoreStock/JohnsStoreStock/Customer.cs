using LibrarySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnsStoreStock
{
    public class Customer
    {
        // AEIP - Encapsulation: Keep fields private to protect the data.
        private int AccountID;
        private string Name;
        private int Age;
        private string Email;
        public LinkedList<Book> CheckedOutBooks { get; set; } = new LinkedList<Book>();
        public static int booksCheckoutCount = 0;

        public int getCheckoutCount => booksCheckoutCount;

        // Constructor
        public Customer(List<Customer> customerList, string Name, int Age, string Email)
        {
            AccountID = getNextAccountID(customerList);
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
            booksCheckoutCount = 0;
        }

        // Public properties to safely access data (Encapsulation)
        public int getAccountID
        {
            get
            {
                return AccountID;
            }
        }
        public string getName
        {
            get
            {
                return Name;
            }
        }
        public int getAge
        {
            get
            {
                return Age;
            }
        }
        public string getEmail
        {
            get
            {
                return Email;
            }
        }
        public void setAccountID(int accountID)
        {
            this.AccountID = accountID;
        }
        public void setName(string name)
        {
            this.Name = name;
        }

        public void setAge(int age)
        {
            this.Age = age;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public void ShowCheckedOutBooks()
        {
            Console.WriteLine($"{Name}'s Checked Out Books:");
            foreach (var book in CheckedOutBooks)
            {
                //Console.WriteLine(" - " + book.BookID + ", " + book.Name + ", " + book.Author);
            }
        }
        public override string ToString()
        {
            return "";
        }

        public static int getNextAccountID(List<Customer> customerList)
        {
            if(customerList.Count == 0)
            {
                return 1;
            }
            int maxID = customerList.Max(c => c.AccountID);
            return maxID + 1;
        }
    }
}
