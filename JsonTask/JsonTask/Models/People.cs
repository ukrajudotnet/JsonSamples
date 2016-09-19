using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTask.Models
{
    public class PeopleViewModel
    {
        public List<People> Male { get; set; }
        public List<People>Female { get; set; }

    }
    public class People
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public string Age { get; set; }


        public List<Pet> Pets { get; set; }

    }

    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

}