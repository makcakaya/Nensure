namespace Nensure
{
    public static class Ensure
    {
        private static readonly Connector _instance = new Connector();

        public static Connector True(bool expression)
        {
            return _instance.True(expression);
        }

        public static Connector False(bool expression)
        {
            return _instance.False(expression);
        }

        public static Connector NotNull(params object[] args)
        {
            return _instance.NotNull(args);
        }

        public static Connector NotNullOrWhitespace(params string[] args)
        {
            return _instance.NotNullOrWhitespace(args);
        }

        public static Connector NotNullOrEmpty(params string[] args)
        {
            return _instance.NotNullOrEmpty(args);
        }
    }
}