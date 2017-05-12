using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC3.Models
{
    public class Repository
    {
        public Demo GetDemo()
        {
            return new Demo
            {
                Message = "Hello World!!",
                MessageHTML = "<h3>Hello World!!!</h3>"
            };
        }
    }
}