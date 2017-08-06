using System.Collections.Generic;

namespace TaikPizza.Core.Model
{
    public class PizzaGroup
    {
        public PizzaGroup()
        {
        }

        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public List<Pizza> Pizzas
        {
            get;
            set;
        }
    }
}
