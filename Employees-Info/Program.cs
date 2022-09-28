Console.WriteLine("Enter The number of newly hires males: ");
string NHM = Console.ReadLine();
Console.WriteLine("Enter The number of newly hires females: ");
string NHF = Console.ReadLine();
Console.WriteLine("Enter the number of permanent position males: ");
string PPM = Console.ReadLine();
Console.WriteLine("Enter the number of permanent position females: ");
string PPF = Console.ReadLine();
Console.WriteLine("Enter the number of resigned males: ");
string RM = Console.ReadLine();
Console.WriteLine("Enter the number of resigned females: ");
string RF = Console.ReadLine();

Console.WriteLine(" ==== ");
Console.WriteLine(" Thank you for the information ");
Console.WriteLine(" ==== ");
Console.WriteLine(" Here is the Summary !!! ");


int totalOfHiredEmployee = (Int16.Parse(NHM) + Int16.Parse(NHF));
int totalOfPermanentEmployee = (Int16.Parse(PPM) + Int16.Parse(PPF));
int totalOfResignedEmployee = (Int16.Parse(RM) + Int16.Parse(RF));
float totalOfMale = (float.Parse(NHM) * 100 / totalOfHiredEmployee);
float totalOfFemale = (float.Parse(NHF) * 100 / totalOfHiredEmployee);
float totalOfPermanentMale = (float.Parse(PPM) * 100 / totalOfHiredEmployee);
float totalOfPermanentFemale = (float.Parse(PPF) * 100 / totalOfHiredEmployee);
float totalOfResignedMale = (float.Parse(RM) * 100 / totalOfHiredEmployee);
float totalOfResignedFemale = (float.Parse(RF) * 100 / totalOfHiredEmployee);


Console.WriteLine("  ");
Console.WriteLine(" Number of hired employee = " + totalOfHiredEmployee);
Console.WriteLine("  ");
Console.WriteLine(" Male = " + Math.Round(totalOfMale, 2, MidpointRounding.ToEven) + "%");
Console.WriteLine(" Female = " + Math.Round(totalOfFemale, 2, MidpointRounding.ToEven) + "%");


Console.WriteLine("  ");
Console.WriteLine(" Number of hired employee = " + totalOfPermanentEmployee);
Console.WriteLine(" Male = " + Math.Round(totalOfPermanentMale, 2, MidpointRounding.ToEven) + "%");
Console.WriteLine(" Female = " + Math.Round(totalOfPermanentFemale, 2, MidpointRounding.ToEven) + "%");


Console.WriteLine("  ");
Console.WriteLine(" Number of hired employee = " + totalOfResignedEmployee);
Console.WriteLine(" Male = " + Math.Round(totalOfResignedMale, 2, MidpointRounding.ToEven) + "%");
Console.WriteLine(" Female = " + Math.Round(totalOfResignedFemale, 2, MidpointRounding.ToEven) + "%");
