using MyProject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyProjectTest
{
    public class Example1
    {
        [Fact]
        public void UsuarioEMaiorDeIdade()
        {
            //Arrange
            var user = new User("José", 50);
            var expected = true;
            //Act
            var result = user.MaiorDeIdade();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
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
