namespace ConsoleTask2
{
    class program
    {
        static void Main(string[] args )
        {
            string[] Names = { "Kurt", "Kim", "Ali", "Annatte" };
            string[] copy=new string[Names.Length];
            for (int i = 0; i < copy.Length; i++)
           
                copy[i] = Names[i];
            
            Console.WriteLine(copy[0]);
            
        }
    }
}
