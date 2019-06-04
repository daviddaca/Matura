using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadatak15.Models
{
    public class PredjeniPut
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Registarski broj mora biti naveden!")]
        [DisplayName("Registarski broj")]
        public string RegistarskiBroj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Datum mora biti naveden!")]
        [DisplayName("Datum")]
        public string Datum { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podatak 'Od mesta' mora biti naveden!")]
        [DisplayName("Od mesta")]
        public string OdMesta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podatak 'Do mesta' mora biti naveden!")]
        [DisplayName("Do mesta")]
        public string DoMesta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podatak 'Pređeno KM' mora biti naveden!")]
        [DisplayName("Predjeno KM")]
        public int PredjenoKM { get; set; }

        public string ErrorMessage { get; set; }

        public List<SelectListItem> SvaVozila = new List<SelectListItem>();
    }
}