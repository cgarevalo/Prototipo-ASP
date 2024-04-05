using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DireccionNegocio
    {
        List<Direccion> listaDirecciones;

        public List<Direccion> ListarDirecciones()
        {
            listaDirecciones = new List<Direccion>();

            listaDirecciones.Add(new Direccion());
            listaDirecciones.Add(new Direccion());

            listaDirecciones[0].Id = 1;
            listaDirecciones[0].Calle = "Frías";
            listaDirecciones[0].Altura = 6226;

            listaDirecciones[1].Id = 2;
            listaDirecciones[1].Calle = "Ruchi";
            listaDirecciones[1].Altura = 666;

            return listaDirecciones;
        }
    }
}
