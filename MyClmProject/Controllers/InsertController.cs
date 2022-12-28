using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using MyClmProject.Model;

namespace MyClmProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        ProductServising obj = new ProductServising();
        public readonly DbContexts _context;
        public InsertController(DbContexts context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("AddUsersAsync")]
        public async Task<IActionResult> AddUsersAsync(Registration register)
        {
            if (register == null)
            {
                return BadRequest();
            }

            try
            {
                var response = await obj.AdduserAsync(register);

                return Ok(response);
            }
            catch
            {
                throw;
            }
        }



























        //[HttpPost("Registration")]
        //public async Task<IActionResult> AddProductAsync(Registration Registration)
        //{
        //    if (Registration == null)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        var response = await _context.Add();

        //        return Ok(response);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}



        //[HttpPost]
        //public async Task<int> PutEmployeeRegistration(Registration EmployeeRegistration)
        //{
        //    var parameter = new List<SqlParameter>();
        //    parameter.Add(new SqlParameter("@firstname", EmployeeRegistration.FirstName));
        //    parameter.Add(new SqlParameter("@lastname", EmployeeRegistration.LastName));
        //    parameter.Add(new SqlParameter("@dob", EmployeeRegistration.DOB));
        //    parameter.Add(new SqlParameter("@emailid", EmployeeRegistration.EmailId));
        //    parameter.Add(new SqlParameter("@mobile", EmployeeRegistration.Mobile));
        //    parameter.Add(new SqlParameter("@gender", EmployeeRegistration.Gender));
        //    parameter.Add(new SqlParameter("@address", EmployeeRegistration.Address));
        //    parameter.Add(new SqlParameter("@designation", EmployeeRegistration.Desigation));
        //    parameter.Add(new SqlParameter("@typeofwork ", EmployeeRegistration.Typeofwork));
        //    parameter.Add(new SqlParameter("@picture", EmployeeRegistration.Picture));
        //    parameter.Add(new SqlParameter("@doj ", EmployeeRegistration.DOJ));
        //    parameter.Add(new SqlParameter("@password", EmployeeRegistration.Password));
        //    parameter.Add(new SqlParameter("@status", EmployeeRegistration.Status));





        //    var result = await Task.Run(() => _context.Database
        //   .ExecuteSqlRawAsync(@"exec EmployeeDetailsInsertion @firstname,@lastname,@dob,@emailid,@mobile, @gender,@address,@designation,@typeofwork,@picture,@doj,@password,@status",parameter.ToArray()));

        //    return result;
    }
}