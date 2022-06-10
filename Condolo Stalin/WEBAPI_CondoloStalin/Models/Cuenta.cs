using System.ComponentModel.DataAnnotations;

namespace WEBAPI_CondoloStalin.Models
{
    public class Cuenta : ITransaccion
    {
        [Key]
        public int CUE_ID { get; set; }
        public string CUE_NUMEROC { get; set; }
        public double CUE_SALDO { get; set; }
        
        public Cuenta() { }

        public Cuenta(string CUE_NUMEROC, double CUE_SALDO) { 
            this.CUE_NUMEROC = CUE_NUMEROC;
            this.CUE_SALDO = CUE_SALDO;
        }

        public void Depositar()
        {
            return;
            
        }

        public void Retirar()
        {
            return;
        }

        public void Transferir()
        {
            return;
        }
    }
}
