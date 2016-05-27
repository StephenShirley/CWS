using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Debugging_project.Models
{
    [DebuggerDisplay("dank memes: {otherField}")]
    public class OtherClass
    {
        public int otherField {
            get; set; }

        public string otherStringThing { get; set; }

        public OtherClass() { }

        public OtherClass(int of, string ost)
        {
            otherField = of;
            otherStringThing = ost;
        }
    }
}