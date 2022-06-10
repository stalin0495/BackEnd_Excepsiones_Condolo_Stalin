namespace WEBAPI_CondoloStalin.Models
{
    public class Juridico : Cliente
    {
        public string JUR_Tipo { get; set; }
        public string JUR_Direccion { get; set; }
        

        /*public Juridico() { }

        public Juridico(string CLI_NOMBRE, string CLI_APELLIDO, string CLI_TELEFONO, string CLI_CORREO, string JUR_Tipo, string JUR_Direccion) 
            : base (CLI_NOMBRE, CLI_APELLIDO, CLI_TELEFONO, CLI_CORREO)
        {
            this.JUR_Tipo = JUR_Tipo;
            this.JUR_Direccion = JUR_Direccion;

        }*/
    }
}
