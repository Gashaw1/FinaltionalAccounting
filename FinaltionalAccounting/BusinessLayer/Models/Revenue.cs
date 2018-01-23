using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    class Revenue
    {
        //revenu amount
        public double revenuAmount { get; set; }
        //revenu type
        public RevenuType revenuType { get; set; }
        //items
        public string Items { get; set; }        
        public DateTime dateTime { get; set; }
    }
    //types of revenu
    enum RevenuType
    {
        //by providing service
        feesEarnedReevenu,
        //by seal merchandise
        saleRevenu,
        //by rent house
        rentRevenu,
        //by collecting intrest
        interstRevenue
    }
}
