using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreeCalculator
{
    public class courseInformation
    {

        public String userFirstName;
        public String userSecondName;
        public String userId;
        public String courseName;

        public String userFirstNameFinal
        {
            get { return userFirstName;}
            set { userFirstName = value; }
        }

        public courseInformation() {

    }   
    }
}
