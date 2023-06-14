using AcademiaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AcademiaApp.Controllers
{
    public class EstudianteController : Controller
    {
        public AcademiaContext context;
        public EstudianteController(AcademiaContext context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            List<Estudiante> estudiantes = context.Estudiantes.Include(i => i.Direccion).ToList();
            return View(estudiantes);
        }

        public IActionResult Create()
        {
            Estudiante estudiante = new Estudiante();
            return View(estudiante);
        }
        public IActionResult Save(Estudiante estudiante)
        {
            if(ModelState.IsValid) 
            {
                context.Estudiantes.Add(estudiante);
                context.SaveChanges();
            } 
            else
            {
                return View("Create", estudiante);
            }
            return View(nameof(Index));
        }
    }
}
