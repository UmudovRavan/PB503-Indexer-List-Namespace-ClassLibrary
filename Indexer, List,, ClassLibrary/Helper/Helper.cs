namespace Hel
{
    public static class Helper
    {
        public static string CreateBookCode(string name,int number)
        {
            string bookCode = name.ToUpper().Substring(0, 2);

            bookCode += number.ToString();
            return bookCode;
        }
    }
}
