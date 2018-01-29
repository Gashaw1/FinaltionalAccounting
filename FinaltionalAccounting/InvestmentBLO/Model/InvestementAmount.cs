using BusinessLayer.Models;

namespace BusinessLayer.Models
{
    internal class InvestementAmount : BusinessOwner
    {
        int InvestementAmountID { get; set; }
        public double amount { get; set; }
    }
}