using System;

namespace BusinessLayer.Models
{
    public class OwnerDrow : BusinessOwner
    {
        int OwnerDrowId { get; set; }
        double drowamount { get; set; }        
        public DateTime dateTime { get; set; }
    }
}