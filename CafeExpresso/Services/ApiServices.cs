using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CafeExpresso.Models;
using Newtonsoft.Json;

namespace CafeExpresso.Services
{
    public class ApiServices
    {
        public async Task<List<Menu>> GetMenu()
        {
            //Create HttpClient to call API
            var client = new HttpClient();

            //GET API Call Respponse
            var response = await client.GetStringAsync("https://cafeapi.azurewebsites.net/api/menus");

            //Parse JSON into List of Menu Model Objects
            var menuList = JsonConvert.DeserializeObject<List<Menu>>(response);

            return menuList;
        }

        public async Task<bool> ReserveTable(Reservation reservation)
        {
            //Create HttpClient to call API
            var client = new HttpClient();

            //Serialize Reservation Model parameter into JSONString
            var data = JsonConvert.SerializeObject(reservation);

            //Encode data as JSON
            var json = new StringContent(data, Encoding.UTF8, "application/json");

            //POST reservation to API
            var response = await client.PostAsync("https://cafeapi.azurewebsites.net/api/reservations", json);

            return response.IsSuccessStatusCode;
        }
    }
}
