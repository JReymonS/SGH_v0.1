namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int id_Usuario, string nombre, string contrasena, string rol, bool estatus, string fechaRegistro)
        {
            Id_Usuario = id_Usuario;
            Nombre = nombre;
            Contrasena = contrasena;
            Rol = rol;
            Estatus = estatus;
            FechaRegistro = fechaRegistro;
        }

        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set;}
        public bool Estatus { get ; set; }
        public string FechaRegistro { get; set; }
    }
}
