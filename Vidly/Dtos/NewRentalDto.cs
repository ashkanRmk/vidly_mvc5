using System.Collections.Generic;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public List<int> MovieIds { get; set; }

        public int CustomerId { get; set; }
    }
}