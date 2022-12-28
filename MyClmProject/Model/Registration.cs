using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyClmProject.Model;

namespace MyClmProject.Model
{
    public class Registration
    {
        [Key]
        public int RecordId { get; set; }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string EmailId { get; set; }
        public long Mobile { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Desigation { get; set; }
        public string Typeofwork { get; set; }
        public string Picture { get; set; }
        public DateTime DOJ { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

    }
    public class SubPart
    {
        //[Key]
        //public int RecordId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}

