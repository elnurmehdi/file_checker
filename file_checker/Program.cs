using System;

namespace file_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            


                Selectcommand:
                Console.WriteLine("Select the language you want to continue:");
                Console.WriteLine("ENG\nRUS\nAZE\n");
                string chooseCommand = Console.ReadLine();
                string[] commands = { "ENG", "eng", "RUS", "rus", "AZE", "aze" };



                if (chooseCommand == commands[0] || chooseCommand == commands[1])
                {
                    Console.WriteLine("Enter your file name:");

                }
                else if (chooseCommand == commands[2] || chooseCommand == commands[3])
                {
                    Console.WriteLine("Введите имя файла:");

                }
                else if (chooseCommand == commands[4] || chooseCommand == commands[5])
                {
                    Console.WriteLine("Faylın adını daxil edin:");

                }
                else
                {
                    Console.WriteLine("Entered language invalid!");

                goto Selectcommand;      

                }


                FileValidator fileValidator = new FileValidator(Console.ReadLine(), ".txt", ".exe", ".xslx");
                Console.WriteLine("Enter file name and get extension :");
                Console.WriteLine(fileValidator.IsExtensionTrue(Console.ReadLine()));

                Console.WriteLine("Available extensions : .txt .exe .xsls");
                Console.WriteLine("Enter file name or extension ");
                Console.WriteLine(fileValidator.FindExtension(Console.ReadLine()));
            }
        
    }
    class FileValidator
    {
        private string[] _extensions;
        private string _fileName;




        public FileValidator(params string[] extensions)

        {
            _extensions = extensions;

        }

        public FileValidator(string fileName, params string[] extensions)
        {
            _fileName = fileName;
            _extensions = extensions;
        }

        public bool IsExtensionTrue(string name)
        {
            string newExtension = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '.')
                {
                    for (int a = i; a < name.Length; a++)
                    {
                        newExtension += name[a];
                    }
                }
            }
            foreach (string extension in _extensions)
            {
                if (extension == newExtension)
                {
                    return true;
                }
            }
            return false;
        }

        public string FindExtension(string name)
        {

            string fullName = _fileName;
            string requiredFileName = "";
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == '.')
                {
                    for (int j = i; j > fullName.Length; j--)
                    {
                        requiredFileName += fullName[j];
                    }
                }
            }

            return fullName;

        }


        public string English()
        {
            return "Enter your file name";
        }
        public string Azerbaijan()
        {
            return "Faylın adını daxil edin";
        }
        public string Russian()
        {
            return "Введите имя файла";
        }



    }
}
