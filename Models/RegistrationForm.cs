using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class RegistrationForm {
        RegistrationData registrationData;
        [Display(Name = "Registration Data")]
        public RegistrationData RegistrationData {
            get {
                if(registrationData == null)
                    registrationData = new RegistrationData();
                return registrationData;
            }
        }

        AuthorizationData authorizationData;
        [Display(Name = "Authorization Data")]
        public AuthorizationData AuthorizationData { 
            get {
                if (authorizationData == null)
                    authorizationData = new AuthorizationData();
                return authorizationData;
            }
        }
    }
    public enum Gender { Male, Female };
    public class RegistrationData {
        [Required(ErrorMessage = "*")]
        [DisplayFormat(NullDisplayText = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayFormat(NullDisplayText = "Last Name")]
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }

        public static IEnumerable<string> GetPossibleCountries() {
            return NorthwindDataProvider.DB.Invoices.Select(i => i.Country).OfType<string>().Distinct();
        }
    }
    public class AuthorizationData {
        [Display(Name = "E-mail")]
        [Required]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "E-mail is invalid")]
        public string Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password you entered do not match")]
        public string ConfirmPassword { get; set; }
    }

    public class RegistrationFormClientSideAPIModel {
        public RegistrationFormClientSideAPIModel() {
            IsNewUser = true;
            LoginModel = new LoginModel();
            RegisterModel = new RegisterModel();
        }
        public bool IsNewUser { get; set; }
        public LoginModel LoginModel { get; private set; }
        public RegisterModel RegisterModel { get; private set; }
    }
    public class LoginModel {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        bool? rememberMe;
        [Display(Name = "Remember Me")]
        public bool? RememberMe {
            get { return rememberMe ?? false; }
            set { rememberMe = value; }
        }   
    }
    public class RegisterModel {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class FormLayoutContactInfo {
        public enum ContactType { Email, Phone, SMS, InstantMessenger, PostalService };
        public class EmailContact {
            [Required]
            [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
            public string Email { get; set; }
            [Compare("Email")]
            public string RetypeEmail { get; set; }
        }
        public class PhoneContact {
            [Required(ErrorMessage = "*")]
            [Mask("(999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.None, ErrorMessage = "*")]
            public int? Phone { get; set; }
            public string Extension { get; set; }
            [Display(Name = "From")]
            public TimeSpan StartTimeToCall { get; set; }
            [Display(Name = "To")]
            public TimeSpan EndTimeToCall { get; set; }
        }
        public class SMSContact {
            [Required(ErrorMessage = "*")]
            [Display(Name = "Mobile Service Provider")]
            public string Provider { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "Phone Number")]
            [Mask("(999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.None, ErrorMessage = "*")]
            public int? Phone { get; set; }
        }
        public class InstantMessengerContact {
            [Required(ErrorMessage = "*")]
            [Display(Name = "Instant Messenger service")]
            public string ServiceName { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "Messenger ID")]
            public string MessengerID { get; set; }
        }
        public class PostalServiceContact {
            [Required(ErrorMessage = "*")]
            public string Address { get; set; }
            [Required(ErrorMessage = "*")]
            public string City { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "Post Code")]
            public int? PostCode { get; set; }
            [Required(ErrorMessage = "*")]
            public string Country { get; set; }
        }

        public FormLayoutContactInfo() {
            Email = new EmailContact();
            Phone = new PhoneContact();
            SMS = new SMSContact();
            InstantMessenger = new InstantMessengerContact();
            PostalService = new PostalServiceContact();
        }

        public ContactType Type { get; set; }
        public EmailContact Email { get; private set; }
        public PhoneContact Phone { get; private set; }
        public SMSContact SMS { get; private set; }
        public InstantMessengerContact InstantMessenger { get; private set; }
        public PostalServiceContact PostalService { get; private set; }
    }
}
