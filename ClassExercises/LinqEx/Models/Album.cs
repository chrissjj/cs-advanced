﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; }

        public Album() { }

        public Album(int id, int artistId, string name, Genre genre, int year)
        {
            Id = id; ArtistId = artistId; Name = name; Genre = genre; Year = year;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
