using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customers Customers { get; set; }
    }
}