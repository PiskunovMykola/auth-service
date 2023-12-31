﻿using AuthService.Data;
using AuthService.Models;
using AuthService.Models.Dto;
using AuthService.Service.IService;
using Microsoft.AspNetCore.Identity;

namespace AuthService.Service;

public class AuthService : IAuthService
{
    private readonly AppDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    
    public AuthService(AppDbContext db,
        UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _db = db;
        _userManager = userManager;
        _roleManager = roleManager;
    }
    
    public Task<UserDto> Register(RegistrationRequestDto registrationRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
    {
        throw new NotImplementedException();
    }
}