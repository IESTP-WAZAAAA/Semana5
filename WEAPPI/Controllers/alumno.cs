namespace WEAPPI.Controllers
{
    public class Alumno
    {
        //crear las propiedades
        string nombre;
        string apellido;
        string dni;
        DateTime fechanacimiento;

        //constructor sin parametros
        public Alumno()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;
        }

        //constructor con parametro
        public Alumno(string pnombre, string papeliido, string pdni)
        {
            nombre = pnombre;
            apellido = papeliido;
            dni = pdni;
        }

        public Alumno(string pnombre, string papeliido, string pdni, DateTime pfechanacimiento)
        {
            nombre = pnombre;
            apellido = papeliido;
            dni = pdni;
            fechanacimiento = pfechanacimiento;
        }

        public string DevolverNombreCompleto()
        {
            return nombre + " " + apellido;
        }
        
        public string DevolverDni()
        {
            return dni;
        }
        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechanacimiento.Year;
        }
    }
}
