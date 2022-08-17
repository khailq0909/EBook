using System.Collections.Generic;

namespace EBook.Models
{
    public class RequestCT
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IsApproved { get; set; } = "Pending";
    }
}
