using MultiLanMVC.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiLanMVC.Models
{
    public class Bl
    {
        [Display(Name = "BL_ORIG", ResourceType = typeof(ResourceDocu))]
        [Required(ErrorMessageResourceType = typeof(ResourceDocu), ErrorMessageResourceName = "BL_ORIGRequired")]
        public string BL_ORIG
        {
            get;
            set;
        }
        [Display(Name = "BLS", ResourceType = typeof(ResourceDocu))]
        [Required(ErrorMessageResourceType = typeof(ResourceDocu), ErrorMessageResourceName = "BLSRequired")]
        public string BLS
        {
            get;
            set;
        }
    }
}