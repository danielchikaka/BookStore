using System;
namespace Domain {
    public class UserBook {
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsHost { get; set; }

    }
}