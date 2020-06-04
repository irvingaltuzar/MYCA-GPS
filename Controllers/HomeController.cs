using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRO_001.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using DevExpress.Utils;


namespace PRO_001.Controllers
{


    public class HomeController : Controller
    {
        private readonly erp_MYCADBContext _context;
        //private readonly IMapper _mapper;
        //private readonly UserManager<erp_MYCADBContext> _userManager;
        //private readonly SignInManager<erp_MYCADBContext> _signInManager;

        private readonly ILogger<HomeController> _logger;
     

        public HomeController(ILogger<HomeController> logger, erp_MYCADBContext context)
        {
            _logger = logger;
            _context = context;
            //_userManager = userManager;
            // _signInManager = signInManager;
        }

      
        public async Task<IActionResult> Index()
        {
           
            return View(await _context.MonConsolaUsuariosWeb.ToListAsync());
        }

        public IActionResult Login()
        {
            return View();


        }
        [HttpGet]
        public IActionResult Index(string returnUrl)
        {
            if (HttpContext.Session.GetString("SessionUser") == null )
            {
                return View();
            }else
                return RedirectToAction("Index", "Usuarios");

        }

        public string _DECODIFICA_STR(string CADENA)
        {
            string VAR = string.Empty;
            try
            {
                for (int i = 1, loopTo = Strings.Len(CADENA); i <= loopTo; i += 3)
                VAR +=  Strings.Chr((int)(Conversion.Val(Strings.Mid(CADENA, i, 3))));


                return VAR;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return string.Empty;
         
            }
            finally
            { 
                GC.Collect();
            }
        }

        public string _CODIFICA_STR(string CADENA)
        {
            string RESULTADO = string.Empty;
            try
            {
                for (int i = 1, loopTo = Strings.Len(CADENA); i <= loopTo; i += 1)
                    RESULTADO +=  Strings.Format(Strings.Asc(Strings.Mid(CADENA, i, 1)), "0##");
                
                return RESULTADO;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return string.Empty;
            }
            finally
            {
                GC.Collect();
            }
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string user,string pass)
        {
            {
                try
                {
                    using Models.erp_MYCADBContext db = new Models.erp_MYCADBContext();

                    List<Models.MonConsolaUsuariosWeb> lst = (from d in db.MonConsolaUsuariosWeb
                                                              where d.Correo == user && d.Pass == _CODIFICA_STR(pass) && d.Estado == "ACTIVO"
                                                              select d).ToList();
                    if (lst.Count() > 0)
                    {
                        MonConsolaUsuariosWeb oUser = lst.First();
                        HttpContext.Session.SetString("SessionUser", oUser.Cliente);
                        return RedirectToAction("Index", "Usuarios");
                    }
                    else
                    {
                        ViewBag.alert = "¡Upsss..Usuario o contraseña incorrectas, por favor intentalo de nuevo!";
                        return View();
                    }
                }
                catch
                {
                    return Content("Ocurrio error");
                }

 
               
            }
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
