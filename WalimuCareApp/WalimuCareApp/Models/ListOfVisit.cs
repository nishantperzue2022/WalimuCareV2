using System;
using System.Collections.Generic;
using System.Text;

namespace WalimuCareApp.Models
{
    public class ListOfVisit
    {
        public long mvcNumber { get; set; }
        public int mamberNo { get; set; }
        public DateTime mvcDate { get; set; }
        public string memberName { get; set; }
        public object scheme { get; set; }
        public string department { get; set; }
        public object status { get; set; }
        public string subDepartment { get; set; }
        public string hospital { get; set; }
        public int hospitalCode { get; set; }
        public bool isMvcLocked { get; set; }
        public bool isPreAuthLocked { get; set; }
        public bool isClaimLocked { get; set; }
        public object lockedDate { get; set; }
        public DateTime mvcValidToDate { get; set; }
    }
}
