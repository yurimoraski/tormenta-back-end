using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Teste.Interface;
using DataTransfer.Teste.Request;
using DataTransfer.Teste.Response;
using Microsoft.AspNetCore.Mvc;

namespace Web.RPG.Controllers.Teste
{
    [Route("api/[controller]")]
    public class TesteController : Controller
    {

        private readonly ITesteAppServico testeAppServico;

        public TesteController(ITesteAppServico testeAppServico)
        {
            this.testeAppServico = testeAppServico;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<TesteResponse> Get(TesteRequest testeRequest)
        {
            TesteResponse testeResponse = testeAppServico.TesteDoAppServico(testeRequest);
            return Ok(testeResponse);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
