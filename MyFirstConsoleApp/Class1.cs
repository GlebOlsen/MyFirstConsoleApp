using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class Class1
    {
        private string _name;

        public Class1(string name)
        {
            _name = name;
        }
        /// <summary>
        /// Test commit
        /// </summary>

        public string Name 
        { 
            get 
            {
                return _name;
            } 
        }
    }
}
