namespace BookStoreBO
{
    public class Validator
    {
        public static string IsSearchEntryPresent(string value, string name)
        {
            var msg = "";
            if (value == "")
                msg += $"Enter {name} to search.\n";
            return msg;
        }

        public static string IsPresent(string value, string name)
        {
            var msg = "";
            if (value == "")
                msg += name + " is a required field.\n";
            return msg;
        }
    }
}
