using MyProject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class Example1
    {
        private readonly ITestOutputHelper _output;

        public Example1 (ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact(DisplayName ="Usuario tem que ser maior")]
        public void UsuarioEMaiorDeIdade()
        {
            //Arrange
            var user = new User("José", 50);
            var expected = true;
            //Act
            var result = user.MaiorDeIdade();
            _output.WriteLine($"Result: {result}");
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Usuario tem que ser menor")]
        public void UsuarioEMenorDeIdade()
        {
            //Arrange
            var user = new User("João", 17);
            var expected = false;
            //Act
            var result = user.MaiorDeIdade();
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
