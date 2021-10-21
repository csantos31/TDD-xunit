using System;

namespace MyProject
{
    public class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        private int MaiorIdade = 18;

        public object MaiorDeIdade()
        {
            if(Age<MaiorIdade)
                return false;

            return true;
        }
    }
}
