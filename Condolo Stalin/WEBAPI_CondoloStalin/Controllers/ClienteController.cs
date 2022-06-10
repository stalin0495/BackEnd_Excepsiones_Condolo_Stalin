using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI_CondoloStalin.Context;
using WEBAPI_CondoloStalin.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI_CondoloStalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly AppDbContext context;

        public ClienteController(AppDbContext context)
        {
            this.context = context;
        } 

        // GET: api/<ClienteController>
        [HttpGet]

        public ActionResult Get()
        {
            try
            {
                return Ok(context.cliente.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}", Name ="GetCliente")]
        public ActionResult Get(int id)
        {
            try
            {
                var cliente = context.cliente.FirstOrDefault(f => f.CLI_ID == id);
                return Ok(cliente);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            try
            {
                context.cliente.Add(cliente);
                context.SaveChanges();
                return CreatedAtRoute("GetCliente", new { id = cliente.CLI_ID }, cliente);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cliente cliente)
        {
            try
            {
                if (cliente.CLI_ID == id)
                {
                    context.Entry(cliente).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetCliente", new { id = cliente.CLI_ID }, cliente);
                }
                else
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var cliente = context.cliente.FirstOrDefault(f => f.CLI_ID == id);
                if (cliente != null)
                {
                    context.cliente.Remove(cliente);
                    context.SaveChanges();
                    return Ok(id);
                }
                else 
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
