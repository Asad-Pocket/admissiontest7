using Task4;


FormatChecker ch1 = new FormatChecker();

string mobileNumber = Console.ReadLine();

if (ch1.IsValid(mobileNumber)) 
{
    Console.WriteLine("True");

}
else
    Console.WriteLine("False");