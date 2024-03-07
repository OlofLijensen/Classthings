using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Properties
{
    public class Media
    {
        // access lvl är internal då vi behöver ha tillgång till attributes när vi inheritar//
        internal int entertainmentLvl;
        internal string howToConsume;

        //voidar func då vi inte har return//
        internal static void Brainrot()
        {
            Console.WriteLine("You are now dumb"); //stringen är vad den är for obv reasons//
        }


    }
    public class Book : Media
    {
        internal int pages;
        //ny upplagan kan ha ett nytt cover//
        internal string Covertype { get; set; }
        internal string title;
        public Book(int pages, string title, int enrtartaimnetLvl, string howToConsume, string Covertype)
        {
            this.pages = pages;
            this.title = title;
            this.howToConsume = howToConsume;
            this.entertainmentLvl = enrtartaimnetLvl;
            this.Covertype = Covertype;
        }

    }

    public class nonFicton : Book
    {
        private string fieldOfstudy;

        //behöver bevisa base constructorn för att visa vad som ska ändras//x
        public nonFicton(int pages, string title, int enrtartaimentLvl, string howToConsume, string Covertype, string fieldOfstudy): base(pages, title, enrtartaimentLvl, howToConsume, Covertype)
        {
            this.fieldOfstudy=fieldOfstudy;
        }
     
    }
}
