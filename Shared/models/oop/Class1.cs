using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.models.oop
{
    public class Class1
    {   
        public string name { get; set; }
        public int numofbottles { get; set; }
        public int numofvaccinations { get; set; }

        public int calculate(int amount)
        {

          double  remain =  ((numofbottles * amount) - numofvaccinations );
            return remain;
        }




    }
}
