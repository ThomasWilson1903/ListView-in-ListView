﻿using System;
using System.Collections.Generic;

namespace WpfApp1.DataBase.Entity
{
    public partial class EducationalClass
    {
        public EducationalClass()
        {
            Students = new HashSet<Student>();
        }

        public int Idgroup { get; set; }
        public string? ClassNumber { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
