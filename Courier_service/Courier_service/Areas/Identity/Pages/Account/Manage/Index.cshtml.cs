using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Courier_service.Models;
using Microsoft.Extensions.Options;

namespace Courier_service.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly DatabaseService _dbs;
        private ServiceContext _serviceContext;

        public IndexModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _serviceContext = new ServiceContext();
            _dbs = new DatabaseService(_serviceContext);
        }

        public string Username { get; set; }

        public Client Client { get; set; } = null;

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "First name")]
            public string FName { get; set; }
            [Display(Name = "Second name")]
            public string SName { get; set; }
            [Display(Name = "Patronymic")]
            public string Patronymic { get; set; }
        }

        private async Task LoadAsync(IdentityUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var client = from c in _serviceContext.Clients
                         where c.AspName == user.Id
                         select c;
            if (client.Count() > 0) Client = client.First();

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber
            };

            if (Client != null) { Input.FName = Client.FName; Input.SName = Client.SName; Input.Patronymic = Client.Patronymic; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            var client = from c in _serviceContext.Clients
                         where c.AspName == user.Id
                         select c;
            if (client.Count() > 0)
            {
                Client = client.First();
            }


            if (Client == null && user != null)
            {
                Client = new Client()
                {
                    FName = Input.FName,
                    SName = Input.SName,
                    Patronymic = Input.Patronymic,
                    Deleted = false,
                    AspName = user.Id
                };
                _dbs.AddClient(Client);
            }
            else if(user != null)
            {
                Client.FName = Input.FName;
                Client.SName = Input.SName;
                Client.Patronymic = Input.Patronymic;
                _dbs.UpdateClient(Client);
            }
            try { _dbs.SaveData(); }
            catch { StatusMessage = "Unexpected error when trying to set client data."; return Page(); }

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
