using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PatternMatching.Person" />
    public class Teacher : Person
	{
        /// <summary>
        /// Gets or sets the teacher number.
        /// </summary>
        /// <value>
        /// The teacher number.
        /// </value>
        public int TeacherNumber { get; set; }
	}
}
