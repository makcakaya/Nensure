namespace Nensure
{
    public sealed class Ensure : ConnectorResult
    {
        public ConnectorResult NotNull(params object[] args)
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
    }
}