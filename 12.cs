using System;

// KEYWORD - USED TO DEFINE A NAMESPACE
// NAMESPACE : PROVIDES SCOPE FOR IDENTIFIERS WITHIN : USED TO ORGANIZE CODE INTO LOGICAL GROUPS
namespace NamespaceExample // ANY VALID IDENTIFIER
{
    class Program
    {
        static void Main(string[] args)
        {
            // NESTED DICTIONARY - A DICTIONARY (KEY) THAT HAS A VALUE OF ANOTHER DICTIONARY
            Dictionary<string, Dictionary<string, string>> nestedDictionary = new Dictionary<string, Dictionary<string, string>>();

        }
    }
}