using MyProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class Example2
    {
        private readonly ITestOutputHelper _output;

        public Example2(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory(DisplayName ="User fields are filled")]
        [MemberData(nameof(UserList))]
        public void UserFieldHasContent(User user)
        {
            Assert.NotEmpty(user.Username);
            Assert.NotEmpty(user.Email);
            Assert.IsType<User>(user);
        }

        public static IEnumerable<Object[]> UserList => new[]
        {
            new[] { new User { Id = 1, Username = "admin1",Email = "admin1@example.com" }},
            new[] { new User { Id = 2, Username = "user1",Email = "user1@example.com" }},
            new[] { new User { Id = 3, Username = "user2",Email = "user2@example.com" }},
            new[] { new User { Id = 4, Username = "user3",Email = "user3@example.com" }},
        };

        [Theory(DisplayName = "User fields are filled from class")]
        [ClassData(typeof(UserListData))]
        public void UserFieldHasContentClass(User user)
        {
            Assert.NotEmpty(user.Username);
            Assert.NotEmpty(user.Email);
            Assert.IsType<User>(user);
        }

        public class UserListData : IEnumerable<object[]>
        {
            private readonly List<object[]> _data = new List<object[]>
            {
                new[] { new User { Id = 1, Username = "admin1",Email = "admin1@example.com" }},
                new[] { new User { Id = 2, Username = "user1",Email = "user1@example.com" }},
                new[] { new User { Id = 3, Username = "user2",Email = "user2@example.com" }},
                new[] { new User { Id = 4, Username = "user3",Email = "user3@example.com" }},
            };

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }





    }
}
