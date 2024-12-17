
string fileDirectoryPath = @"C:\\Data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

ReadFromFile(fullFilePath);



static void DisplayDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath))
    {
        //Console.WriteLine($"File{fileName}exists in {fileDirectoryPath}");
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines in the file");
        Console.WriteLine("Do you want to see all lines or pick a random one? all/random");
        string userChoice = Console.ReadLine();

        if(userChoice == "all")
        {
            DisplayDataFromArray(tempArray);
        }
        else if( userChoice == "random")
        {
            DisplayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("Try again.");
        }
        //foreach (string joke in chuckJokes)
        //{
        //    Console.WriteLine(joke);
        //}
        //DisplayDataFromArray(tempArray);
    }
    else
    {
        Console.WriteLine($"File was not found.");
    }

}

static void DisplayRandomElement(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}