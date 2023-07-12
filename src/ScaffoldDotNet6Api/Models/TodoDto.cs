using System;

namespace ScaffoldDotNet6Api.Controllers.Models
{
    public class TodoDto
    {
        public string TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}