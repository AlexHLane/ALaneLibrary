using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALaneLibrary.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DueDate { get; set; }
        public List<string> OnHoldList { get; set; }

    }
}
