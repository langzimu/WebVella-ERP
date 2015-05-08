﻿using System;

namespace WebVella.ERP.Api.Models
{
    public class TextField : Field
    {
        public static FieldType FieldType { get { return FieldType.TextField; } }

        public string DefaultValue { get; set; }

        public int? MaxLength { get; set; }
    }

    public class TextFieldMeta : TextField
    {
		public Guid EntityId { get; set; }

		public string EntityName { get; set; }
    }
}