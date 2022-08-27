using Database.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Models
{
    /// <summary>
    /// The Rooms.
    /// </summary>
    public class RoomDB
    {
        /// <summary>
        /// The room Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The room Number
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// The Room's category
        /// </summary>
        public RoomCategory Category { get; set; }

        [ForeignKey("RoomId")]
        /// <summary>
        /// Foreign key for the Reservations of the Room.
        /// </summary>
        public List<ReservationDB> Reservations { get; set; }
        
    }
}
