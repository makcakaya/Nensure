using System;
using Xunit;

namespace Nensure.Tests
{
    public sealed class EnsureTests
    {
        [Fact]
        public void NotNull()
        {
            string nullString = null;
            DateTime? nullDate = null;
            string notNullString = "not null";

            new Ensure().NotNull(new object[] { });
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(null));
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(string.Empty, null));
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(nullString));
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(nullString, nullDate));
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(notNullString, nullDate));
        }

        [Fact]
        public void Fluency()
        {
            new Ensure().NotNull(String.Empty).True(true).False(false);
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(null).True(true).False(false));
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(String.Empty).True(false).False(false));
            Assert.Throws<AssertionException>(() => new Ensure().NotNull(String.Empty).True(true).False(true));
        }
    }
}
