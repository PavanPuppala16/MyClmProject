using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyClmProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace MyClmProject.Model
{
    public class ProductServising : IproductService
    {
        public readonly DbContexts _context;

        public ProductServising()
        {
        }

        public ProductServising(DbContexts context)
        {
            _context = context;
        }
        public   Task<int> AdduserAsync(Registration EmployeeRegistration)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@firstname", EmployeeRegistration.FirstName));
            parameter.Add(new SqlParameter("@lastname", EmployeeRegistration.LastName));
            parameter.Add(new SqlParameter("@dob",Convert.ToDateTime( EmployeeRegistration.DOB)));
            parameter.Add(new SqlParameter("@emailid", EmployeeRegistration.EmailId));
            parameter.Add(new SqlParameter("@mobile", EmployeeRegistration.Mobile));
            parameter.Add(new SqlParameter("@gender", EmployeeRegistration.Gender));
            parameter.Add(new SqlParameter("@address", EmployeeRegistration.Address));
            parameter.Add(new SqlParameter("@designation", EmployeeRegistration.Desigation));
            parameter.Add(new SqlParameter("@typeofwork ", EmployeeRegistration.Typeofwork));
            parameter.Add(new SqlParameter("@picture", EmployeeRegistration.Picture));
            parameter.Add(new SqlParameter("@doj ", Convert.ToDateTime(EmployeeRegistration.DOJ)));
            parameter.Add(new SqlParameter("@password", EmployeeRegistration.Password));
            parameter.Add(new SqlParameter("@status", EmployeeRegistration.Status));
            
            var result = Task.Run(() => _context.Database
           .ExecuteSqlRawAsync(@"exec EmployeeDetailsInsertion @firstname,@lastname,@dob,@emailid,@mobile, @gender,@address,@designation,@typeofwork,@picture,@doj,@password,@status", parameter.ToArray()));

            return result;
            throw new NotImplementedException();
        }
    }

        
}
