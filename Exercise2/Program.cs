using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMovieRating = new Movies();
            myMovieRating.GetMovieRating();

            var myMovieRunTime = new Movies();
            myMovieRunTime.GetMovieRunTime();

            var myComic = new Comics();
            myComic.ReadComic();

            var myComicAuthor = new Comics();
            myComicAuthor.LookUpAuthor();

            var myCar = new Cars();
            myCar.start();

            var herCar = new Cars();
            herCar.stop();
        }
    }
}
