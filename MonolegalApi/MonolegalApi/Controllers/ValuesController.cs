<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonolegalApi.BL;

namespace MonolegalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFacturacionProceso _FacturacionProceso;
        public ValuesController(IFacturacionProceso FacturacionProceso)
        {
            _FacturacionProceso = FacturacionProceso;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<bool> Get()
        {
            return _FacturacionProceso.ReturnToDefault();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            _FacturacionProceso.ValidarPagosTodos();
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonolegalApi.BL;

namespace MonolegalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFacturacionProceso _FacturacionProceso;
        public ValuesController(IFacturacionProceso FacturacionProceso)
        {
            _FacturacionProceso = FacturacionProceso;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<bool> Get()
        {
            return _FacturacionProceso.ReturnToDefault();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            _FacturacionProceso.ValidarPagosTodos();
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
>>>>>>> 9bd5cb3e33341e4627f0d1eab90da82dc9784e56
