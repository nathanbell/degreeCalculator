using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreeCalculator
{
   public class modelViewController
    {

        public List<ModuleModel> moduleData = new List<ModuleModel>();
        public List<Assessment> assessments = new List<Assessment>();
        public mainForm mainView = new mainForm();

        public modelViewController()
        {

        }
        public void setView(mainForm mainView)
        {
            this.mainView = mainView;
        }

      
        public void createModule(String moduleName, String moduleCode, int moduleAssessments, String moduleSemester, int moduleCredits, String moduleLevel)
        {
           
            ModuleModel module = new ModuleModel(moduleName, moduleCode, moduleAssessments, moduleSemester, moduleCredits, moduleLevel);
            moduleData.Add(module);

        }
       
        public ModuleModel getTheModule(int number)
        {
            ModuleModel module;
            module = moduleData[number];
            return module;
        }

       //public void createAssessment(String aModuleCode, int quantity, String aAssessmentOneType, int aAssessmentOneWeight, int aAssessmentOneValue, String aAssessmentTwoType, int aAssessmentTwoWeight, int aAssessmentTwoValue
       //     , String aAssessmentThreeType, int aAssessmentThreeWeight, int aAssessmentThreeValue, String aAssessmentFourType, int aAssessmentFourWeight, int aAssessmentFourValue, String aAssessmentFiveType, int aAssessmentFiveWeight, int aAssessmentFiveValue)
       // {
       //     Assessment assess = new Assessment(aModuleCode, aAssessmentOneType, aAssessmentOneWeight, aAssessmentOneValue, aAssessmentTwoType, aAssessmentTwoWeight, aAssessmentTwoValue, aAssessmentThreeType, aAssessmentThreeWeight, aAssessmentThreeValue, aAssessmentFourType, aAssessmentFourWeight, aAssessmentFourValue, aAssessmentFiveType, aAssessmentFiveWeight, aAssessmentFiveValue);
       //     assessments.Add(assess);
       // }

       //public Assessment getAssessment(int number)
       //{
       //    Assessment assess;
       //    assess = assessments[number];
       //    return assess;
       //}
    }
}
