using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Enums
{
    /// <summary>
    /// Customer's current states.
    /// </summary>
    public enum CustomerState
    {
        /// <summary>
        /// Reserved state
        /// </summary>
        Reserved,

        /// <summary>
        /// Checked-in state
        /// </summary>
        CheckedIn,

        /// <summary>
        /// Checked-out
        /// </summary>
        CheckedOut,
    }
}
