using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INZFS.MVC.Models
{
    public class EligibilityCreiteria : ContentPart
    {
        [Required(ErrorMessage = "Select Yes or No")]
        [Display(Name = "Technology and Innovation")]
        public int? TechnologyAndInnovation { get; set; }

        [Required(ErrorMessage = "Select Yes or No")]
        [Display(Name = "Timing")]
        public int? Timing { get; set; }

        [Required(ErrorMessage = "Select Yes or No")]
        [Display(Name = "Match Funding")]
        public int? MatchFunding { get; set; }

        [Required(ErrorMessage = "Select Yes or No")]
        [Display(Name = "Subsidy Category")]
        public int? SubsidyCategory { get; set; }
    }
}
