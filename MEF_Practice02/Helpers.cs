namespace MEF_Practice02
{
    public static class Helpers
    {
        public static int ToInt(this string str)
        {
            int.TryParse(str, out var result);
            return result;
        }
    }
}