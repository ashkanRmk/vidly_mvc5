using System;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
        public Genre Genre { get; set; }
    }

}