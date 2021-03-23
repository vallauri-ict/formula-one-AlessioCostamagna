using formulaOneDLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace formulaOneWebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class teamController : ControllerBase
    {
        dbTools tools = new dbTools();

        [HttpGet]
        [HttpGet("list")]
        [HttpGet("all")]
        [HttpGet("card")]
        [HttpGet("cards")]
        public IEnumerable<DriverCard> Get()
        {
            List<DriverCard> list = new List<DriverCard>();
            // FARE CHIAMATA A DB (Tramite GetTableByQuery)
            var table = tools.GetTableByQuery("SELECT t.id,t.name,t.logo,t.img,t., FROM Drivers d,Teams t WHERE (t.extFirstDriver=d.id OR t.extSecondDriver=d.id);");
            foreach (DataRow row in table.Rows)
            {
                list.Add(new DriverCard(
                        row.Field<int>("id"),
                        row.Field<string>("firstname"),
                        row.Field<string>("lastname"),
                        row.Field<string>("name"),
                        row.Field<string>("externalCodeCountry"),
                         $"https://www.countryflags.io/{row.Field<string>("externalCodeCountry")}/flat/64.png",
                        row.Field<string>("img"),
                        row.Field<int>("id1")
                    ));
            }
            return list;
        }
    }
}
