namespace FizzBuzzLib.Items
{
    public class FizzBuzzItem : IFizzBuzzItem
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return "FizzBuzz";
        }
    }
}