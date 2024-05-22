// USE AN ARRAY
// a fixed-size collection of elements of the same type
string[] cats = new string[3] { "Rixin", "Harley", "Boots"};
// USE A LIST
List<string> hobbies = new List<string> { "art", "carpentry", "agriculture" };
// USE A DICTIONARY
Dictionary<string, string> puppies = new Dictionary<string, string>
{
    { "Lexy", "minature pinscher" },
    { "Toby", "terrier"}
};
// USE A STACK
Stack<string> browsingHistory = new Stack<string>(new string[] { "Home", "About", "Contact", "Inventory"});
// USE A LINKED LIST
LinkedList<string> friends = new LinkedList<string>(new string[] { "Jane", "Jen", "Jess" });
// USE A HASHSET
List<string> usernames = new List<string> { "LeopardStripes", "TransAmForever", "FirebirdPhoenix", "Germinator89" };
// USE A QUEUE
Queue<string> meals = new Queue<string>(new string[] { "Breakfast", "Lunch", "Dinner" });
// USE A SORTEDSET
SortedSet<DateTime> testDates = new SortedSet<DateTime>
{
    DateTime.Parse("January 14, 2030"),
    DateTime.Parse("October 9, 1998"),
    DateTime.Parse("January 10, 2000")
};
// USE A SORTEDDICTIONARY
SortedDictionary<string, string> doctors = new SortedDictionary<string, string>
{
    { "Appa Banna", "Primary Care" },
    { "Canna Dan", "Dermatology" },
    { "Creder Fee", "Gatroenterology" }
};
// USE A BITARRAY
BitArray featureFlags = new BitArray(new bool[] { false, false, false, true });
// call lists to show data with labels
Console.Write(cats[1]);
Console.Write(hobbies[1]);
Console.Write(puppies[1]);
Console.Write(friends[1]);
Cnosole.Write(doctors[1]);

// DISPLAY ALL DATA IN OBJECTS

// DICTIONARIES NEED TO ITERATE OVER KEY VALUE PAIRS
public static void PrintDictionaryData(object data)
{
    if (data is IDictionary dictionary)
    {
        foreach (DictionaryEntry entry in dictionary)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }
    }
    else
    {
        Console.WriteLine("Invalid data type. Expected a dictionary.");
    }
}

// CALL METHOD TO PRINT ALL ITEMS IN A DICTIONARY EASILY / REUSABLE
PrintDictionaryData(doctors);

// METHOD TO PLACE OBJECTS INTO TO DISPLAY
public static void PrintObjectData(IEnumerable collection)
{
    if (collection is IEnumerable items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine("Invalid data type. Expected a collection.");
    }
}

PrintObjectData(cats);

// CREATE METHOD TO TAKE IN ANY COLLECTION TYPE, WHETHER A SINGLE OBJECT IS PASSED IN OR MULTIPLE
public static void PrintCollectionData(params object[] dataItems)
{
    foreach (var data in dataItems)
    {
        if (data is IDictionary)
        {
            PrintDictionaryData(data);
        }
        else if (data is IEnumerable)
        {
            PrintObjectData(data);
        }
        else
        {
            Console.WriteLine(data);
        }
    }
}