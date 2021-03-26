﻿using formulaOneDLL;
using formulaOneDLL.dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace formulaOneWebServices.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class teamController : ControllerBase
    {
        dbTools tools = new dbTools();

        [HttpGet]
        [HttpGet("list")]
        [HttpGet("all")]
        [HttpGet("card")]
        [HttpGet("cards")]
        public IEnumerable<teamCard> Get()
        {
            List<teamCard> list = new List<teamCard>();
            // FARE CHIAMATA A DB (Tramite GetTableByQuery)
            var table = tools.GetTableByQuery("SELECT t.id,t.name,t.logo,t.img,d.firstname, d.lastname FROM Drivers d,Teams t WHERE (t.extFirstDriver=d.id OR t.extSecondDriver=d.id);");
            foreach (DataRow row in table.Rows)
            {
                list.Add(new teamCard(
                        row.Field<int>("id"),
                        row.Field<string>("name"),
                        row.Field<string>("logo"),
                        row.Field<string>("img"),
                        row.Field<string>("firstname"),
                        row.Field<string>("lastname")
                    ));
            }
            return list;
        }
    }
}
