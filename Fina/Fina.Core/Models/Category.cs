﻿namespace Fina.Core.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Descripton { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}