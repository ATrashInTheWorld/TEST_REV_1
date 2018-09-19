using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TEST_REV_1.Models
{

    public enum stuff { LOL, OLO, YOLO, COLA};
    public enum stuff2 { LOL2, OLO2, YOLO2, COLA2 };

    public class ModelB
    {

        [Display(Name="FIRST THING")]
        public string s1 { get; set; }
        [Display(Name = "SECOND THING")]
        public string s2 { get; set; }

        public string ans { get; set; }
        public bool ans2 { get; set; }
        public stuff ans3 { get; set; }
        public stuff2 ans4 { get; set; }


        public ModelB(string a, bool aa, stuff aaa, stuff2 aaaa)
        {
            ans = a;
            ans2 = aa;
            ans3 = aaa;
            ans4 = aaaa;
        }

        public ModelB()
        {

        }
    }
}