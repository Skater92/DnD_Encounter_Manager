using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager.Functions
{
    public class SaveFiles
    {
        CurrentFile file1 = new CurrentFile();
        public void PrintSaveMenu()
        {
            Console.WriteLine("Select Option\n=============\n" +
                "\t1)\tView Saves\n" +
                "\t2)\tCreate New Save\n" +
                "\t3)\tReturn to Main Menu\n" +
                "\t4)\tExit Program");
        }
        
        public string RunSaveMenu(string PATH, string BACKUP)
        {
            string userInput = Console.ReadLine();
            string data_File = "";

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    PrintSave(PATH);
                    SelectSave(PATH, BACKUP);
                    break;
                case "2":
                    Console.Clear();
                    CreateNewSave(PATH);
                    break;
                case "3":
                    Console.WriteLine("NON FUNCTIONAL ");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("EXITING");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
            }

            return data_File;
        }
        
        public void PrintSave(string PATH)
        { 
            //Get Files from Save Folder
            List<string> rawfileNames = Directory.GetFiles(PATH).ToList();
            
            //validate that file is JSON before adding to list
            List<string> fileNames = new List<string>();
            foreach (string file in rawfileNames)
            {
                if (file.EndsWith(".json"))
                {
                    fileNames.Add(file);
                }
            }
            
            //Display Files in reverse order
            List<string> printList = Enumerable.Reverse(fileNames).ToList();

            //Print Files
            if(fileNames.Capacity == 0)
            {
                Console.WriteLine("No Files in Folder!");
            }
            else
            {
                int count = 0;
                Console.WriteLine("\tUSER SAVE FILES\n\t===============\n");
                
                foreach (var file in printList)
                {
                    count++;
                    Console.Write($" {count}): ");
                    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                }
                
            }
            
        }

        public string SelectSave(string PATH, string BACKUP)
        {
            Console.WriteLine("\n\n\tSelect Option\n\t=============\n" +
                " 1)\tLoad Save\n" +
                " 2)\tDelete Save\n" +
                " 3)\tBack\n");
            string returnVal = "";
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    try { file1.ACTIVE_FILE = LoadSave(PATH);
                        returnVal = file1.ACTIVE_FILE;
                    }
                    catch (Exception e) { Console.WriteLine(e.Message);
                        SelectSave(PATH, BACKUP);
                    }                   
                    break;
                case "2":
                    Console.Clear();
                    try { DeleteSave(PATH, BACKUP); }
                    catch (Exception e) { Console.WriteLine(e.Message);
                        
                    }
                    break;
                case "3":
                    Console.WriteLine("NON FUNCTIONAL ");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("EXITING");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
            }
            return returnVal;

        }
        
        public string LoadSave(string PATH)
        {
            List<string> fileNames = Directory.GetFiles(PATH).ToList();
            Console.Write("Enter File Name to Load: ");
            string userInput = Console.ReadLine();

            //validate that userInput is a valid file name
            if (fileNames.Contains($"{PATH}\\{userInput}.json"))
            {
                //if nothing is entered throw exception
                if(userInput == null)
                {
                    throw new Exception("NOTHING ENTERED");
                }
                else
                {
                    Console.WriteLine($"\n\nMATCH FOUND! {userInput}.json\n\nLOADING FILE...");
                    Thread.Sleep(1500);
                    return $"{PATH}\\{userInput}.json";
                }
                
            }
            else
            {
                throw new Exception("\n\nInvalid File Name\n\n");
            }            
        }
        
        public void DeleteSave(string PATH, string BACKUP)
        {
            List<string> fileNames = Directory.GetFiles(PATH).ToList();
            Console.Write("Enter File Name to Delete: ");
            string userInput = Console.ReadLine();
            foreach (var file in fileNames)
            {
                if (Path.GetFileNameWithoutExtension(file) == userInput)
                {
                    Console.WriteLine($"Match Found! Save File: {Path.GetFileNameWithoutExtension(file)}");
                    Console.WriteLine("Are you sure you want to delete this save file? [Y/N]");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        //copy file to backup folder
                        File.Copy(file, Path.Combine(BACKUP, Path.GetFileName(file)));
                        //delete file
                        File.Delete(file);
                        Console.WriteLine("Save File Deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Save File Not Deleted!");
                    }
                }
                
            }
        }
        

        public void CreateNewSave(string PATH)
        {
            string saveName = "";
            Console.Write("Save File Name: ");
            saveName = Console.ReadLine();
            Console.WriteLine();
            bool fileExists = File.Exists($"{PATH}\\{saveName}.json");
            if(fileExists)
            {
                Console.WriteLine($"File {saveName} Already Exists!");
            }
            else
            {
                File.Create($"{PATH}\\{saveName}.json");
                Console.WriteLine($"File {saveName} Created!");
                PrintSave(PATH);
            }
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
            
            

        }
       
        
    }
}
