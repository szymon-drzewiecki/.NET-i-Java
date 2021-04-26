using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace E_library.Models
{
    public class Book
    {
        public int ID { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime releaseDate { get; set; }
        public string Genre { get; set; }
    }
}
