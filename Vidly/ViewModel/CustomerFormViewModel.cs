using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customers Customers { get; set; }

        public string Title
        {
            get
            {
                if (Customers != null && Customers.Id != 0)
                    return "Edit Customer";
                return "New Customer";
            }
        }
    }
}