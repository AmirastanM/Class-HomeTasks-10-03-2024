using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_07_03_2024.Helpers.Exceptions
{
    internal class CustomArgumentNullException :Exception
    {
        private string resultMessage;

        public CustomArgumentNullException(string msj):base(msj)
        {
        
        }

        public CustomArgumentNullException(string parametr, string msj)
        {
            resultMessage = $"Parametr{parametr} , {msj}";
        }
    }
}
