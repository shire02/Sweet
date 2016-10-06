using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sweet.Models
{
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }

        public int TicketId { get; set; }

        [Required(ErrorMessage = "Please enter your Subject")]
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; private set; }

    }
}