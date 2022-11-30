using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UltrAthelitcs.Models
{
    public class PesoViewModel
    {
        [Display(Prompt = "Peso", Description = "Peso", Name = "Peso: ")]
        public String Cantidad { get; set; }
    }
}