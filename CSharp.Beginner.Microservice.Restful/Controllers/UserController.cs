using System;
using Microsoft.AspNetCore.Mvc;

using CSharp.Beginner.Microservice.Restful.Models;
using CSharp.Beginner.Microservice.Restful.Services;

namespace CSharp.Beginner.Microservice.Restful.Controllers;

/**
 *  UserController.cs
 * 
 *  Author   Cristian Hume Henriquez
 *  Version  1.0.0
 *  Created  2022-11-27
 *  Modified 2022-11-28
 */
[ApiController]
[Route("api/csharp/v1/users")]
public class UserController : ControllerBase
{
    #region [PRIVATE-FIELDS]
    private readonly UserService _userService;
    #endregion [PRIVATE-FIELDS]

    #region [PUBLIC-CONSTRUCTORS]
    public UserController()
    {
        _userService = new UserService();
    }
    #endregion [PUBLIC-CONSTRUCTORS]

    #region [PUBLIC-METHODS]
    [HttpPost]
    public IActionResult Create(UserModel userModel)
    {
        Int32 id = _userService.Create(userModel);

        return Created("/api/csharp/v1/users/" + id, new { Id = id });
    }

    [HttpGet]
    public IActionResult FindAll()
    {
        List<UserModel> userModelList = _userService.FindAll();

        return (userModelList != null ? (userModelList.Count > 0 ? Ok(userModelList) : NotFound()) : NotFound());
    }

    [HttpGet("{id}")]
    public IActionResult FindById(Int128 id)
    {
        UserModel? userModel = _userService.FindById(id);

        return (userModel != null ? Ok(userModel) : NotFound());
    }

    [HttpPut("{id}")]
    public IActionResult Update(Int32 id, UserModel userModel)
    {
        _userService.Update(id, userModel);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Int32 id)
    {
        _userService.Delete(id);

        return Ok();
    }
    #endregion [PUBLIC-METHODS]

}


