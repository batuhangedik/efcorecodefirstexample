using Database.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Models
{
    /// <summary>
    /// The Employee.
    /// </summary>
    public class EmployeeDB
    {
        /// <summary>
        /// Employee's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Employee's Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Employee's Surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Employee's Salary
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Employee's Department.
        /// </summary>
        public int DepartmentId { get; set; }

    }
}
