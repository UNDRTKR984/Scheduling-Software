using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware
{
    public class ScheduleConflictException : Exception
    {
        // default constructor
        public ScheduleConflictException():base("The appointment time has a conflict with the user or customer's schedule.")
        {

        }

        // cnstructor for customizing error message
        public ScheduleConflictException(string messageValue) : base(messageValue)
        {

        }


    }
}
