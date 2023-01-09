using DotNetFrameWork.assesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNetFrameWork.assesment
{

    enum SeverityType { high, medium, low }
    enum CauseType { externalFactors, internalFactors }

    public class Utilities
    {
        internal static string Prompt(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int GetNumber(string question)
        {
            bool processing = false;
            int result;
            do
            {
                Console.WriteLine(question);
                processing = int.TryParse(Console.ReadLine(), out result);
            } while (!processing);
            return result;
        }
    }

    class Disease
    {
        public string DiseaseName { get; set; }
        public string Severity { get; set; }
        public string Cause { get; set; }
        public string SymptomName { get; set; }
        public string Description { get; set; }
    }
    class PatientManager  //Disease
    {
        private Disease[] diseases = null;
        private int _size = 0;

        public PatientManager()
        {
        }

        public PatientManager(int size)
        {
            _size = size;
            diseases = new Disease[_size];
        }
        public void AddDisease(Disease d1)
        {

            for (int i = 0; i < _size; i++)
            {
                diseases[i] = new Disease { DiseaseName = d1.DiseaseName, Cause = d1.Cause, Description = d1.Description, Severity = d1.Severity, SymptomName = d1.SymptomName };
                return;
            }

        }

        public void AddSymptom()
        {

        }

        public void checkPatient()
        {

        }

    }
    class MedicalUI
    {
        public const string menu = "TO ADD DISEASE====>PRESS 1" +
            "\nTO ADD SYMPTOM ====>PRESS 2\n" +
            "TO CHECK PATIENT====>PRESS 3";
        public static PatientManager mgr = null;

        internal static void DisplayMenu()
        {
            int size = Utilities.GetNumber("Enter the Size");
            mgr = new PatientManager(size);
            bool processing = true;

            do
            {
                int choice = Utilities.GetNumber(menu);
                processing = Proces(choice);
            } while (processing);
        }
        private static bool Proces(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddDiseaseHelper();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    return false;
            }
            return true;
        }
        private static void AddDiseaseHelper()
        {
            string name = Utilities.Prompt("enter the disease name");
            string severity = Utilities.Prompt("enter the Severity as(low or medium or high)");
            SeverityType severityType = (SeverityType)Enum.Parse(typeof(SeverityType), severity);
            string cause = Utilities.Prompt("Enter the cause type as( externalFactors or  internalFactors)");
            CauseType causeType = (CauseType)Enum.Parse(typeof(CauseType), cause);
            string symptom = Utilities.Prompt("enter the Symptoms");
            string description = Utilities.Prompt("enter the description");
            Disease dd = new Disease { DiseaseName = name, Cause = cause, Severity = severity, Description = description, SymptomName = symptom };
            mgr.AddDisease(dd);
            Console.WriteLine("Disease details added sucessfully");
            Utilities.Prompt("please enter to clear the screen");
            Console.Clear();
        }
    }
}
    class main11
    {
        static void Main(string[] args)
        {
       MedicalUI.DisplayMenu();



    }
    }

    
