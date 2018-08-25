using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularWithMvc.Models
{
    public class Data
    {
        public List<Student> GetData()
        {
            var list = new List<Student>();

            list.Add(new Student { Id = 1, Name = "Bob", Address = "123 River Road", Email = "abc@gmail.com" });
            list.Add(new Student { Id = 2, Name = "Sarah", Address = "456 abc Rd", Email = "eee@gmail.com" });
            list.Add(new Student { Id = 3, Name = "Dan", Address = "555 ccc St", Email = "ddd@gmail.com" });
            list.Add(new Student { Id = 4, Name = "Frank", Address = "333 aaa Lane", Email = "xxx@gmail.com" });
            list.Add(new Student { Id = 5, Name = "Ron", Address = "777 ttt Court", Email = "nnn@gmail.com" });
            list.Add(new Student { Id = 6, Name = "Steve", Address = "Unit 555", Email = "mmm@gmail.com" });
            list.Add(new Student { Id = 7, Name = "Sue", Address = "ppp St", Email = "ggg@gmail.com" });
            list.Add(new Student { Id = 8, Name = "Linda", Address = "999 go Lane", Email = "kkk@gmail.com" });

            return list;
        }
    }
}