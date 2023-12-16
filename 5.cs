// prompt user
// prompt user input
// capture user input and return to console
// convert string input to another data type

// LIST - sequential collection of values - hold references to any type

List<string> options = new List<string>();
options.Add("[a]");
options.Add("[b]");
options.Add("[c]");

// 'FOREACH' LOOP - FOR EACH STRING 
// ITERATED OVER FROM WITHIN THE 'OPTIONS' LIST
// EACH STRING IS REFERRED TO AS AN 'OPTION'
foreach (string option in options)
{
    Console.WriteLine(option);
}
