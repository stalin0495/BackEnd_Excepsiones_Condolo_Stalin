using System.ComponentModel.DataAnnotations;

namespace WEBAPI_CondoloStalin.Models
{
    public class Cliente
    {
        [Key]
        public int CLI_ID { get; set; }
        public string CLI_NOMBRE { get; set; }
        public string CLI_APELLIDO { get; set; }
        public string CLI_TELEFONO { get; set; }
        public string CLI_CORREO { get; set; }

        /*public Cliente() { }

        public Cliente(string CLI_NOMBRE, string CLI_APELLIDO, string CLI_TELEFONO, string CLI_CORREO) {
            this.CLI_NOMBRE = CLI_NOMBRE;
            this.CLI_APELLIDO = CLI_APELLIDO;
            this.CLI_TELEFONO = CLI_TELEFONO;
            this.CLI_CORREO = CLI_CORREO;
        }*/


    }
}
