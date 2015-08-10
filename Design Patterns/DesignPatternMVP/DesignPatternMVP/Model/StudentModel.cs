using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternMVP.Model
{
    public class StudentModel
    {
        /// <summary>
        /// creating a student model
        /// describibg business logic
        /// </summary>
        public string Name { get; set; }
        public int Age { get; set;}
        public int Rollno {get; set;}
        public string Branch { get; set; }
    }
}