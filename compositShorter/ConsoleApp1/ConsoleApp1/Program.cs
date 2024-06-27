// See https://aka.ms/new-console-template for more information
Employee p1 = new Employee("Maciek", "e1", 10);
Employee p2 = new Employee("Bartek", "e2", 10);
Employee p3 = new Employee("Wojtek", "e3", 10);
Employee p4 = new Employee("Maciek", "e4", 10);

Department d1 = new Department("Departament dodawania", "d1");
Department d2 = new Department("Departament odejmowania", "d2");

d1.Add(p1);
d1.Add(p2);
d1.Add(p3);
d2.Add(p4);

Institute i1 = new Institute("Instytut liczenia", "i1");

i1.Add(d1);
i1.Add(d2);

Chair c1 = new Chair("Katedra matematyki", "c1");

c1.Add(i1);

Faculty f1 = new Faculty("Wydzial matematyki i informatyki", "WMI");
f1.Add(c1);

f1.PrintName();
//Console.WriteLine(f1.GetId());
//Console.WriteLine(f1.GetHoursWorked());



