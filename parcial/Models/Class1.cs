using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace parcial.Models
{
    public class ValidacionesCliente
    {
     
            public int id_cliente { get; set; }
            [Required]
            [Display(Name = "No. Cuenta")]

            public string no_cuenta { get; set; }
            [Display(Name = "Nombre")]
            public string nombre { get; set; }
            [Display(Name = "Apellido")]
            public string apellido { get; set; }
            [Display(Name = "Concepto de Pago")]
            public string concepto_pago { get; set; }
            [Display(Name = "Monto Q.")]
            public decimal monto { get; set; }
        

    }
}