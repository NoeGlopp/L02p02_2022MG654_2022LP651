using L02p02_2022MG654_2022LP651.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace L02p02_2022MG654_2022LP651.Controllers
{
    public class clientesController : Controller
    {
        private readonly libreriaDbContext _context;

        public clientesController(libreriaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("agregarCliente");
        }

        public IActionResult agregarCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult agregarCliente(string nombre, string apellido, string email, string direccion)
        {
            var nuevoCliente = new clientes
            {
                nombre = nombre,
                apellido = apellido,
                email = email,
                direccion = direccion,
                created_at = DateTime.Now
            };

            _context.clientes.Add(nuevoCliente);
            _context.SaveChanges();

            HttpContext.Session.SetString("ClienteNombre", nuevoCliente.nombre);
            HttpContext.Session.SetString("ClienteApellido", nuevoCliente.apellido);
            HttpContext.Session.SetString("ClienteEmail", nuevoCliente.email);
            HttpContext.Session.SetString("ClienteDireccion", nuevoCliente.direccion);

            var pedido = new pedido_encabezado
            {
                id_cliente = nuevoCliente.id,
                cantidad_libros = 0,
                total = 0
            };

            _context.pedido_encabezado.Add(pedido);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("PedidoId", pedido.id);

            //Cambiar a controlador de pedidos
            return RedirectToAction("seleccionarLibro", "pedido_encabezado");
        }
    }
}