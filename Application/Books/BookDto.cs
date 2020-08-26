using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Application.Books {
    public class BookDto {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }

        // [JsonPropertyName ("attendees")]
        public ICollection<BookDto> UserBooks { get; set; }
    }
}