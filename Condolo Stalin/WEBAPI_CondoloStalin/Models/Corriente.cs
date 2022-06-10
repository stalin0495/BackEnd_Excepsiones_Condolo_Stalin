using System.ComponentModel.DataAnnotations;

namespace WEBAPI_CondoloStalin.Models
{
    public class Corriente : Cuenta
    {
        [Key]
        public int COR_ID { get; set; }
        public double COR_LimiteCredito { get; set; }
        public double COR_Interes { get; set; }

        public Corriente() { }

        public Corriente(string CUE_NUMEROC, double CUE_SALDO, double COR_LimiteCredito, double COR_Interes) {
            this.COR_LimiteCredito = COR_LimiteCredito;
            this.COR_Interes = COR_Interes;
        }
    }
}

