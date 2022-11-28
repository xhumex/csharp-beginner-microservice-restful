using System;

using CSharp.Beginner.Microservice.Restful.Models;
using CSharp.Beginner.Microservice.Restful.Repositories;

namespace CSharp.Beginner.Microservice.Restful.Services;

/**
 *  UserService.cs
 * 
 *  Author   Cristian Hume Henriquez
 *  Version  1.0.0
 *  Created  2022-11-27
 *  Modified 2022-11-28
 */
public class UserService
{
    #region [PRIVATE-FIELDS]
    private readonly UserRepository _userRepository;
    #endregion [PRIVATE-FIELDS]

    #region [PUBLIC-CONSTRUCTORS]
    public UserService()
    {
        _userRepository = new UserRepository();
    }
    #endregion [PUBLIC-CONSTRUCTORS]

    #region [PUBLIC-METHODS]
    public Int32 Create(UserModel userModel)
    {
        return _userRepository.Create(userModel);
    }

    public List<UserModel> FindAll()
    {
        return _userRepository.FindAll();
    }

    public UserModel? FindById(Int128 id)
    {
        return _userRepository.FindById(id);
    }

    public void Update(Int32 id, UserModel userModel)
    {
        _userRepository.Update(id, userModel);
    }

    public void Delete(Int32 id)
    {
        _userRepository.Delete(id);
    }
    #endregion [PUBLIC-METHODS]
}

