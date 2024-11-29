﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reactBackend.Models;
using reactBackend.Repository;

namespace WebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CalificacionController : ControllerBase
    {
        //Creamos una instancia del elemento CalificacionDAO 
        private CalificacionDao _cdao = new CalificacionDao();

        #region Lista_de_calificaciones
        [HttpGet("calificaciones")]
        public List<Calificacion> get(int idMatricula) { 
        
           return _cdao.seleccion(idMatricula);
        }
        #endregion
    }
}
