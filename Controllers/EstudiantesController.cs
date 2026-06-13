using Microsoft.AspNetCore.Mvc;
using ActividadPractica2.Models;

namespace ActividadPractica2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class EstudiantesController : ControllerBase
    {

        private static List<Estudiante> estudiantes = new List<Estudiante>()
        {

            new Estudiante
            {
                Id = 1,
                Nombre = "Ana",
                Apellido = "Perez",
                Correo = "ana@gmail.com",
                Carrera = "Ingenieria de Sistemas",
                Edad = 20,
                Promedio = 85,
                Activo = true
            },


            new Estudiante
            {
                Id = 2,
                Nombre = "Luis",
                Apellido = "Fortuna",
                Correo = "luis@gmail.com",
                Carrera = "Contabilidad",
                Edad = 22,
                Promedio = 60,
                Activo = false
            }

        };

      
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            return Ok(estudiantes);
        }

       
        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {

            var estudiante = estudiantes.FirstOrDefault(x => x.Id == id);


            if (estudiante == null)
            {
                return NotFound();
            }


            return Ok(estudiante);

        }


        [HttpPost]

        public IActionResult Crear(Estudiante estudiante)
        {


            estudiante.Id = estudiantes.Count + 1;


            estudiantes.Add(estudiante);


            return Created("", estudiante);

        }


        [HttpPut("{id}")]

        public IActionResult Actualizar(int id, Estudiante nuevo)
        {


            var estudiante = estudiantes.FirstOrDefault(x => x.Id == id);


            if (estudiante == null)
            {
                return NotFound();
            }


            estudiante.Nombre = nuevo.Nombre;
            estudiante.Apellido = nuevo.Apellido;
            estudiante.Correo = nuevo.Correo;
            estudiante.Carrera = nuevo.Carrera;
            estudiante.Edad = nuevo.Edad;
            estudiante.Promedio = nuevo.Promedio;
            estudiante.Activo = nuevo.Activo;



            return NoContent();

        }


    }
}

