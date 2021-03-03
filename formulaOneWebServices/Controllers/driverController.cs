using formulaOneDLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formulaOneWebServices.Controllers
{
    [Route("api/driver")]
    [ApiController]
    public class driverController : ControllerBase
    {

        dbTools tools = new dbTools();
        // GET: api/<driverController>
        [HttpGet]
        [HttpGet("list")]
        [HttpGet("all")]
        [HttpGet("card")]
        [HttpGet("cards")]
        public IEnumerable<DriverCard> Get()
        {
            List<DriverCard> list = new List<DriverCard>();
            // FARE CHIAMATA A DB (Tramite GetTableByQuery)
            var table  =  tools.GetTableByQuery("SELECT d.firstname,d.lastname,d.id,d.externalCodeCountry,d.img,t.id,t.name FROM Drivers d,Teams t WHERE (t.extFirstDriver=d.id OR t.extSecondDriver=d.id);");
            foreach(DataRow row in table.Rows) {
                list.Add(new DriverCard(
                        row.Field<int>("id"),
                        row.Field<string>("firstname"),
                        row.Field<string>("lastname"),
                        row.Field<string>("name"),
                        row.Field<string>("externalCodeCountry"),
                         $"https://www.countryflags.io/{row.Field<string>("externalCodeCountry")}/flat/64.png",                    
                        row.Field<string>("img"),
                        row.Field<int>("id1")
                    )) ;
            }
            return list;
        }

        // GET api/<driverController>/5
        //Driver details
        [HttpGet("{id}")]
        public string //Driver details; Get(int id)
        {
            return "value";
        }
    }
}
