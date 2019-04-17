# Nensure
Simple, fluent, lightweight assertion library to create assertion points in your .NET code.

## Sample Usage
```csharp
        // Use Ensure static object each time for each argument assertion
        public void Demonstrate(string url, User user)
        {
            Ensure.NotNullOrEmpty(url).True(url.Contains("http")).False(url.EndsWith("?"));
            Ensure.NotNull(user).True(user.Age > 18).NotNullOrEmpty(user.Name);
        }

        // Use Ensure static object once to validate all arguments
        public void Demonstrate(string url, User user)
        {
            Ensure.NotNullOrEmpty(url).True(url.Contains("http")).False(url.EndsWith("?"))
                  .NotNull(user).True(user.Age > 18).NotNullOrEmpty(user.Name);
        }
```
        
### What happens when the assertion fails?
An instance of `AssertionException` with a meaningful message is thrown if one of the assertions fails, so you have a specific exception
type to catch and handle assertion failures.
