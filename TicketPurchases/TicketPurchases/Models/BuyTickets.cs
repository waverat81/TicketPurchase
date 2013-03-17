using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TicketPurchases.Models
{
    public class BuyTickets
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please choose a band")]
        public string BandName { get; set; }
        [Required(ErrorMessage = "Please enter the amount of tickets you want")]
        public int TicketNumber { get; set; }
    }
}