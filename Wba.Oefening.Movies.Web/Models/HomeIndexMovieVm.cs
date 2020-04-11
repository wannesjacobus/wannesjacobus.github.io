using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.Movies.Domain;

namespace Wba.Oefening.Movies.Web.Models
{
    public class HomeIndexMovieVm
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
