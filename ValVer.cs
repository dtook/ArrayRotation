using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    //Validation and verification class
    public class ValVer
    {
        public string ValidateInput(string sequence)
        {

            return sequence;
        }

        public string Sequence
        {
            get
            {
                return _sequence;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    //assign value if it is not empty
                    _sequence = value;
                }
                else
                {
                    //throw exception
                }

            }
        }

        private string _sequence;
    }
}
