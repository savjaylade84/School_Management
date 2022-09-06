using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprog2Project
{
    class Teacher : ITeacher
    {
        public string ProfessorID { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string FullName { get { return LastName + "," + FirstName + MiddleName[0]; } }
        public string Email { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Password { get ; set; }
        public string username { get; set ; }
        public string ProfilePic { get; set; }
    }

    }

