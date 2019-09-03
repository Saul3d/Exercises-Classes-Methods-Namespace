using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Movies
    {
        public string Name { get; set; }
        public string Genere { get; set; }
        public string Rating { get; set; }
        public float RunTime { get; set; }

        public Movies()
        {
            Name = "Rocky VIII";
            Genere = "Drama";
            Rating = "PG-13";
            RunTime = 105.5f;
        }
        public void GetMovieRating()
        {
            Console.WriteLine($"The rating for {Name} is {Rating}.");
        }
        public void GetMovieRunTime()
        {
            Console.WriteLine($"The run time for {Name} is {RunTime} minutes.");
        }
    }
    
}
