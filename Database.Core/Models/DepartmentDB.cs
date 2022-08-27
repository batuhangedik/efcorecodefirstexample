using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Models
{
    /// <summary>
    /// The Department of Employee.
    /// </summary>
    public class DepartmentDB
    {
        /// <summary>
        /// Department's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Department's Name
        /// </summary>
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        /// <summary>
        /// Employees of department
        /// </summary>
        public List<EmployeeDB> Employees { get; set; }
    }
}
