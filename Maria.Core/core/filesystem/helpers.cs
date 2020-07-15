namespace Maria
{
    namespace IO
    {
        public static class Helpers
        {
            public static bool isDebugFile(string name)
            {
                return name.Contains(Maria.IO.PostFix.DEBUG_POSTFIX + ".");
            }
        }
    }
}
