namespace Nensure
{
    public sealed class Asserter : IAsserter
    {
        private static readonly AssertionException TrueException = new AssertionException("Expression is not true.");
        private static readonly AssertionException FalseException = new AssertionException("Expression is not false.");
        private static readonly AssertionException NotNullException = new AssertionException("NotNull assertion failed.");
        private static readonly AssertionException NotNullOrWhitespaceException = new AssertionException("NotNullOrWhitespace assertion failed.");
        private static readonly AssertionException NotNullOrEmptyException = new AssertionException("NotNullOrEmpty assertion failed.");

        public IAsserter True(bool expression)
        {
            if (expression != true)
            {
                throw TrueException;
            }
            return this;
        }

        public IAsserter False(bool expression)
        {
            if (expression != false)
            {
                throw FalseException;
            }
            return this;
        }

        public IAsserter NotNull(object arg)
        {
            if (arg is null)
            {
                throw NotNullException;
            }
            return this;
        }

        public IAsserter NotNull(object arg1, object arg2)
        {
            if (arg1 is null || arg2 is null)
            {
                throw NotNullException;
            }
            return this;
        }

        public IAsserter NotNull(object arg1, object arg2, object arg3)
        {
            if (arg1 is null || arg2 is null || arg3 is null)
            {
                throw NotNullException;
            }
            return this;
        }

        public IAsserter NotNull(object arg1, object arg2, object arg3, object arg4)
        {
            if (arg1 is null || arg2 is null || arg3 is null || arg4 is null)
            {
                throw NotNullException;
            }
            return this;
        }

        public IAsserter NotNull(object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            if (arg1 is null || arg2 is null || arg3 is null || arg4 is null || arg5 is null)
            {
                throw NotNullException;
            }
            return this;
        }

        public IAsserter NotNullOrEmpty(string arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                throw NotNullOrEmptyException;
            }
            return this;
        }

        public IAsserter NotNullOrEmpty(string arg1, string arg2)
        {
            if (string.IsNullOrEmpty(arg1) || string.IsNullOrEmpty(arg2))
            {
                throw NotNullOrEmptyException;
            }
            return this;
        }

        public IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3)
        {
            if (string.IsNullOrEmpty(arg1) || string.IsNullOrEmpty(arg2) || string.IsNullOrEmpty(arg3))
            {
                throw NotNullOrEmptyException;
            }
            return this;
        }

        public IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3, string arg4)
        {
            if (string.IsNullOrEmpty(arg1) || string.IsNullOrEmpty(arg2) || string.IsNullOrEmpty(arg3) || string.IsNullOrEmpty(arg4))
            {
                throw NotNullOrEmptyException;
            }
            return this;
        }

        public IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3, string arg4, string arg5)
        {
            if (string.IsNullOrEmpty(arg1) || string.IsNullOrEmpty(arg2) || string.IsNullOrEmpty(arg3) || string.IsNullOrEmpty(arg4) ||
                string.IsNullOrEmpty(arg5))
            {
                throw NotNullOrEmptyException;
            }
            return this;
        }

        public IAsserter NotNullOrWhitespace(string arg)
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                throw NotNullOrWhitespaceException;
            }
            return this;
        }

        public IAsserter NotNullOrWhitespace(string arg1, string arg2)
        {
            if (string.IsNullOrWhiteSpace(arg1) || string.IsNullOrWhiteSpace(arg2))
            {
                throw NotNullOrWhitespaceException;
            }
            return this;
        }

        public IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3)
        {
            if (string.IsNullOrWhiteSpace(arg1) || string.IsNullOrWhiteSpace(arg2) || string.IsNullOrWhiteSpace(arg3))
            {
                throw NotNullOrWhitespaceException;
            }
            return this;
        }

        public IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3, string arg4)
        {
            if (string.IsNullOrWhiteSpace(arg1) || string.IsNullOrWhiteSpace(arg2) || string.IsNullOrWhiteSpace(arg3)
                || string.IsNullOrWhiteSpace(arg4))
            {
                throw NotNullOrWhitespaceException;
            }
            return this;
        }

        public IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3, string arg4, string arg5)
        {
            if (string.IsNullOrWhiteSpace(arg1) || string.IsNullOrWhiteSpace(arg2) || string.IsNullOrWhiteSpace(arg3)
                || string.IsNullOrWhiteSpace(arg4) || string.IsNullOrWhiteSpace(arg5))
            {
                throw NotNullOrWhitespaceException;
            }
            return this;
        }
    }
}
