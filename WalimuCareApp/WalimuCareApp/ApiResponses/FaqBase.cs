using System;
using System.Collections.Generic;
using System.Text;
using WalimuCareApp.Models;

namespace WalimuCareApp.ApiResponses
{
    public class FaqBase
    {
        public string id { get; set; }
        public string category { get; set; }
        public List<FAQ> faqs { get; set; }
    }
}
