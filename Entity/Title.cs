﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FbcBookIt.Entity
{
    partial class Title
    {
        [NotMapped]
        public IList<Copy> Copies { get; set; }
        [NotMapped]
        public IList<BookRequest> BookRequests { get; set; }
        [NotMapped]
        public IList<BookLoan> BookLoans { get; set; }
    }
}
