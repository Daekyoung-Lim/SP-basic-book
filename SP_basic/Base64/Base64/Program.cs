namespace Base64
{
    class Bast64Test
    {
        static void Base64Smaple(String str)
        {
            byte[] byteStr = System.Text.Encoding.UTF8.GetBytes(str);
            string encodedStr;
            byte[] decodeBytes;

            encodedStr = Convert.ToBase64String(byteStr);
            Console.WriteLine(encodedStr);

            decodeBytes = Convert.FromBase64String(encodedStr);
            Console.WriteLine(System.Text.Encoding.Default.GetString(decodeBytes));
        }

        static void Main(String[] args)
        {
            Base64Smaple("This is a Base64 test.");
        }
    }
}