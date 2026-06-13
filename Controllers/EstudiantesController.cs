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


    }
}

