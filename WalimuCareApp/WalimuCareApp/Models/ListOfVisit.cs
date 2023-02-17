using System;
using System.Collections.Generic;
using System.Text;

namespace WalimuCareApp.Models
{
    public class ListOfVisit
    {

        public int auto_id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public long mvcNumber { get; set; }
        public string department { get; set; }
        public string approvalStatus { get; set; }
        public string hospitalName { get; set; }
        public string remarks { get; set; }
        public DateTime mvcDate { get; set; }
    }

}
