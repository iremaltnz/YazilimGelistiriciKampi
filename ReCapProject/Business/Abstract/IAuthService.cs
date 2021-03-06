﻿using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult Update(UserForUpdateDto userForUpdateDto);
    }
}
