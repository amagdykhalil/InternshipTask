using InternshipTask.API.Attributes;
using InternshipTask.Application.Models.Responses;
using InternshipTask.BusinessLayer.DTOs;
using InternshipTask.BusinessLayer.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace InternshipTask.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController(IUserService userService) : ControllerBase
    {
        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="command">The user creation command.</param>
        /// <returns>The ID of the created user.</returns>
        [HttpPost]
        [ApiResponse(StatusCodes.Status400BadRequest)]
        [EndpointDescription("Creates a new user")]
        public async Task<IActionResult> Create([FromBody] AddUserDTO command, CancellationToken cancellationToken)
        {
            await userService.AddUserAsync(command, cancellationToken);
            return Ok(ApiResponse.Created("User created successfully"));
        }
    }
}
