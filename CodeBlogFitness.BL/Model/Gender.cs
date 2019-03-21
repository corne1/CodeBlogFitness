using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Create a new gender.
        /// </summary>
        /// <param name="name">Name of gender.</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя поля не может быть пустым или null", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
