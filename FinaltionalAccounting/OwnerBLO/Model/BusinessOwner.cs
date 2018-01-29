using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BusinessOwner
    {
        protected int BusinessOwnerID { get; set; }

        TypeBusinessOwner ownerType { get; set; }
        //type of business pro
        TypeOfBusiness typeOfBusiness { get; set; }
        //type of investement (cash or credit)
        InvestmentType investementTypes { get; set; }   
        //Investemtn amount       
        protected DateTime dateTime { get; set; }

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
