using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiLanMVC.Models
{
    public class Registration
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "FirstNameRequired")]
        public string FirstName
        {
            get;
            set;
        }
        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "LastNameRequired")]
        public string LastName
        {
            get;
            set;
        }
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "EmailRequired")]
        public string Email
        {
            get;
            set;
        }
        [Display(Name = "Country", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "CountryNameRequired")]
        public string Country
        {
            get;
            set;
        }
    }
}