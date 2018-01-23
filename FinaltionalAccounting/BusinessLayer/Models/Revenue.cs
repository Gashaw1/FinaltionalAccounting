using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Revenue : BusinessOwner
    {
        int RevenueID { get; set; }
        //revenu amount
        public double revenuAmount { get; set; }
        //revenu type
        public RevenuType revenuType { get; set; }
        //items
        public string Items { get; set; }
        public DateTime dateTime { get; set; }
    }
    //types of revenu
    public enum RevenuType
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
