using formulaOneDLL;
using formulaOneDLL.dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace formulaOneWebServices.Controllers
{
    [Route("api/circuit")]
    [ApiController]
    public class circuitController : ControllerBase
    {
        dbTools tools = new dbTools();

        [HttpGet]
        [HttpGet("list")]
        [HttpGet("all")]
        [HttpGet("card")]
        [HttpGet("cards")]
        public IEnumerable<circuitCard> Get()
        {
        List<circuitCard> list = new List<circuitCard>();
            // FARE CHIAMATA A DB (Tramite GetTableByQuery)
            var table = tools.GetTableByQuery("SELECT r.date,c.CountryCode,c.CountryCode,r.name,ci.img FROM Races r, Country c, Circuits ci WHERE r.extCircuit=ci.id and ci.extCountry=c.CountryCode;");
            foreach (DataRow row in table.Rows)
            {
                list.Add(new circuitCard(
                        row.Field<string>("date"),
                        row.Field<string>("CountryCode"),
                        row.Field<string>("CountryName"),
                        row.Field<string>("name"),
                        row.Field<string>("img")
                    ));
            }
            return list;
        }
    }
}
