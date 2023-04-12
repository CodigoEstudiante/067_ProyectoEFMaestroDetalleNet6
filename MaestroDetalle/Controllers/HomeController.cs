using MaestroDetalle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MaestroDetalle.Models.ViewModels;


namespace MaestroDetalle.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBCOMPRAContext _dbcontext;

        public HomeController(DBCOMPRAContext context)
        {
            _dbcontext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] CompraVM oCompraVM)
        {
            Compra oCompra = oCompraVM.oCompra;


            oCompra.DetalleCompras = oCompraVM.oDetalleCompra;

            _dbcontext.Compras.Add(oCompra);
            _dbcontext.SaveChanges();



            return Json(new { respuesta = true });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}