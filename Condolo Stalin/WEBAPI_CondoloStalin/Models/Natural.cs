namespace WEBAPI_CondoloStalin.Models
{
    public class Natural : Cliente
    {
        public string NAT_Tipo { get; set; }
        public int NAT_Edad { get; set; }

        /*public Natural() { }

        public Natural(string CLI_NOMBRE, string CLI_APELLIDO, string CLI_TELEFONO, string CLI_CORREO, string NAT_Tipo, int NAT_Edad) 
            : base(CLI_NOMBRE,CLI_APELLIDO,CLI_TELEFONO,CLI_CORREO) 
        {
            this.NAT_Tipo = NAT_Tipo;
            this.NAT_Edad = NAT_Edad;
        }*/

    }
}
