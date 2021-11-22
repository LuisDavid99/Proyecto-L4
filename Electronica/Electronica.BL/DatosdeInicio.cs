using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists <Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "Douglas";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Daniel";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("contra1");

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Alex";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("contra2");

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Luis";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("contra3");

            contexto.Usuarios.Add(nuevoUsuario);
            contexto.Usuarios.Add(nuevoUsuario1);
            contexto.Usuarios.Add(nuevoUsuario2);
            contexto.Usuarios.Add(nuevoUsuario3);

            base.Seed(contexto);
        }

    }
}
