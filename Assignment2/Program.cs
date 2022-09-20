/*foreach (var wizard in WizardCollection.Create())
{
    Console.WriteLine(wizard);
}*/

    IEnumerable<int>[] xs = new[] {new[] {1, 2}, new[] {3,4}, new[] {4,5}};

    var result = xs.SelectMany(x => x);

    foreach(var elm in result){
        Console.WriteLine(elm);
    }

    Console.WriteLine(result);


