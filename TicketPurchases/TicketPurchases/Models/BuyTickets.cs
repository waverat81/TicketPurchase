using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketPurchases.Models
{
    public class BuyTickets
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BandName { get; set; }
        public int TicketNumber { get; set; }
    }
}