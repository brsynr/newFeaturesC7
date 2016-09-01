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
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Checks the type.
        /// </summary>
        /// <param name="person">The person.</param>
        static void CheckType(Person person)
        {
            //type check with switch case
            switch (person)
            {
                case Student student:
                    {
                        student.StudentNumber = 117;
                        break;
                    }
                case Teacher teacher:
                    {
                        teacher.TeacherNumber = 1000;
                        break;
                    }
                case null:
                    {
                        throw new ArgumentNullException();
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// Checks the type with if.
        /// </summary>
        /// <param name="person">The person.</param>
        static void CheckTypeWithIf(Person person)
        {
            //Type check with If
            if (person is Teacher teacher)
			{
                teacher.TeacherNumber = 1000;
            }
            if (person is Student student)
			{
                student.StudentNumber = 117;
            }
        }
    }
}
