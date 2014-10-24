namespace FizzBuzzLib.Items
{
    public class BuzzItem : IFizzBuzzItem
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return "Buzz";
        }
    }
}