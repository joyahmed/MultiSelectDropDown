using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSelectDropDown.Models
{
    public class StudentViewModel
    {
        public IEnumerable<SelectListItem> Student { get; set; }
        public IEnumerable<string> SelectedStudents { get; set; }
    }
}
