//1. Iterate and print values
static void PrintListForEach(List<string> MyList)
{
    foreach (string name in MyList)
    {
        Console.WriteLine(name);
    }
}

static void PrintListLoop(List<string> MyList)
{
    for (int i = 0; i < MyList.Count; i++)
    {
        Console.WriteLine(MyList[i]);
    }
}

//The List<T> class provides the ForEach(Action<T>) method to perform specified action on each list element
static void PrintListForEachMethod(List<string> MyList)
{
    MyList.ForEach(name => Console.WriteLine(name));
}

//string.Join() method concatenates the list elements with a provided separator in between
//The seperator is ", " and it will take the values in MyList
static void PrintListStringJoin(List<string> MyList)
{
    Console.WriteLine(string.Join(", ", MyList));
}

List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};

Console.WriteLine("Using foreach Loop");
PrintListForEach(TestStringList);
Console.WriteLine("================");

Console.WriteLine("Using For Loop");
PrintListLoop(TestStringList);
Console.WriteLine("================");

Console.WriteLine("Using ForEach Method");
PrintListForEachMethod(TestStringList);
Console.WriteLine("================");

Console.WriteLine("Using string.Join() Method");
PrintListStringJoin(TestStringList);
Console.WriteLine("================");

//2. Print Sum
static void SumOfNumbers(List<int> IntList)
{
    //Your code here
    int sum = 0;
    foreach(int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);

//3. Find Max
static int FindMax(List<int> IntList)
{
    //Your code here
    int currentMax = 0;
    foreach (int num in IntList)
    {
        if (num > currentMax)
        {
            currentMax = num;
        }
    }
    return currentMax;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

//4. Square the Values - given a List of integers, return the List with all the values squared
static List<int> SquareValues(List<int> IntList)
{
    //Your code here
    List<int> squared = new List<int>();
    foreach (int num in IntList)
    {
        squared.Add(num*num);
    }
    return squared;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
//"[{0}]" sets output to be an array? string.Join concatenates all the elements in TestIntList3
Console.WriteLine("[{0}]", string.Join(", ", SquareValues(TestIntList3)));

//5. Replace negative numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    //Your code here
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
Console.WriteLine("[{0}]", string.Join(", ", NonNegatives(TestIntArray)));

//6. Print Dictionary - given dictionary, print contents of the said dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    // Your code here
    foreach(KeyValuePair<string, string> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//7. Find Key - given a search term, return true or false whether the given term is a key in a dictionary (Hint: figuring this one out may require some research)
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    // Your code here
    return MyDictionary.ContainsKey(SearchTerm);
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

//8. Generate a Dictionary - Given liste of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
    Dictionary<string, int> newDict = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        newDict.Add(Names[i], Numbers[i]);
    }

    return newDict;
}

// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<string> DictNames = new List<string>(){"Julie", "Harold", "James", "Monica"};
List<int> DictNumbers = new List<int>(){6, 12, 7, 10};

foreach (KeyValuePair<string, int> entry in GenerateDictionary(DictNames,DictNumbers))
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
