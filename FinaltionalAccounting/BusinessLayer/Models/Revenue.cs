using System;

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
        public DateTime dateTimeRevenu { get; set; }    
              
       
    }

    //types of revenu
    public enum RevenuType
    {
        //by providing service
        feesEarnedReevenu = 1,
        //by seal merchandise
        saleRevenu = 2,
        //by rent house
        rentRevenu = 3,
        //by collecting intrest
        interstRevenue = 4
    }
}
