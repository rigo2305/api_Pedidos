using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api_Pedidos.Models;


namespace Web_Api_Pedidos.Controllers
{
    //[Route("api/Clientes")]
    //[ApiController]
    //public class CustomerControl : ControllerBase
    //{
    //    //Llamamos a nuestra base y asignamos un nombre
    //    public readonly masterContext _dbNortwit;

    //    //Crear Constructor
    //    public CustomerControl(masterContext dbNortwit)
    //    {
    //        _dbNortwit = dbNortwit;
    //    }

    //    [HttpGet]
    //    [Route("Lista")]
    //    public IActionResult Lista()

    //    {
            

    //        List<Customer> ListaCustomer = new List<Customer>();
    //        try
    //        {
    //            ListaCustomer = _dbNortwit.Customers.ToList();
    //            return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", Response = ListaCustomer });
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }


    //}
}
