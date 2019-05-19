using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Storages
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Male { get; set; }
        public string Female { get; set; }
        public string HasJob { get; set; }
        public string HasChildren { get; set; }
        public string HasCar { get; set; }

        public Person()
        {
            Name = "";
            LastName = "";
            Male = "";
            Female = "";
            HasJob = "";
            HasChildren = "";
            HasCar = "";
        }
    }
}