
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IPersonService _personService;

        public AuthorController(IPersonService personService)
        {
            _personService = personService;
        }

        //// GET: api/<RolesController>
        //[HttpGet]
        //public async Task<List<PersonModel>> Get()
        //{
        //    return await _personService.GetAllAsync();

        //}

        //// GET api/<RolesController>/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<PersonModel>> Get(int id)
        //{
        //    var author = await _personService.GetByIdAsync(id);
        //    if (author is null)
        //    {
        //        return NotFound();
        //    }
        //    return author;
        //}

        /*[HttpPost]
        public async Task<ActionResult<PersonModel>> Post([FromBody] PersonModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _personService.AddAsync(new PersonModel() { FirstName = model.FirstName, LastName = model.LastName, DateOfBirth = model.DateOfBirth, HMO = model.HMO, Id = model.Id, MaleOrFemale = model.MaleOrFemale, TZ = model.TZ,Children=model.Children});

        }*/

         [HttpPost]//add
        public async Task<PersonModel> Post([FromBody] PersonModel model)
        {
            return await _personService.AddAsync(new PersonModel()
            {
                IdPermission=model.PermissionId,
                IdRole=model.RoleId,
                Policy = (ePolicyDTO)model.Policy
            });
        }


        //    [HttpPut("{id}")]
        //    public async Task<ActionResult<PersonModel>> Put(int id, [FromBody] PersonModel model)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest();
        //        }
        //        return await _personService.UpdateAsync(new PersonModel { FirstName = model.FirstName, LastName = model.LastName });
        //    }


        //    // DELETE api/<RolesController>/5
        //    [HttpDelete("{id}")]
        //    public async Task<ActionResult> Delete(int id)
        //    {
        //        await _personService.DeleteAsync(id);
        //        return NoContent();
        //    }
        //}
    }
}
