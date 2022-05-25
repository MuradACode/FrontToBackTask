using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackTask.Models
{
    public class Slider : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
