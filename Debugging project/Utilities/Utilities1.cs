using Debugging_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Debugging_project.Utilities
{
    public class Utilities1
    {
        public static int doThings(int a, int b)
        {
            a = 14 * a - 16;
            b = b + 1;
            b = multiplyThings(a, b);
            return a + b;

        }
        public static int multiplyThings(int a, int b)
        {
            return a * b;
        }

        public static List<OtherClass> returnList() {
             List<OtherClass> oClasses = new List<OtherClass>();
   	         for (int i = 0; i < 10; ++i)
    	     {
   	   	         OtherClass oc = new OtherClass(i + 10, "oc" + i);
   	   	         oClasses.Add(oc);
   	   	     }
            return oClasses;
        }

        public static string returnJsonString()
        {
            return "{ 'employees' : [ " +
                   "{ 'firstName':'John' , 'lastName':'Doe' }," +
                   "{ 'firstName':'Anna' , 'lastName':'Smith' }," +
                   "{ 'firstName':'Stephen' , 'lastName':'Surely' } ]}";
        }

    }
}