using System;

namespace Nensure
{
    [Serializable]
    public sealed class AssertionException : Exception
    {
        public AssertionException()
        {
        }

        public AssertionException(string message) : base(message)
        {
        }

        public AssertionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}