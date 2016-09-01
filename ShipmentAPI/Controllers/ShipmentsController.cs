using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShipmentAPI.Models;

namespace ShipmentAPI.Controllers
{
    [Authorize]
    public class ShipmentsController : ApiController
    {
        // GET api/values
        public IEnumerable<Shipment> Get()
        {
            return Shipment.Create();
        }

        // GET api/values/5
        public Shipment Get(int id)
        {
            return Shipment.Create().First(x => x.Id == id);
        }

        // POST api/values
        public void Post([FromBody]Shipment value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
