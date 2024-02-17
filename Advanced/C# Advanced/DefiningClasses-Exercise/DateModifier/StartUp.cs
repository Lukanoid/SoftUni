namespace DateModifier
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateCalc = new DateModifier();

            int diff = dateCalc.DateCalculation(firstDate, secondDate);

            Console.WriteLine(Math.Abs(diff));
        }
    }
}
