﻿using System;
using System.Collections.Generic;

namespace WpfApp1.DataBase.Entity
{
    public partial class Teacher
    {
        public Teacher()
        {
            ListItems = new HashSet<ListItem>();
            Sections = new HashSet<Section>();
        }

        public int IdTeachers { get; set; }
        public string NameTeacher { get; set; } = null!;
        public string SurnameTeacher { get; set; } = null!;
        public string MiddleNameTeacher { get; set; } = null!;
        public byte[]? Photo { get; set; }
        public DateOnly DateBirth { get; set; }
        public DateOnly DateWork { get; set; }
        public int? OfficeNumber { get; set; }
        public byte[]? PhotoTeachers { get; set; }

        public virtual ICollection<ListItem> ListItems { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
