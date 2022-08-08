using NamedParameter;

Console.WriteLine("Named Parameters and Optional Arguments");

int result = Arithmetic.Add(10, 20);

int resultForOptionalArgument = Arithmetic.Add(20);

int namedParameterResult = Arithmetic.Add(b: 50, a: 25);

Arithmetic.CustomMethod(10, "GL");

int result11 = Arithmetic.CustomMethod(name: "GL", number: 10);


Console.WriteLine(result);
Console.WriteLine(resultForOptionalArgument);


