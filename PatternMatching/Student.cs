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
    public class Student : Person
	{
        /// <summary>
        /// Gets or sets the student number.
        /// </summary>
        /// <value>
        /// The student number.
        /// </value>
        public int StudentNumber { get; set; }
	}
}
