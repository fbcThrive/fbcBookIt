﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FbcBookIt.Entity
{
    partial class Teacher
    {
        [NotMapped]
        public IList<Student> Students { get; set; }
        [NotMapped]
        public IList<BookRequest> BookRequests { get; set; }
    }
}
