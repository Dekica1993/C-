using HomeworkClass07;

string[] Company = { "Contactor1: Marko", "Contactor2: Ivica",
  "Menager1:Elena", "Menager2:Teo","SalesPerson:Damjan" };

CEO ceoName = new CEO("Dejan","Mladenov",5000);
Console.WriteLine(ceoName.GetInfo());
Console.WriteLine(ceoName.GetSalary());
Console.WriteLine(ceoName.PrintEmployees());



