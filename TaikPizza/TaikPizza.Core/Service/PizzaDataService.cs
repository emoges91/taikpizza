using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaikPizza.Core.Model;
using TaikPizza.Core.Repository;

namespace TaikPizza.Core.Service
{
  public  class PizzaDataService
    {
        private static PizzaRepository pizzaRepository = new PizzaRepository();

        public PizzaDataService()
        {
        }

        public List<Pizza> GetAllPizzas()
        {
            return pizzaRepository.GetAllPizzas();
        }

        public List<PizzaGroup> GetGroupedPizzas()
        {
            return pizzaRepository.GetGroupedPizzas();
        }

        public List<Pizza> GetPizzasForGroup(int pizzaGroupId)
        {
            return pizzaRepository.GetPizzasForGroup(pizzaGroupId);
        }

        public List<Pizza> GetFavoritePizzas()
        {
            return pizzaRepository.GetFavoritePizzas();
        }

        public Pizza GetPizzaById(int pizzaId)
        {
            return pizzaRepository.GetPizzaById(pizzaId);
        }
    }
}
