using Example01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example01.Extensions
{
    public static class ListExtensions
    {
        //public static void AddDuplicate(this List<Skill> skills, Skill skill)
        //{
        //    skills.Add(skill);
        //    skills.Add(skill);
        //}

        //Repository => GenericRepository= >Generic .. 
        public static void AddDuplicate<T>(this List<T> list, T item) where T : class
        {
            list.Add(item);
            list.Add(item);
        }
    }
}