using System;

namespace DocfxPropertyRepro
{
    /// <summary>
    /// Class representing a dog.
    /// </summary>
    public class Dog
    {
        /// <summary>
        /// Name of the dog.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Age of the dog.
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of the dog.</param>
        /// <param name="age">Age of the dog.</param>
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
