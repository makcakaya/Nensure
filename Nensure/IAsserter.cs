namespace Nensure
{
    public interface IAsserter
    {
        IAsserter True(bool expression);
        IAsserter False(bool expression);

        IAsserter NotNull(object arg);
        IAsserter NotNull(object arg1, object arg2);
        IAsserter NotNull(object arg1, object arg2, object arg3);
        IAsserter NotNull(object arg1, object arg2, object arg3, object arg4);
        IAsserter NotNull(object arg1, object arg2, object arg3, object arg4, object arg5);


        IAsserter NotNullOrEmpty(string arg);
        IAsserter NotNullOrEmpty(string arg1, string arg2);
        IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3);
        IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3, string arg4);
        IAsserter NotNullOrEmpty(string arg1, string arg2, string arg3, string arg4, string arg5);


        IAsserter NotNullOrWhitespace(string arg);
        IAsserter NotNullOrWhitespace(string arg1, string arg2);
        IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3);
        IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3, string arg4);
        IAsserter NotNullOrWhitespace(string arg1, string arg2, string arg3, string arg4, string arg5);
    }
}