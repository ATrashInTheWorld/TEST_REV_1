using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEST_REV_1.Models
{
    public class ModelA
    {
        public virtual string n { get; set; }
        public virtual int nn { get; set; }

        public virtual string res { get; set; } = "RESULTS FROM MODEL";

        public ModelA(string n, int nn)
        {
            this.n = n;
            this.nn = nn;
        }

        public string printAccordingint()
        {
            return n;
        }
    }
}