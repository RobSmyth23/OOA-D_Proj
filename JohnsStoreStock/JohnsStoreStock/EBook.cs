using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    // AEIP used, inheritance: EBook inherits from Book. /////////////////////////////////////////
    public class EBook : Book
    {
        private double fileSizeMB; // Random value added on so it's different, set it to whatever you want like 1.3 or 2.7, doesn't mean anything
        private string description;

        public string Description => description;
        public double GetFileSizeMB()
        {
            return fileSizeMB;
        }

        public void SetFileSizeMB(double value)
        {
            fileSizeMB = value;
        }

        public EBook(int id, string title, string author, double fileSizeMB, string description)
            : base(id, title, author, description) // parent constructor call, it calls that then calls this constructor for the fileSizeMB variable
        {
            this.fileSizeMB = fileSizeMB;
            this.description = description;
        }

        // AEIP - Polymorphism: overrides DisplayInfo from Book to include file size from EBook
        public override void displayBookInfo()
        {
            base.displayBookInfo();
            Console.WriteLine("File Size: " + fileSizeMB + " MB");
            Console.WriteLine("Description: " + description);
        }
    }
}
