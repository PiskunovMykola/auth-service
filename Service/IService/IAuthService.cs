using AuthService.Models.Dto;

namespace AuthService.Service.IService;

public interface IAuthService
{
    Task<UserDto> Register(RegistrationRequestDto registrationRequestDto);
    Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
}