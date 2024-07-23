using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas.Entities.Exceptions
{
    class EmployeeException : ApplicationException
    {
        public EmployeeException(string message) : base(message) {
            
        }
    }
}
