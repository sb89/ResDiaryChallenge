// See https://aka.ms/new-console-template for more information


using ResDiaryChallenge.Extensions;

var example = new[] { 1, 2, 3, 4, 5} ;

var results = example.GroupElements(3);

foreach (var result in results)
{
    Console.WriteLine(string.Join(", ", result ));
}
    
