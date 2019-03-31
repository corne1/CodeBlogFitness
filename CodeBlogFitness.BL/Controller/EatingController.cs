using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlogFitness.BL.Controller
{
    public class EatingController:BaseController
    {
        #region Properties
        private const string FOOD_FILE_NAME = "foods.dat";
        private const string EATINGS_FILE_NAME = "eatings.dat";
        private readonly User user;
        public List<Food> Foods { get; }
        public Eating Eating { get; }
        #endregion
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="user"></param>
        public EatingController(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.", nameof(user));
            Foods = GetAllFoods();
            Eating = GetEatings();
        }

        /// <summary>
        /// Adding Foods
        /// </summary>
        /// <param name="food"></param>
        /// <param name="weight"></param>
        public void Add(Food food, double weight)
        {
            var product = Foods.SingleOrDefault(f => f.Name == food.Name);
            if(product == null)
            {
                Foods.Add(food);
                Eating.Add(food, weight);
                Save(); 
            }
            else
            {
                Eating.Add(product, weight);
                Save();
            }
        }
        private Eating GetEatings()
        {
            return Load<Eating>(EATINGS_FILE_NAME) ?? new Eating(user);
        }

        private List<Food> GetAllFoods()
        {
            return Load<List<Food>>(FOOD_FILE_NAME) ?? new List<Food>();            
        }
        private void Save()
        {
            Save(FOOD_FILE_NAME, Foods);
            Save(EATINGS_FILE_NAME, Eating);    
        }

    }
}
