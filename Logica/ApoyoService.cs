using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class ApoyoService
    {
        private readonly PersonasContext _context;
        public ApoyoService(PersonasContext contex)
        {
             _context = context;
        }

        public Apoyo Guardar(Apoyo apoyo)
        {  
            if(_context.Guardar(apoyo))
                return apoyo;
            else
                return null;
        }

        public Apoyo[] ConsultarTodos()
        {
            return this._context.ConsultarTodos();
        }

    }
    
}