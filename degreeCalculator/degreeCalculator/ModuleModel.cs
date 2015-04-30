using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreeCalculator
{
    public class ModuleModel
    {
            String name;
            String moduleCode;
            int moduleCredits;
            String moduleSemester;
            int numberOfAssessments;
            String moduleLevel;

        public ModuleModel(String aModuleName, String aModuleCode, int aNumberOfAssessments, String aModuleSemester, int aModuleCredits, String aModuleLevel)
        {
            name = aModuleName;
            moduleCode = aModuleCode;
            moduleCredits = aModuleCredits;
            moduleSemester = aModuleSemester;
            numberOfAssessments = aNumberOfAssessments;
            moduleLevel = aModuleLevel;

        }

        public String Name
        {
            get { return name;  }
            set { name = value; }
        }

        public String ModuleCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }

        public int NumberOfAssessments
        {
            get { return numberOfAssessments; }
            set { numberOfAssessments = value; }
        }
        public String ModuleSemester
        {
            get { return moduleSemester; }
            set { moduleSemester = value; }
        }
        public int ModuleCredits
        {
            get { return moduleCredits; }
            set { moduleCredits = value; }
        }

        public String ModuleLevel
        {
            get { return moduleLevel; }
            set { moduleLevel = value; }
        }


    }
}
