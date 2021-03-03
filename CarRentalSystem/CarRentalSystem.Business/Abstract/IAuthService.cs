using CarRentalSystem.Core.Entities.Concrete;
using CarRentalSystem.Core.Utilities.Results;
using CarRentalSystem.Core.Utilities.Security.JWT;
using CarRentalSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
