/*Console.WriteLine("Hello, World!");
//int j = null;

Nullable<int> i = null;
int? j1 = null;


int k = j1 ?? 0;


//int? nullableResult = i + j; // if you want nullable result then go with this line
//int nonNullableResult = (i + j) ?? 0; // ?? - if it both values are null then result would be "0"

//if you want to check value of nullable type before assign it or access
if (i.HasValue)
{
    Console.WriteLine(i);
}


//value and reference types:

int[] numberss = { 10, 20 };
//object[] objectNumbers = numberss; // not possible to cast int[] to object[]

string[] names = { "A", "B" };
object[] objects = names; // possible to cast string[] to object[], both are reference types
Console.WriteLine(objects[0] + " " + objects[1]);*/

//first, firstordefault
//last, lastordefault
//elementat, elementatordefault
//single, singleordefault,

//aggregate methods - sum, average, max, min, count(longcount), length

//Union, Intersect, Except - will give you all the elements except what you provided in the second array

//Contains - find 
//concat - merge
//distinct - finding unique elements

//Take, TakeWhile, Skip and SkipWhile, --- TakeLast, SkipLast????
int[] numbers = new int[] { 60,70,80,90,10,20,30,40};
// first, firstordefault
var totalSum = numbers.Aggregate((a, b) => a + b);
Console.WriteLine(totalSum);

//{ 10, 20, 30, 40, 50 }
//{ 50, 60}
var concatNumbers = numbers.Concat(new int[] { 50, 60 });
foreach (var item in concatNumbers)
{
    Console.WriteLine(item);
}

//{ 10, 20, 30, 40, 50, 50, 60 }
var numbers2 = new int[] { 60, 70, 80, 90, 100 };

var unionNumbers = concatNumbers.Union(numbers2);
foreach (var item in unionNumbers)
{
    Console.WriteLine(item);
}
//{ 10, 20, 30, 40, 50, 50, 60, 70, 80, 90, 100 }

Console.WriteLine("intersect numbers ========================");

var intersectNumbers = unionNumbers.Intersect(new int[] { 50, 60 });
foreach (var item in intersectNumbers)
{
    Console.WriteLine(item);
}
//output - {50, 60}
var exceptAllNumbers = unionNumbers.Except(new int[] { 50, 60 });
foreach (var item in exceptAllNumbers)
{
    Console.WriteLine(item);
}
//output - {10, 20, 30, 40, 50, 70, 80, 90, 100}

//{ 10, 20, 30, 40, 50 }

var take5 = numbers.Take(5);
foreach (var item in take5)
{
    Console.WriteLine(item);
}

var skipFirst5 = numbers.Skip(5);
foreach (var item in skipFirst5)
{
    Console.WriteLine(item);
}

var rangeArray = Enumerable.Range(1, 1000);
var same5050Times = Enumerable.Repeat(10, 50);
var emptyArray = Enumerable.Empty<int>();

