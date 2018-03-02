namespace Nensure
{
    public sealed class Connector
    {
        public Connector True(bool expression)
        {
            if (expression != true)
            {
                throw new AssertionException("Expression is not true.");
            }
            return this;
        }

        public Connector False(bool expression)
        {
            if (expression != false)
            {
                throw new AssertionException("Expression is not false.");
            }
            return this;
        }

        public Connector NotNull(params object[] args)
        {
            if (args is null)
            {
                throw new AssertionException("NotNull assertion failed.");
            }
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] is null)
                {
                    throw new AssertionException("NotNull assertion failed.");
                }
            }
            return this;
        }

        public Connector NotNullOrWhitespace(params string[] args)
        {
            if (args is null)
            {
                throw new AssertionException("NotNullOrWhitespace assertion failed.");
            }
            for (var i = 0; i < args.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(args[i]))
                {
                    throw new AssertionException("NotNullOrWhitespace assertion failed.");
                }
            }
            return this;
        }

        public Connector NotNullOrEmpty(params string[] args)
        {
            if (args is null)
            {
                throw new AssertionException("NotNullOrEmpty assertion failed.");
            }
            for (var i = 0; i < args.Length; i++)
            {
                if (string.IsNullOrEmpty(args[i]))
                {
                    throw new AssertionException("NotNullOrEmpty assertion failed.");
                }
            }
            return this;
        }
    }
}
