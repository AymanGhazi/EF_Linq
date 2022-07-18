using System.Security.Cryptography.X509Certificates;
using Practice;

internal class Program
{

    private static void Main(string[] args)
    {
        #region  Fluent Syntax
        //Linq Queries against any Sequence 
        //Sequence : class or struct impliments IEnumerable<T> Interface
        //Local Sequence : in the same stack or Heap -- OBJECT --L2ADO L2XML
        //Remote Sequence : L2SQL L2E
        //Sequnce contains Elements
        List<int> Lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // Input : Sequence  output: the same Sequence 
        List<string> nameList = new List<string>() { "Ayman", "Elsam", "Ahmed", "Lina" };
        //static Function
        var result = Enumerable.Where(Lst, i => i % 2 == 0);
        // Input : Sequence  output: Single Value
        var result2 = Enumerable.SingleOrDefault(Lst, i => i == 1);

        // Input : No input  output: Sequence  ==> Generation Operators
        // range , empty , repeat


        //ExtensionMethod
        var R = Lst.Where(i => i % 2 == 0);
        #endregion

        #region Query Syntax (Expression) SQLLike
        //from is syntax suger
        //for thw 40+ LINQ Operators there are corressponding SQL expressions  (12)
        //start whith from then introduce range variable represent each and every element in the input sequence
        //must end with select or Group by (transformation operator)
        var RR = from i in Lst
                 where i % 2 == 0
                 orderby i descending
                 select i;

        // Most of LINQ , Deffered Execution ==> Every time you want the result (Enumeration or query) it makes query 
        //result is whereListIterator (Decorator) ==> 1. Reference to the List  2.the query Itself
        Lst.Remove(2);
        Lst.AddRange(new int[] { 10, 11, 12, 13, 14 });

        foreach (var item in Lst)
        {
            System.Console.WriteLine(item);
        }

        // Deffered Execution is not used when we cast or use single operator the initial result  (Immediate Execusion)
        var DD = Enumerable.Where(Lst, i => i % 2 == 0).ToList();
        var DD2 = Enumerable.SingleOrDefault(Lst, i => i == 2);



        #endregion




    }


}