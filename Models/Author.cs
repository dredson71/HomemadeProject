using System;
using System.Collections.Generic;
namespace Uweek.Models
{
    public class Author
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public DateTime Birthday {get;set;}

        public List<Song> Songs {get;set;}

    }
}