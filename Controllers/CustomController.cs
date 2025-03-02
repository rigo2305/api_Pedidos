﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Web_Api_Pedidos.Datos;
using Web_Api_Pedidos.Models;

namespace Web_Api_Pedidos.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class CustomController : ControllerBase
    {

       /// <summary>
       /// Devuelve la lista completa de los clientes
       /// </summary>
       /// <returns></returns>
        [HttpGet]

        public List<Customer> GetResult()
        {
            return CustomerData.ListaCli();
        }

        /// <summary>
        /// Busca el cliente por medio de su nombre, no por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Customer Get(string id)
        {
            return CustomerData.ObtenerCli(id);
        }
        /// <summary>
        /// Agrega un nuevo cliente
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public bool agregar(Customer customer)
        {
            return CustomerData.GuardarCli(customer);
        }

        /// <summary>
        /// elimina a un cliente por medio de un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public bool eliminar(string id)
        {
            return CustomerData.EliminarCli(id);
        }
        /// <summary>
        /// Modifica a un cliente por medio de un id
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public bool editar(Customer customer)
        {
            return CustomerData.EditarCli(customer);
        }


        //CustomerData cdt = new CustomerData();


        //public IActionResult Lista()
        //{
        //    //Muestra La lista 
        //    var oLista = cdt.ListaCli();

        //    return View(oLista);
        //}
        //public IActionResult Guardar()
        //{
        //    //Metodo  que solo devuelve la lista
        //    var oLista = cdt.ListaCli();

        //    return View(oLista);
        //}

        //[HttpPost]
        //public IActionResult Guardar(Customer oCliente)
        //{
        //    //Metodo que recibe el objeto ´para guardarlo a la BD 
        //    var respuesta = cdt.GuardarCli(oCliente);

        //    if (respuesta)
        //        return RedirectToAction("Lista");
        //    else

        //        return View();
        //}
        //public IActionResult Lista()
        //{
        //    //Muestra La lista 
        //    var oLista = cdt.ListaCli();

        //    return View(oLista);
        //}
    }
}
