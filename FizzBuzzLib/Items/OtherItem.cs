namespace FizzBuzzLib.Items
{
    public class OtherItem : IFizzBuzzItem
    {
        public string Value { get; set; }
        public int Lower { get; set; }
        public int Higher { get; set; }

        public override string ToString()
        {
            return string.Format("Divided {0} by {1}\nDivided {0} by {2}", Value, Lower, Higher);
        }
    }
}