using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreeCalculator
{
   public class Assessment
    {
        String moduleCode;
        int numberOfAss;
        String assessmentOneType;
        int assessmentOneWeight;
        int assessmentOneValue;
        String assessmentTwoType;
        int assessmentTwoWeight;
        int assessmentTwoValue;
        String assessmentThreeType;
        int assessmentThreeWeight;
        int assessmentThreeValue;
        String assessmentFourType;
        int assessmentFourWeight;
        int assessmentFourValue;
        String assessmentFiveType;
        int assessmentFiveWeight;
        int assessmentFiveValue;

        public Assessment(String aModuleCode, int aNumberOfAss, String aAssessmentOneType, int aAssessmentOneWeight, int aAssessmentOneValue, String aAssessmentTwoType, int aAssessmentTwoWeight, int aAssessmentTwoValue
            , String aAssessmentThreeType, int aAssessmentThreeWeight, int aAssessmentThreeValue, String aAssessmentFourType, int aAssessmentFourWeight, int aAssessmentFourValue, String aAssessmentFiveType, int aAssessmentFiveWeight, int aAssessmentFiveValue)
        {
            moduleCode = aModuleCode;
            assessmentOneType = aAssessmentOneType;
            assessmentOneWeight = aAssessmentOneWeight;
            assessmentOneValue = aAssessmentOneValue;
            assessmentTwoType = aAssessmentTwoType;
            assessmentTwoWeight = aAssessmentTwoWeight;
            assessmentTwoValue = aAssessmentTwoValue;
            assessmentThreeType = aAssessmentThreeType;
            assessmentThreeWeight = aAssessmentThreeWeight;
            assessmentThreeValue = aAssessmentThreeValue;
            assessmentFourType = aAssessmentFourType;
            assessmentFourWeight = aAssessmentFourWeight;
            assessmentFourValue = aAssessmentFourValue;
            assessmentFiveType = aAssessmentFiveType;
            assessmentFiveWeight = aAssessmentFiveWeight;
            assessmentFiveValue = aAssessmentFiveValue;
            numberOfAss = aNumberOfAss;
        }

        public Assessment(String aModuleCode, int aNumberOfAss, String aAssessmentOneType, int aAssessmentOneWeight, int aAssessmentOneValue, String aAssessmentTwoType, int aAssessmentTwoWeight, int aAssessmentTwoValue
             , String aAssessmentThreeType, int aAssessmentThreeWeight, int aAssessmentThreeValue, String aAssessmentFourType, int aAssessmentFourWeight, int aAssessmentFourValue)
        {
            moduleCode = aModuleCode;
            assessmentOneType = aAssessmentOneType;
            assessmentOneWeight = aAssessmentOneWeight;
            assessmentOneValue = aAssessmentOneValue;
            assessmentTwoType = aAssessmentTwoType;
            assessmentTwoWeight = aAssessmentTwoWeight;
            assessmentTwoValue = aAssessmentTwoValue;
            assessmentThreeType = aAssessmentThreeType;
            assessmentThreeWeight = aAssessmentThreeWeight;
            assessmentThreeValue = aAssessmentThreeValue;
            assessmentFourType = aAssessmentFourType;
            assessmentFourWeight = aAssessmentFourWeight;
            assessmentFourValue = aAssessmentFourValue;
            numberOfAss = aNumberOfAss;

        }

        public Assessment(String aModuleCode, int aNumberOfAss, String aAssessmentOneType, int aAssessmentOneWeight, int aAssessmentOneValue, String aAssessmentTwoType, int aAssessmentTwoWeight, int aAssessmentTwoValue
             , String aAssessmentThreeType, int aAssessmentThreeWeight, int aAssessmentThreeValue)
        {
            moduleCode = aModuleCode;
            assessmentOneType = aAssessmentOneType;
            assessmentOneWeight = aAssessmentOneWeight;
            assessmentOneValue = aAssessmentOneValue;
            assessmentTwoType = aAssessmentTwoType;
            assessmentTwoWeight = aAssessmentTwoWeight;
            assessmentTwoValue = aAssessmentTwoValue;
            assessmentThreeType = aAssessmentThreeType;
            assessmentThreeWeight = aAssessmentThreeWeight;
            assessmentThreeValue = aAssessmentThreeValue;
            numberOfAss = aNumberOfAss;


        }

        public Assessment(String aModuleCode, int aNumberOfAss, String aAssessmentOneType, int aAssessmentOneWeight, int aAssessmentOneValue, String aAssessmentTwoType, int aAssessmentTwoWeight, int aAssessmentTwoValue)
        {
            moduleCode = aModuleCode;
            numberOfAss = aNumberOfAss;
            assessmentOneType = aAssessmentOneType;
            assessmentOneWeight = aAssessmentOneWeight;
            assessmentOneValue = aAssessmentOneValue;
            assessmentTwoType = aAssessmentTwoType;
            assessmentTwoWeight = aAssessmentTwoWeight;
            assessmentTwoValue = aAssessmentTwoValue;
        }

        public Assessment(String aModuleCode, int aNumberOfAss, String aAssessmentOneType, int aAssessmentOneWeight, int aAssessmentOneValue)
        {
            moduleCode = aModuleCode;
            assessmentOneType = aAssessmentOneType;
            assessmentOneWeight = aAssessmentOneWeight;
            assessmentOneValue = aAssessmentOneValue;
            numberOfAss = aNumberOfAss;

        }



        public String ModuleCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }

        public int NumberOfAss
        {
            get { return numberOfAss; }
            set { numberOfAss = value; }
        }

        public String AssessmentOneType
        {
            get { return assessmentOneType; }
            set { assessmentOneType = value; }
        }

        public int AssessmentOneWeight
        {
            get { return assessmentOneWeight; }
            set { assessmentOneWeight=value; }
        }

        public int AssessmentOneValue
        {
            get { return assessmentOneValue; }
            set { assessmentOneValue = value; }
        }

        public String AssessmentTwoType
        {
            get { return assessmentOneType; }
            set { assessmentOneType = value; }
        }

        public int AssessmentTwoWeight
        {
            get { return assessmentOneWeight; }
            set { assessmentOneWeight = value; }
        }

        public int AssessmentTwoValue
        {
            get { return assessmentOneValue; }
            set { assessmentOneValue = value; }
        }

        public String AssessmentThreeType
        {
            get { return assessmentOneType; }
            set { assessmentOneType = value; }
        }

        public int AssessmentThreeWeight
        {
            get { return assessmentOneWeight; }
            set { assessmentOneWeight = value; }
        }

        public int AssessmentThreeValue
        {
            get { return assessmentOneValue; }
            set { assessmentOneValue = value; }
        }

        public String AssessmentFourType
        {
            get { return assessmentOneType; }
            set { assessmentOneType = value; }
        }

        public int AssessmentFourWeight
        {
            get { return assessmentOneWeight; }
            set { assessmentOneWeight = value; }
        }

        public int AssessmentFourValue
        {
            get { return assessmentOneValue; }
            set { assessmentOneValue = value; }
        }

        public String AssessmentFiveType
        {
            get { return assessmentOneType; }
            set { assessmentOneType = value; }
        }

        public int AssessmentFiveWeight
        {
            get { return assessmentOneWeight; }
            set { assessmentOneWeight = value; }
        }

        public int AssessmentFiveValue
        {
            get { return assessmentOneValue; }
            set { assessmentOneValue = value; }
        }

    }
}
