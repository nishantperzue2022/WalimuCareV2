using System;
using System.Collections.Generic;
using System.Text;

namespace WalimuCareApp.Models
{
    public class root
    {
        public string message { get; set; }
        public List<ListOfVisit> listOfVisits { get; set; }
        public bool status { get; set; }
    }
}
