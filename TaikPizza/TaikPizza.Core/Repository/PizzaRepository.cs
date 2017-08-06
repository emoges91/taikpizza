using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TaikPizza.Core.Model;

namespace TaikPizza.Core.Repository
{
    public class PizzaRepository
    {
        string url = "http://taikpizza/api/test/pizzas.json";
        private static List<PizzaGroup> _pizzaGroups = new List<PizzaGroup>();

        public PizzaRepository()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }

        private async Task LoadDataAsync(string url)
        {
            if (_pizzaGroups != null)
            {
                string responseJsonString = null;

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(url);
                        HttpResponseMessage response = await getResponse;

                        responseJsonString = await response.Content.ReadAsStringAsync();
                        _pizzaGroups = JsonConvert.DeserializeObject<List<PizzaGroup>>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        //handle any errors here, not part of the sample app
                        string message = ex.Message;
                    }
                }
            }
        }

        #region methods
        public List<Pizza> GetAllPizzas()
        {
            IEnumerable<Pizza> pizzas =
                from pizzaGroup in _pizzaGroups
                from pizza in pizzaGroup.Pizzas

                select pizza;
            return pizzas.ToList<Pizza>();
        }

        public List<PizzaGroup> GetGroupedPizzas()
        {
            return _pizzaGroups;
        }

        public List<Pizza> GetPizzasForGroup(int pizzaGroupId)
        {
            var group = _pizzaGroups.Where(h => h.Id == pizzaGroupId).FirstOrDefault();

            if (group != null)
            {
                return group.Pizzas;
            }
            return null;
        }

        public List<Pizza> GetFavoritePizzas()
        {
            IEnumerable<Pizza> pizzas =
                from pizzaGroup in _pizzaGroups
                from pizza in pizzaGroup.Pizzas
                where pizza.IsFavorite
                select pizza;

            return pizzas.ToList<Pizza>();
        }

        public Pizza GetPizzaById(int id)
        {
            IEnumerable<Pizza> Pizzas =
                from pizzaGroup in _pizzaGroups
                from pizza in pizzaGroup.Pizzas
                where pizza.Id == id
                select pizza;

            return Pizzas.FirstOrDefault();
        }

        #endregion
    }
}
