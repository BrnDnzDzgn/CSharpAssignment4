using BLL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record { get; set; } //has a relationship

        public int Id => Record.Id;
        public string Name => Record.Name;
        public string Surname => Record.Surname;
        public DateTime? BirthDate => Record.BirthDate;
        public decimal? Gpa => Record.Gpa;

    }
}
