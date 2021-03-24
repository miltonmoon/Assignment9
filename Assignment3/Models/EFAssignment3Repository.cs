using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class EFAssignment3Repository : IAssignment3Repository
    {
        private Assignment3DbContext _context;

        public EFAssignment3Repository (Assignment3DbContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }
}
