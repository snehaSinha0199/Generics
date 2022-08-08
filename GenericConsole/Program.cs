using Generics;
using System.Collections;

/*Student student1 = new Student(10,"Student and Int type parameter Generic");
Gen1<int, Student> output2 = new Gen1<int, Student>(10, student1);
Console.WriteLine(output2);
Console.WriteLine(output2.Id +" "+output2.studentName.Name);


Gen1<int, string> output= new Gen1<int, string>(1011,"String and Int type parameter Generic");
Console.WriteLine(output);
Console.WriteLine(output.Id +" "+output.studentName);

Vote<People,int> output3 = new Vote<People,int>();
People people = new People();

output3.eligibility(18);
output3.eligibility(20);*/

Gen1<ISneha> gen1 = new Gen1<ISneha>();
Gen2<ISneha> gen2= new Gen2<ISneha>();
Gen3<amara> gen3out = new Gen3<amara>();
Gen3<palak> gen3out1 = new Gen3<palak>();
//Gen3<aishwariya> gen3out=new Gen3<aishwariya>(); we cant parameter as aishwariya because aishwariya 
//is implementing palak and we defined amara as a Type parameter

//Interface Constraint
public interface ISneha { }
public class Ivaibhav :ISneha{ }
public class Subhash :ISneha{ }

public class Umeed :ISneha{ }

public class Gen1<T> where T:ISneha { }

public class Gen2<T> where T:class { }

//base class constraint
public class amara { }
public class palak : amara { }
public class aishswariya : palak { }

public class Gen3<T> where T : amara { }






