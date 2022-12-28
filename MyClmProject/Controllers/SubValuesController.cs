using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyClmProject.Model;
using Microsoft.AspNetCore.Http;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;


namespace MyClmProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubValuesController : ControllerBase
    {

        public readonly DbContexts _context;
        public SubValuesController(DbContexts context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("SubPart")]
        public async Task<int>SubPart(SubPart subval)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@FirstName", subval.FirstName));
            parameter.Add(new SqlParameter("@LastName", subval.LastName));
            var result = await Task.Run(() => _context.Database
           .ExecuteSqlRawAsync(@"exec sp_subpart @FirstName,@LastName", parameter.ToArray()));

            return result;


        }
    }
}
