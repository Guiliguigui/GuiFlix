using GuiFlix_API.DTOs.Authentication;
using GuiFlix_API.Helpers;
using GuiFlix_Repositories.Services;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private IRepository<Account> _accountRepository;
        private IRepository<Admin> _adminRepository;
        private ICryptPasswordService _cryptPasswordService;
        private readonly APISettings _aPISettings;
        public AuthenticationController(IRepository<Account> accountRepository,
            IRepository<Admin> adminRepository,
            ICryptPasswordService cryptPasswordService,
            IOptions<APISettings> options)
        {
            _accountRepository = accountRepository;
            _adminRepository = adminRepository;
            _cryptPasswordService = cryptPasswordService;
            _aPISettings = options.Value;
        }

        [HttpPost("User/Register")]
        public async Task<ActionResult<RegisterResponseUserDTO>> RegisterUser([FromBody] RegisterRequestUserDTO request)
        {
            if (request == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _accountRepository.Find(u => u.Email == request.Email) != null)
                return new RegisterResponseUserDTO()
                {
                    IsRegisterationSuccessful = false,
                    ErrorMessage = "Email is already taken by another User"
                };

            Account account = new Account()
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password = _cryptPasswordService.EncryptPassword(request.Password),
                Phone = request.Phone,
                IsBanned = false
            };

            if (await _accountRepository.Create(account) == null)
                return new RegisterResponseUserDTO()
                {
                    IsRegisterationSuccessful = false,
                    ErrorMessage = "Error during the Creation of a User"
                };

            return new RegisterResponseUserDTO()
            {
                IsRegisterationSuccessful = true
            };
        }

        [HttpPost("User/Login")]
        public async Task<ActionResult<LoginResponseUserDTO>> LoginUser([FromBody] LoginRequestUserDTO request)
        {
            if (request == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.Password = _cryptPasswordService.EncryptPassword(request.Password);

            Account? account = await _accountRepository.Find(u => u.Email == request.Email && u.Password == request.Password);

            if (account != null && account.IsBanned == false)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, account.Email),
                    new Claim(ClaimTypes.Role, Constants.RoleUserAccount),
                    new Claim("Id", account.Id.ToString()),
                };

                SigningCredentials signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_aPISettings.SecretKey!)), SecurityAlgorithms.HmacSha256);

                JwtSecurityToken jwt = new JwtSecurityToken(issuer: _aPISettings.ValidIssuer, audience: _aPISettings.ValidAudience, claims: claims, signingCredentials: signingCredentials, expires: DateTime.Now.AddDays(7));

                var token = new JwtSecurityTokenHandler().WriteToken(jwt);

                return new LoginResponseUserDTO()
                {
                    IsAuthSuccessful = true,
                    Token = token
                };
            }

            return new LoginResponseUserDTO()
            {
                IsAuthSuccessful = false,
                ErrorMessage = "Invalid Authentication"
            };
        }

        [HttpPost("Admin/Login")]
        public async Task<ActionResult<LoginResponseAdminDTO>> LoginAdmin([FromBody] LoginRequestAdminDTO request)
        {
            if (request == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.Password = _cryptPasswordService.EncryptPassword(request.Password);

            Admin? admin = await _adminRepository.Find(u => u.UserName == request.UserName && u.Password == request.Password);

            if (admin != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, admin.UserName),
                    new Claim(ClaimTypes.Role, Constants.RoleAdminAccount),
                    new Claim("Id", admin.Id.ToString()),
                };

                SigningCredentials signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_aPISettings.SecretKey!)), SecurityAlgorithms.HmacSha256);

                JwtSecurityToken jwt = new JwtSecurityToken(issuer: _aPISettings.ValidIssuer, audience: _aPISettings.ValidAudience, claims: claims, signingCredentials: signingCredentials, expires: DateTime.Now.AddDays(7));

                var token = new JwtSecurityTokenHandler().WriteToken(jwt);

                return new LoginResponseAdminDTO()
                {
                    IsAuthSuccessful = true,
                    Token = token
                };
            }

            return new LoginResponseAdminDTO()
            {
                IsAuthSuccessful = false,
                ErrorMessage = "Invalid Authentication"
            };
        }
    }
}
