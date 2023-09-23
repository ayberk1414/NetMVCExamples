using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example01.Entities
{
    public class Slogan
    {
        public int Id { get; set; }
        public string Sectionname { get; set; }

        public string Title  { get; set; }

        public string Description { get; set; }
    }
}