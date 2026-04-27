using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorDashboard
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera", 3311);

        public void ConsultarNombre(Usuarios usuarios, Label lbl)
        {
           //b.Consulta($"SELECT Nombre FROM Usuarios WHERE Id_Usuario = {usuarios.Id_Usuario}");
        }

    }
}
