// See https://aka.ms/new-console-template for more information
using zybookInterface;
//qiu li 06-14-2022
Console.WriteLine("Hello, World!");

IPerson employee1 = new Employee();
Console.WriteLine("IPerson");
employee1.SayHello();
employee1.SayGoodbye();

Employee employee2 = new Employee();
Console.WriteLine("Employee");
employee2.SayHello();

ILearner student1 = new Student();
Console.WriteLine("ILearner");
student1.SayHello();
student1.Study("C#");
student1.SayGoodbye();

Student student2 = new Student();
Console.WriteLine("Student");
student2.SayHello();
student2.Study("Interface");





