using System;
using Xunit;

namespace Nensure.Tests
{
    public sealed class EnsureTests
    {
        [Fact]
        public void Fluency()
        {
            Ensure.NotNull(String.Empty).True(true).False(false);
            Assert.Throws<AssertionException>(() => Ensure.NotNull(null).True(true).False(false));
            Assert.Throws<AssertionException>(() => Ensure.NotNull(String.Empty).True(false).False(false));
            Assert.Throws<AssertionException>(() => Ensure.NotNull(String.Empty).True(true).False(true));
        }

        [Fact]
        public void NotNull()
        {
            string nullString = null;
            DateTime? nullDate = null;
            string notNullString = "not null";

            Assert.Throws<AssertionException>(() => Ensure.NotNull(null));
            Assert.Throws<AssertionException>(() => Ensure.NotNull(string.Empty, null));
            Assert.Throws<AssertionException>(() => Ensure.NotNull(nullString));
            Assert.Throws<AssertionException>(() => Ensure.NotNull(nullString, nullDate));
            Assert.Throws<AssertionException>(() => Ensure.NotNull(notNullString, nullDate));
        }

        [Fact]
        public void NotNullOrWhitespace()
        {
            Ensure.NotNullOrWhitespace("a");
            Ensure.NotNullOrWhitespace("a", "123");

            Assert.Throws<AssertionException>(() => Ensure.NotNullOrWhitespace(string.Empty));
            Assert.Throws<AssertionException>(() => Ensure.NotNullOrWhitespace(" "));
            Assert.Throws<AssertionException>(() => Ensure.NotNullOrWhitespace("1234", " "));
            Assert.Throws<AssertionException>(() => Ensure.NotNullOrWhitespace("1234", " a ", null));
        }

        [Fact]
        public void NotNullOrEmpty()
        {
            Ensure.NotNullOrEmpty("a");
            Ensure.NotNullOrEmpty("a", "123");
            Ensure.NotNullOrEmpty(" ");

            Assert.Throws<AssertionException>(() => Ensure.NotNullOrEmpty(string.Empty));
            Assert.Throws<AssertionException>(() => Ensure.NotNullOrWhitespace("1234", string.Empty));
            Assert.Throws<AssertionException>(() => Ensure.NotNullOrWhitespace("1234", " a ", null));
        }
    }
}