using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Service;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IShoppingCartService _service;
        public ListController(IShoppingCartService service){
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var items =  _service.GetAllItems();
            return Ok(items);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Item newItem)
        {   
            try
            {
                _service.Add(newItem);
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
