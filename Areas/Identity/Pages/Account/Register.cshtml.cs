using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using CustomerPlatform.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Net;
using System.IO;





namespace CustomerPlatform.Areas.Identity.Pages.Account
{

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<CustomerPlatformUser> _signInManager;
        private readonly UserManager<CustomerPlatformUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;


        public RegisterModel(
            UserManager<CustomerPlatformUser> userManager,
            SignInManager<CustomerPlatformUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("/");
            }

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            // Template to inject the email into URL of API

            string template = "https://restapisaadeddine.azurewebsites.net/api/Customers/{0}";
            string data = Input.Email;
            string url = string.Format(template, data);
            // Console.WriteLine("******** " + url);

            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string Customer_JSON_List = reader.ReadToEnd();

            String Customer_JSON = Customer_JSON_List.Substring(1, Customer_JSON_List.Length - 2);
            Root myUSER = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(Customer_JSON);
            // Console.WriteLine("---------------voila -----" + myUSER.companyContactEmail + "------------------");
            // if (myUSER.companyContactEmail == null)
            //     Console.WriteLine("is nullllllllllllllllllllllllll");

            if (ModelState.IsValid && myUSER != null)
            {
                var user = new CustomerPlatformUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Youre not a customer ! please contact the IT Team for more details.");

            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }

    public class Root
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string companyName { get; set; }
        public string companyContactFullName { get; set; }
        public string companyContactPhone { get; set; }
        public string companyContactEmail { get; set; }
        public string companyDescription { get; set; }
        public string technicalAuthorityFullName { get; set; }
        public string technicalAuthorityPhoneNumber { get; set; }
        public string technicalManagerEmailService { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int addressId { get; set; }
        public List<object> addresses { get; set; }
    }

}
