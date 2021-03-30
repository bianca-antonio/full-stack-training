using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Builders
{
    public class ConcreteTeacherBuilder : AbstractTeacherBuilder
    {
        protected override void BuildID(Teacher teacher)
        {
            Console.WriteLine("Enter an ID for the teacher");
            var idAsText = Console.ReadLine();
            teacher.ID = int.Parse(idAsText);
        }

        protected override void BuildFirstName(Teacher teacher)
        {
            Console.WriteLine("Enter the first name for the teacher");
            var firstNameAsText = Console.ReadLine();
            teacher.FirstName = firstNameAsText;
        }

        protected override void BuildLastName(Teacher teacher)
        {
            Console.WriteLine("Enter the last name for the teacher");
            var lastNameAsText = Console.ReadLine();
            teacher.LastName = lastNameAsText;
        }
    }
}