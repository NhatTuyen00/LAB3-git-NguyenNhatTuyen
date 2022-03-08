using DemoAPI.Models;
using Lib.Entity;
using Lib.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TKController : ControllerBase
    {
        private TKservice tkService;
        public TKController(TKservice tkService)
        {
            this.tkService = tkService;
        }

        [HttpGet("get-tk")]
        public async Task<ActionResult> GetTK()
        {
            return Ok(new { status = true, data = tkService.GetTKList() });
        }

        [HttpPost("insert-tk")]
        public async Task<ActionResult> InsertTK(TKModel tK)
        {
            TK taik = new TK();
            taik.taikhoan = tK.taikhoan;
            taik.matkhau = tK.matkhau;
            taik.quyen = tK.quyen;
            taik.ten = tK.ten;
            taik.sdt = tK.sdt;
            taik.tien = tK.tien;
            taik.vitri = tK.vitri;

            tkService.InsertTK(taik);
            return Ok(new { status = true, messagae = "success"});
        }
    }
}
