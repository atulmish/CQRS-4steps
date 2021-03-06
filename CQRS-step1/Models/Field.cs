﻿using System.Collections.Generic;

namespace CQRS_step1.Models
{
    public class Field
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }

    public class IntegerField : Field { }

    public class StringField : Field { }

    // etc.
}