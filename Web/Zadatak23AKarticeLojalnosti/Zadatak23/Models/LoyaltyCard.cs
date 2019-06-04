using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak23.Models
{
    public class LoyaltyCard
    {
        public string BrojKartice { get; set; }
        public string ImeVlasnika { get; set; }
        public string PrezimeVlasnika { get; set; }
        public string AdresaVlasnika { get; set; }
        public double OstvareniBodovi { get; set; }
        public double OstvareniPopust { get; set; }
        public double RokVazenja { get; set; }

        public string ErrorMessage { get; set; }
    }
}