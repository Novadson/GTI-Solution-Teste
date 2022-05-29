using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Extensions;
using Newtonsoft.Json;
using Projeto_API.Entities;
using Projeto_API.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GTI_Solution.Controllers
{
    public class HomeController : Controller
    {
        #region GLOBAL VARIABLES
        private const string ApiKey = "";
        private const string ApiUrl = "http://localhost:62681/";
        private readonly IConfiguration _configuration;
        private List<Cliente> ClientsList { get; set; } = new();
        private Cliente Cliente { get; set; } = new Cliente();
        #endregion GLOBAL VARIABLES
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region VIEW INDEX
        public IActionResult Index() => View();
        #endregion VIEW INDEX

        #region VIEW CREATE
        public IActionResult Create() => View();
        #endregion VIEW CREATE

        #region SAVEORUPDATE
        [HttpPost]
        public async Task<IActionResult> SaveOrUpdate(Cliente Cliente)
        {
            var ApiKey = _configuration.GetValue<string>("Credential:ApiKey");

            Cliente = FromTo(Cliente);
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(ApiUrl);
                    StringContent stringContent = new StringContent(JsonConvert.
                        SerializeObject(Cliente), Encoding.UTF8, "application/json");
                    HttpResponseMessage response =
                        await client.PostAsync("ClienteDAO/SaveOrUpdate", stringContent);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(ClientList));
        }
        #endregion SAVEORUPDATE

        #region CLIENTLIST
        public async Task<IActionResult> ClientList()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync($"ClienteDAO/GetListAsync");
                if (response.IsSuccessStatusCode)
                    ClientsList = JsonConvert.DeserializeObject<List<Cliente>>(response.Content.ReadAsStringAsync().Result);
            }
            return View(ClientsList);
        }
        #endregion CLIENTLIST

        #region REMOVE
        public async Task<IActionResult> Remove(Guid IdCliente)
        {
            await DeleteAsync(IdCliente, "/ClienteDAO/Remove?IDCliente=");
            return RedirectToAction(nameof(ClientList));
        }
        #endregion REMOVE

        #region EDIT
        public async Task<IActionResult> Edit(Guid IdCliente)
        {
            Cliente = await GetAsync(IdCliente, "ClienteDAO/GetAsync?IDCliente="); ;
            return View(nameof(Create), Cliente);
        }
        #endregion EDIT

        #region GETASYNC
        public async Task<Cliente> GetAsync(Guid IDClient, string Rota)
        {
            using (HttpClient client = new HttpClient())
            {

                try
                {
                    client.BaseAddress = new Uri(ApiUrl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync($"{Rota}{IDClient}");
                    if (response.IsSuccessStatusCode)
                        Cliente = JsonConvert.DeserializeObject<Cliente>(response.Content.ReadAsStringAsync().Result);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            return Cliente;
        }

        public async Task<Cliente> GetAsyncByCpf(string Cpf, string Rota)
        {
            using (HttpClient client = new())
            {
                try
                {
                    client.BaseAddress = new Uri(ApiUrl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync($"{Rota}{Cpf}");
                    if (response.IsSuccessStatusCode)
                        Cliente = JsonConvert.DeserializeObject<Cliente>(response.Content.ReadAsStringAsync().Result);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            return Cliente;
        }
        #endregion GETASYNC


        #region DELETEASYNC
        public async Task DeleteAsync(Guid IDClient, string Rota)
        {
            using (HttpClient client = new HttpClient())
            {

                try
                {
                    client.BaseAddress = new Uri(ApiUrl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.DeleteAsync($"{Rota}{IDClient}");
                    if (response.IsSuccessStatusCode)
                        Console.WriteLine("Deletou");// JUST FOR TESTING
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
        #endregion DELETEASYNC

        #region FROM => TO
        /*I CREATED THESE FUNCTIONS BELOW JUST TO CAPTURE THE ENUMS DESCRIPTION AND SAVE THOSE IN DATABASE*/
        public Cliente FromTo(Cliente cliente)
        {
            cliente.SexoDesc = GetSexDescription(cliente);
            cliente.Endereco.EstadoDesc = GetStateDescription(cliente);
            cliente.OrgaoExpedicaoDesc = GetOrgoaExDescription(cliente);
            cliente.EstadoCivilDesc = GetMaritalStatusDescription(cliente);
            return cliente;
        }

        public string GetStateDescription(Cliente cliente)
       => cliente.Endereco.EstadoValue.GetAttributeOfType<DescriptionAttribute>().Description;

        public string GetSexDescription(Cliente cliente)
            => cliente.SexoValue.GetAttributeOfType<DescriptionAttribute>().Description;

        public string GetOrgoaExDescription(Cliente cliente) =>
            cliente.OrgaoExpedicaoValue.GetAttributeOfType<DescriptionAttribute>().Description;

        public string GetMaritalStatusDescription(Cliente cliente)
                => cliente.EstadoCivilValue.GetAttributeOfType<DescriptionAttribute>().Description;
        #endregion FROMTO

    }
}

