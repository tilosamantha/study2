using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LoadData
    {
        string? fileInPath; // path of file to be loaded into app
        string? fileInExtension; // extension/type of file
        bool fileInExists = false; // check to see if file exists
        int linesOfData = 0; // how many lines are input into dictionaries

        List<string> listLines = new List<string>();
        //string[]? splitLines;

        //TopicBank topicBank = new TopicBank();
        //QuestionBank questionBank = new QuestionBank();
        //AnswerBank answerBank = new AnswerBank();

        IDictionary<int, string>? topicBank = new Dictionary<int, string>();
        // IDictionary<int, string>? questionBank = new Dictionary<int, string>();

       public static IDictionary<int, string> questionBank = new Dictionary<int, string>()
        {
            [0] = "A variable defined by a class", //field
            [1] = "Symbols which transform and combine expressions", //operator
            [2] = "Introduces a new class", //clss statement
            [3] = "Data type that returns either true or false" //boolean
        };

        IDictionary<int, string>? answerBank = new Dictionary<int, string>();

        /// <summary>
        /// Prompts the user for a file path to be used for uploading their data into the program.
        /// Checks to see that the file path exists (is correct).
        /// Future option if needed: Can also print out first line of data, or part of data in file 
        /// for user to check and ok before proceeding with the load.
        /// </summary>
        /// <returns>
        /// </returns>
        /// <author>
        /// Jennifer
        /// </author>
        public void getUserFilePath()
        {
            // prompt user for file path and store it as a string, then show path to user
            Console.WriteLine("Enter the file path of the data you want to upload and study:");
            string? userInputFilePath = Console.ReadLine();
            Console.WriteLine("\nYou entered file path: " + userInputFilePath);

            //string? literalUserFilePath = "@" + userInput;
            //Console.WriteLine("Literal user file path: " + literalUserFilePath);
            //Console.WriteLine($"Your literal file path exists: {File.Exists(literalUserFilePath)}");

            // check that the file path is correct and exists, then get the extension of file and show
            // all to user for confirmation
            Console.WriteLine($"Your user input file path exists: {File.Exists(userInputFilePath)}");
            Console.WriteLine($"Your user input file extension is: {Path.GetExtension(userInputFilePath)}");

            // update fields with user input information and checks
            fileInExists = File.Exists(userInputFilePath);
            fileInPath = userInputFilePath;
            fileInExtension = Path.GetExtension(userInputFilePath);
        }

        /// <summary>
        /// Reads and prints the data from the user input file line by line for verification purposes
        /// </summary>
        /// <author>
        /// Jennifer
        /// </author>
        public void printUserFileData()
        {
            // read data from user input file if it exists, else notify them it does not exist
            // should change this at end to a prompt/notification upon input
            Console.WriteLine("\nData read from your input file:");
            Console.WriteLine("-------------------------------");
            if (fileInExists == true)
            {
                StreamReader readerIn = new StreamReader(fileInPath);
                while (readerIn.EndOfStream != true)
                {
                    string? lineRead = readerIn.ReadLine();
                    Console.WriteLine(lineRead);
                    linesOfData++;
                }
            }
            else
            {
                Console.WriteLine("Your file does not exist and therefore can't be read");
            }
        }

        /// <summary>
        /// Reads all lines of data and places them in a List
        /// </summary>
        /// <author>
        /// Jennifer
        /// </author>
        public void userFileDataToList()
        {
            // store lines of data in a List
            listLines = File.ReadAllLines(fileInPath).ToList();

            // print out count of elements in List
            Console.WriteLine("\nLines List length: " + listLines.Count);
            Console.WriteLine("\nData in the List lines:");
            Console.WriteLine("-----------------------");

            // print out each element in the List
            foreach (string line in listLines)
            {
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Splits each line in the list based on the delimiter choosen.
        /// Adds each part to an Array for entry into the Dictionaries afterwards.
        /// </summary>
        /// <author>
        /// Jennifer
        /// </author>
        public void splitListToArray()
        {
            Console.WriteLine("\nLines of data: " + linesOfData);
            string?[] dataForEntry = new string[linesOfData * 3];

            int i = 0;

            // creates an Array of the split strings for each line/entry in the List
            // this will write over the array every time it runs for a line in the List
            foreach (string line in listLines)
            {
                // you can split by comma, forward slash, space, and tab here
                //Console.WriteLine(line);
                //string[]? splitLines = line.Split('/');
                string[]? splitLines = line.Split(',');
                //string[]? splitLines = line.Split(' ');
                //string[]? splitLines = line.Split('\t');

                // adds each Array element into another array element for use in data entry
                Console.WriteLine("Elements in Array SplitLines:");
                foreach (string splitline in splitLines)
                {
                    Console.WriteLine(splitline);
                    dataForEntry[i] = splitline;
                    i++;
                }
            }

            // prints out the elements in the dataForEntry array
            Console.WriteLine("\nElements in Array dataForEntry:");
            foreach (string? data in dataForEntry)
            {
                Console.WriteLine(data);
            }

            // add the elements in the array to the three dictionaries, need multiples of three
            // ***WILL NEED TO REMOVE NULL OR EMPTY STRINGS BECAUSE THEY MESS UP THE DICTIONARY ENTRIES***
            // ***CAN FIGURE THIS OUT LATER SOMEHOW**
            int key = 1;
            int topicIndex = 0;
            int questionIndex = 1;
            int answerIndex = 2;

            for (int index = 0; index < dataForEntry.Length;)
            {
                //topicBank.TopicKey = key;
                //topicBank.Topic = dataForEntry[topicIndex];
                //topicIndex += 3;

                //questionBank.QuestionKey = key;
                //questionBank.Question = dataForEntry[questionIndex];
                //questionIndex += 3;

                //answerBank.AnswerKey = key;
                //answerBank.Answer = dataForEntry[answerIndex];
                //answerIndex += 3;
                //key++;
                //index += 3;

                string topicToAdd = dataForEntry[topicIndex];
                topicBank.Add(key, topicToAdd);
                topicIndex += 3;

                string questionToAdd = dataForEntry[questionIndex];
                questionBank.Add(key, questionToAdd);
                questionIndex += 3;

                string answerToAdd = dataForEntry[answerIndex];
                answerBank.Add(key, answerToAdd);
                answerIndex += 3;
                key++;
                index += 3;
            }

            // print out contents of the dictionaries to test
            Console.WriteLine("\nTopic Bank contains:");
            for (int t = 0; t < topicBank.Count; t++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", topicBank.ElementAt(t).Key, topicBank.ElementAt(t).Value);
            }

            //Console.WriteLine("\nSplitLines Array length: " + splitLines.Length);
            //Console.WriteLine("\nData in Array splitLines");
            //Console.WriteLine("------------------------");

            //string[] splitLines;
            //int key = 0;
            //int splitLinesIndex = 0;

            //for (int index = 0; i < splitLines.Length; i++)
            //{
            //    Console.WriteLine(splitLines[index]);
            //}

            //foreach ( string splitLine in splitLines)
            //{
            //    Console.WriteLine($"{splitLine}");
            //}
        }



        public void printAnswerBank(AnswerBank answerBank)
        {
            //foreach (KeyValuePair<int, string> kvpair in answerBank)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", kvpair.Key, kvpair.Value);
            //}

        }

        public void printQuestionBank()
        {

        }

        public void printTopicBank()
        {

        }

    }

    //public void printElementsInSplitLinesArray()
    //{
    //    Console.WriteLine("\nSplitLines Array length: " + splitLines.Length);
    //    Console.WriteLine("\nLines split by comma");
    //    Console.WriteLine("--------------------");

    //    for (int i = 0; i < splitLines.Length; i++)
    //    {
    //        Console.WriteLine("Index: " + i);
    //        Console.WriteLine(splitLines[i]);
    //    }
    //}


    //// enter full path of a file that does exist to be read from and save as a string variable
    //string? fileInPath = @"C:\Users\Siura\source\repos\Jeopardy_ish\Jeopardy_ish\TestSample.txt";

    //// enter full path of file that does not exist and save as a string variable
    //string? fileInPathFake = @"C:\Users\Siura\source\repos\Jeopardy_ish\Jeopardy_ish\TestSamples.txt";
    //string? fileInName = "\"TestSample.txt\"";

    //Console.WriteLine("Real file path: " + fileInPath);
    //Console.WriteLine("Fake file path: " + fileInPathFake);

    //bool fileInExists = File.Exists(fileInPath);
    //Console.WriteLine("Does real file exist: " + fileInExists);

    //bool fileInExistsFake = File.Exists(fileInPathFake);
    //Console.WriteLine("Does fake file exist: " + fileInExistsFake);

    //Console.WriteLine(fileInName);
    //StreamReader readerIn = new StreamReader(fileIn);
    //StreamReader readerIn = new StreamReader("TestSample.txt");

    //while (readerIn.EndOfStream != true)
    //{
    //    lineRead = readerIn.ReadLine();
    //    Console.WriteLine(lineRead);
    //}

    //File.ReadAllLines(fileInPath); // returns array of strings
    //List<string> lines = File.ReadAllLines(fileInPath).ToList(); // returns list of strings

    //foreach (string line in lines)
    //{
    //    Console.WriteLine(line);
    //}



}
