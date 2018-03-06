namespace Nensure
{
    public static class Ensure
    {
        private static readonly Asserter _instance = new Asserter();

        public static IAsserter True(bool expression)
        {
            return _instance.True(expression);
        }

        public static IAsserter False(bool expression)
        {
            return _instance.False(expression);
        }

        public static IAsserter NotNull(object arg)
        {
            return _instance.NotNull(arg);
        }

        public static IAsserter NotNull(object arg1, object arg2)
        {
            return _instance.NotNull(arg1, arg2);
        }

        public static IAsserter NotNull(object arg1, object arg2, object arg3)
        {
            return _instance.NotNull(arg1, arg2, arg3);
        }

        public static IAsserter NotNull(object arg1, object arg2, object arg3, object arg4)
        {
            return _instance.NotNull(arg1, arg2, arg3, arg4);
        }

        public static IAsserter NotNull(object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            return _instance.NotNull(arg1, arg2, arg3, arg4, arg5);
        }

        public static IAsserter NotNullOrEmpty(string arg)
        {
            return _instance.NotNullOrEmpty(arg);
        }

        public static IAsserter NotNullOrEmpty(string arg1, string arg2)
        {
            return _instance.NotNullOrEmpty(arg1, arg2);
        }

        public static IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3)
        {
            return _instance.NotNullOrEmpty(arg1, arg2, arg3);
        }

        public static IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3, string arg4)
        {
            return _instance.NotNullOrEmpty(arg1, arg2, arg3, arg4);
        }

        public static IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3, string arg4, string arg5)
        {
            return _instance.NotNullOrEmpty(arg1, arg2, arg3, arg4, arg5);
        }

        public static IAsserter NotNullOrWhitespace(string arg)
        {
            return _instance.NotNullOrWhitespace(arg);
        }

        public static IAsserter NotNullOrWhitespace(string arg1, string arg2)
        {
            return _instance.NotNullOrWhitespace(arg1, arg2);
        }

        public static IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3)
        {
            return _instance.NotNullOrWhitespace(arg1, arg2, arg3);
        }

        public static IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3, string arg4)
        {
            return _instance.NotNullOrWhitespace(arg1, arg2, arg3, arg4);
        }

        public static IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3, string arg4, string arg5)
        {
            return _instance.NotNullOrWhitespace(arg1, arg2, arg3, arg4, arg5);
        }
    }
}