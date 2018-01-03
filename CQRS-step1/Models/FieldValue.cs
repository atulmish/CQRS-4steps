﻿namespace CQRS_step1.Models
{
    public class FieldValue
    {
        public int FieldId { get; set; }

        public Field Field { get; set; }
    }

    public class IntegerFieldValue : FieldValue
    {
        public int IntegerValue { get; set; }
    }

    public class StringFieldValue : FieldValue
    {
        public string StringValue { get; set; }
    }

    // etc.
}