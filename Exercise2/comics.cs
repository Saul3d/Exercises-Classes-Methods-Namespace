using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercise2
{
    class Comics
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int IssueNum { get; set; }
        public string Author { get; set; }
        public string Artist { get; set; }
        public string colorist { get; set; }

        public Comics()
        {
            Author = "Jeph Loeb";
            Name = "Ultimates 3";
            IssueNum = 1;
            Artist = "Joe Madureira";
            colorist = "Christian Lichtner";
        }

        public void ReadComic()
        {
            Console.WriteLine("Reading this comic");
        }

        public void LookUpAuthor()
        {
            Console.WriteLine($"The author of this comic is {Author}");
        }

        public void LookUpArtist()
        {
            Console.WriteLine($"The artist of {Name}, issue {IssueNum} is {Artist}");
        }
    }
}
