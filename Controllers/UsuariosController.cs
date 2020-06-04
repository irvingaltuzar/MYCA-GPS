using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRO_001.Models;
using PRO_001.Models.POSITIONSDB;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
namespace PRO_001.Controllers
{

    public class UsuariosController : Controller
    {
        private readonly erp_MYCADBContext _context;
        private readonly gps_POSITIONSDBContext pcontext;

        public UsuariosController(erp_MYCADBContext context, gps_POSITIONSDBContext _pcontext)
        {
            _context = context;
            pcontext = _pcontext;
        }


        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("SessionUser") != null)
            {
                ViewBag.sessionv = HttpContext.Session.GetString("SessionUser").ToString();
                return View(await _context.MonConsolaUsuariosWeb.ToListAsync());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monConsolaUsuariosWeb = await _context.MonConsolaUsuariosWeb
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (monConsolaUsuariosWeb == null)
            {
                return NotFound();
            }

            return View(monConsolaUsuariosWeb);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUser,NombreCompleto,Correo,Pass,Cliente,Logo,FechaIngreso,FechaModifica,FechaUltimoAcceso,Estado,ExtLogo")] MonConsolaUsuariosWeb monConsolaUsuariosWeb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monConsolaUsuariosWeb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monConsolaUsuariosWeb);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monConsolaUsuariosWeb = await _context.MonConsolaUsuariosWeb.FindAsync(id);
            if (monConsolaUsuariosWeb == null)
            {
                return NotFound();
            }
            return View(monConsolaUsuariosWeb);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUser,NombreCompleto,Correo,Pass,Cliente,Logo,FechaIngreso,FechaModifica,FechaUltimoAcceso,Estado,ExtLogo")] MonConsolaUsuariosWeb monConsolaUsuariosWeb)
        {
            if (id != monConsolaUsuariosWeb.IdUser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monConsolaUsuariosWeb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonConsolaUsuariosWebExists(monConsolaUsuariosWeb.IdUser))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(monConsolaUsuariosWeb);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            } 

            var monConsolaUsuariosWeb = await _context.MonConsolaUsuariosWeb
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (monConsolaUsuariosWeb == null)
            {
                return NotFound();
            }

            return View(monConsolaUsuariosWeb);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monConsolaUsuariosWeb = await _context.MonConsolaUsuariosWeb.FindAsync(id);
            _context.MonConsolaUsuariosWeb.Remove(monConsolaUsuariosWeb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonConsolaUsuariosWebExists(int id)
        {
            return _context.MonConsolaUsuariosWeb.Any(e => e.IdUser == id);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Positions()
        {
            var objresult = new TblLastPosWebApi();
            String json;

            using (gps_POSITIONSDBContext db = new gps_POSITIONSDBContext())
            {
                List<TblPositionsLast> objpositions = (from d in db.TblPositionsLast
                                                       select d).ToList();
                 json= JsonSerializer.Serialize(objpositions);

             }
            return Json(json);
        }

        [HttpPost]
        public IActionResult Buscar_Unidad([FromBody]TblPositionsLast DeviceEco)
        {
          
          
            String json;

            using (gps_POSITIONSDBContext db = new gps_POSITIONSDBContext())
            {
                List<TblPositionsLast> objpositions = (from d in db.TblPositionsLast
                                                       where d.DeviceEco.Contains (DeviceEco.DeviceEco)
                                                       select d).ToList();

                json = JsonSerializer.Serialize(objpositions);

            }
            return Json(json);
        }
    }
   
    
  
}
