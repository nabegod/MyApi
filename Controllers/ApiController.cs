using System.Threading.Tasks;
using MyApi.models;
using System.Collections.Generic;    
using Microsoft.AspNetCore.Mvc;
using MyApi.ApiData;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using MyApi.ViewModels;
// This code defines a basic API controller without any specific routes or actions.
namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class ApiController : ControllerBase
    {


        [HttpGet]
        [Route("apis")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {
            var apis = await context.Apis.ToListAsync();

            return Ok(apis);

        }

        [HttpGet]
        [Route("apis/{id}")]
        public async Task<IActionResult> GetByAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {
            var apis = await context.Apis.FirstOrDefaultAsync(Api => Api.Id == id);

            return apis == null
                ? NotFound()
                : Ok(apis);
        }

        [HttpPost("apis")]
        public async Task<IActionResult> PostAsync([FromServices] AppDbContext context, [FromBody] CreateApiViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var api = new Api
            {
                Title = model.Title,
                Done = false
            };

            await context.Apis.AddAsync(api);
            await context.SaveChangesAsync();

            return Created(uri: $"api/v1/apis/{api.Id}", api);
            
        }
        
    }


}