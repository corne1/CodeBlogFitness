using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// User.
    /// </summary>
    public class User
    {
        #region Properties

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Birthday.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="name"> Name.</param>
        /// <param name="gender"> Gender. </param>
        /// <param name="birthDate"> BirthDay. </param>
        /// <param name="weight"> Weight. </param>
        /// <param name="height"> Height. </param>
        public User(string name,
                    Gender gender,
                    DateTime birthDate, 
                    double weight, double height)
        {
            #region Checking on the Errors
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя поля не может быть пустым или null.", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможное др.", nameof(birthDate));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен 0.", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentNullException("Рост не может быть меньше или равен 0.", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}