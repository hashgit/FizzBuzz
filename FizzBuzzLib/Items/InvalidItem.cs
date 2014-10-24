namespace FizzBuzzLib.Items
{
    public class InvalidItem : IFizzBuzzItem
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return "Invalid Item";
        }
    }
}