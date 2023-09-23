using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example01.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Rate { get; set; }
    }

    //public class YavuzunCokOzelClassi<T>
    //{
    //    public T ResultI { get; set; }
    //    public List<T> ResultII { get; set; }
    //}
}