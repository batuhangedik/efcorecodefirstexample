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
    /// The Reservation.
    /// </summary>
    public class ReservationDB
    {
        [Key]
        /// <summary>
        /// Reservation Id
        /// </summary>
        public int Id { get; set; }

        
        /// <summary>
        /// Foreign key for the Customer of the Reservation.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Reservation owner 
        /// </summary>
        public CustomerDB Customer { get; set; }

        /// <summary>
        /// Foreign key for the Room of the Reservation.
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// Reserved Room
        /// </summary>
        public RoomDB Room { get; set; }

        /// <summary>
        /// Reservation Checked-in date and time.
        /// </summary>
        public DateTime CheckedInDate { get; set; }

        /// <summary>
        /// Reservation Checked-out date and time.
        /// </summary>
        public DateTime? CheckedOutDate  { get; set; }
    }
}
