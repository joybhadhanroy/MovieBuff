using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieBuff.Models;

namespace MovieBuff.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie {get; set;}
        public IEnumerable<Genre> Genres { get; set; }
    }
}