using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    class BusinessOwner
    {
        TypeBusinessOwner ownerType;
        //type of business pro
        TypeOfBusiness typeOfBusiness;
        //type of investement (cash or credit)
        InvestmentType types;
        //Investemtn amount
        public double investementAmount { get; set; } 
        public Expense expense { get; set; }
        public Revenue revenue { get; set; }
        public OwnerDrow ownerDrows { get; set; }        
        public DateTime dateTime { get; set; }

    }   
    enum TypeBusinessOwner
    {
        Proprietorship,
        Partnership
    }
    enum InvestmentType
    {
        cash,
        lone
    };
    enum TypeOfBusiness
    {
        ServiceBusinesses,
        MerchandisingBusinesses,
        ManufacturingBusinesses

    }
}
