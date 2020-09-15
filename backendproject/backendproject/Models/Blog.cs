using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backendproject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public string Link { get; set; }
    }
}
