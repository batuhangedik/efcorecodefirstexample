using Database.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Models
{
    /// <summary>
    /// The Customer
    /// </summary>
    public class CustomerDB
    {
        [Key]
        /// <summary>
        /// Customer's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer's Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customer's Surname
        /// </summary>
        public string Surname { get; set; }
        
        /// <summary>
        /// Customer's identity number
        /// </summary>
        public string IdendtityNumber { get; set; }

        /// <summary>
        /// Customer's State
        /// </summary>
        public CustomerState CustomerState { get; set; }
        
        [ForeignKey("CustomerId")]
        /// <summary>
        /// Foreign key for the Reservations of the Customer.
        /// </summary>
        public List<ReservationDB> Reservations { get; set; }

    }
}
