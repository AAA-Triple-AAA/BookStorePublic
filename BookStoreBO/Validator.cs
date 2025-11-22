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
                msg += $"{name} is a required field.\n";
            return msg;
        }

        public static string IsSelected(int selectedIndex, string name)
        {
            var msg = "";
            if (selectedIndex == -1)
                msg += $"{name} is a required field.\n";
            return msg;
        }

        public static string IsMaskCompleted(bool maskCompleted, string name)
        {
            var msg = "";
            if (!maskCompleted)
                msg += $"{name} must be filled completely.\n";
            return msg;
        }

        public static string IsWithinLength(string value, string name, int min, int max)
        {
            var msg = "";
            if (value.Length < min || value.Length > max)
                msg += $"{name} must be within {min} and {max} characters (inclusive).\n";
            return msg;
        }
    }
}
