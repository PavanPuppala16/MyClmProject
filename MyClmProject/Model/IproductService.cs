using MyClmProject.Model;
namespace MyClmProject.Model
{
    public  interface  IproductService
    {  
        public  Task<int> AdduserAsync(Registration register);
     
    }
}
