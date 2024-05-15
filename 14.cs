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
// USE A LINKED LIST
LinkedList<string> friends = new LinkedList<string>(new string[] { "Jane", "Jen", "Jess" });
// USE A HASHSET
// USE A QUEUE
// USE A SORTEDSET
// USE A SORTEDDICTIONARY
SortedDictionary<string, string> doctors = new SortedDictionary<string, string>
{
    { "Appa Banna", "Primary Care" },
    { "Canna Dan", "Dermatology" },
    { "Creder Fee", "Gatroenterology" }
};
// USE A BITARRAY

// call lists to show data with labels
Console.Write(cats[1]);
Console.Write(hobbies[1]);
Console.Write(puppies[1]);
Console.Write(friends[1]);
Cnosole.Write(doctors[1]);

// DISPLAY ALL DATA IN OBJECTS

// DICTIONARIES NEED TO ITERATE OVER KEY VALUE PAIRS
public static void PrintDictionaryData<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
{
    foreach (KeyValuePair<TKey, TValue> pair in dictionary)
    {
        Console.WriteLine($"{pair.Key} : {pair.Value}");
    }
}

// CALL METHOD TO PRINT ALL ITEMS IN A DICTIONARY EASILY / REUSABLE
PrintDictionaryData(doctors);

// METHOD TO PLACE OBJECTS INTO TO DISPLAY
public static void PrintObjectData<T>(IEnumerable<T> object)
{
    foreach (T item in object)
    {
        Console.WriteLine(item);
    }
}

PrintObjectData(cats);