using AutoMapper;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Data.DTO_s;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class UserService
    {
        private SignInManager<User> _singInManager;
        private IMapper _mapper;
        private UserManager<User> _userManager;
        private TokenService _tokenService;

        public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> singInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _singInManager = singInManager;
            _tokenService = tokenService;
        }

        public async Task Cadastrar(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!");
            }
        }

        public async Task<string> Login(LoginUserDto dto)
        {
            var result = await
            _singInManager.PasswordSignInAsync(
                dto.UserName, dto.Password, false, false);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado!");
            }

            var user = _singInManager.UserManager.Users
                .FirstOrDefault(user => user.NormalizedUserName == 
                dto.UserName.ToUpper());

            var token = _tokenService.GenerationToken(user);

            return token;
           }

        
    }
}
