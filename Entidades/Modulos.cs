namespace Entidades
{
    public class Modulos
    {
        public Modulos(int id_Modulo, string nombreModulo)
        {
            Id_Modulo = id_Modulo;
            NombreModulo = nombreModulo;
        }

        public int Id_Modulo { get; set;  }
        public string NombreModulo { get; set; }
    }
}
