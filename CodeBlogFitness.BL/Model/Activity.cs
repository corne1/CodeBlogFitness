using System;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Activity
    {
        public string Name { get; }
        public double CaloriesPerMinute { get; }

        public Activity(string name, double caloriesPerMin)
        {
            //TODO: CHECK
            Name = name;
            CaloriesPerMinute = caloriesPerMin;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
