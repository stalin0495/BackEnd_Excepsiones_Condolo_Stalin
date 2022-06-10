using System.ComponentModel.DataAnnotations;

namespace WEBAPI_CondoloStalin.Models
{
    public class Ahorros : Cuenta
    {
        [Key]
        public int AHO_ID { get; set; }
        public int AHO_MontoPromedio { get; set; }

        public Ahorros() { }

        public Ahorros(string CUE_NUMEROC, double CUE_SALDO, int AHO_MontoPromedio) {
            this.AHO_MontoPromedio = AHO_MontoPromedio;
        
        }
    }
}

