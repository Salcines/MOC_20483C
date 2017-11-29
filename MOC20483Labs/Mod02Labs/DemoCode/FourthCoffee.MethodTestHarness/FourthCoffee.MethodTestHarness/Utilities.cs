using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FourthCoffee.MethodTestHarness
{
    public class Utilities
    {
        public Utilities() 
        {
            // TODO: 02: Invoke the Initialize method.
            var isInizalize = Inizalize();
        }

        // TODO: 01: Define the Initialize method.
        bool Inizalize()
        {
            var path = GetApplicationPath();
            return !string.IsNullOrEmpty(path);
        }
        


        #region Helper methods

        string GetApplicationPath()
        {
            return Assembly.GetExecutingAssembly().Location;
        }

        #endregion
    }
}
