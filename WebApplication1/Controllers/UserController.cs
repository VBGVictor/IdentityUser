using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.DTO_s;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        
        private readonly UserService _userService;

        public UserController(UserService cadastroService)
        {
            _userService = cadastroService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CustomUser(CreateUserDto dto)
        {
            await _userService.Cadastrar(dto);
            return Ok("Novo Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto dto)
        {
            var token = await _userService.Login(dto);
            return Ok(token);
        }
    }
}
