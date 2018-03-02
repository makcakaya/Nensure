namespace Nensure
{
    public class ConnectorResult
    {
        public ConnectorResult True(bool expression)
        {
            if (expression != true)
            {
                throw new AssertionException("Expression is not true.");
            }
            return this;
        }

        public ConnectorResult False(bool expression)
        {
            if (expression != false)
            {
                throw new AssertionException("Expression is not false.");
            }
            return this;
        }
    }
}
