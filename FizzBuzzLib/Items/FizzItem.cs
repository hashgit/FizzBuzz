namespace FizzBuzzLib.Items
{
    public class FizzItem : IFizzBuzzItem
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return "Fizz";
        }
    }
}