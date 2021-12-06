//HashSet Examples

//Unordered collection of elements
//Cannot contain duplicate elements
//Cannot be sorted

//Declare a hash
HashSet<string> myhash1 = new HashSet<string>();

//add to your hash
myhash1.Add("one");
myhash1.Add("two");
myhash1.Add("three");
myhash1.Add("four");
myhash1.Add("five");
myhash1.Add("six");


//List number of items in hashset
Console.WriteLine("Original: " + myhash1.Count());

//Remove an item
myhash1.Remove("six");
Console.WriteLine("With removed item: " + myhash1.Count());

//New hash
HashSet<string> myhash2 = new HashSet<string>();

//add to your hash
myhash2.Add("one");
myhash2.Add("three");
myhash2.Add("five");
myhash2.Add("seven");
myhash2.Add("nine");

//Combine hashsets (Removes duplicates)
//myhash1.UnionWith(myhash2);

//Show items in hashset 1 that are also present in hashset 2
//myhash1.IntersectWith(myhash2);

//Show items in hashset 1 that are NOT present in hashset 2
//myhash1.ExceptWith(myhash2);

foreach (var i in myhash1)
{
    Console.WriteLine(i);
}