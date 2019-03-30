﻿using System;


namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Food
    {
        #region Properties
        public string Name { get; }

        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; set; }

        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get; set; }
        
        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории за 100гр продукта.
        /// </summary>
        public double Calories { get; }
        
#endregion

        public Food(string name):this(name, 0,0,0,0) { }
        public Food(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            //TODO: Check;
            Name = name;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
            Calories = calories / 100.0;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
