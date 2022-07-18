using System.Security.Cryptography.X509Certificates;
using Practice;

internal class Program
{
    private static void Main(string[] args)
    {

        // Console.WriteLine("Hello, World!");
        // int y = 12345;
        // int i = Int32Extensions.Mirror(y);
        // System.Console.WriteLine(i);

        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 7, 8 };


        Employee E1 = new Employee() { ID = 1, Name = "Ayman", Salary = 1300 };
        Employee E2 = new Employee() { ID = 1, Name = "Ayman", Salary = 1300 };

        // System.Console.WriteLine(E1.GetType().Name);
        // System.Console.WriteLine(E1); //To String 

        System.Console.WriteLine("*****************************");
        if (E1.Equals(E2))
        {
            // System.Console.WriteLine("Value EQuals Q1");
        }
        var AnnoyE3 = new { ID = 1, Name = "Ayman", Salary = 1300 };
        var AnnoyE4 = new { ID = 1, Name = "Ayman", Salary = 1300M, NickName = "Aymoon" };
        // 1- the same DT as Long As it us the same Datatype and Sequence.
        //var AnnoyE5 = new { ID = 1, Salary = 1300M, NickName = "Aymoon", Name = "Ayman" };
        // System.Console.WriteLine(AnnoyE5.Equals(AnnoyE4)); false
        // 2- AnnoyE4.Name = "Samir"; //Error

        //System.Console.WriteLine(AnnoyE4.GetType().name);
        // System.Console.WriteLine(AnnoyE4);


    }
    //class Tuple
    public static (int ID, string Name) myFunc()
    {
        //Tuple
        var E = (1, "Hello");
        (int ID, string Name) F = (1, "Hello");
        return F;
    }


}