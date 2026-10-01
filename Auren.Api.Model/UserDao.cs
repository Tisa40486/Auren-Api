using Auren.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auren.Api.Model
{

    [Table("Users")]
    public class UserDao : IModelDao
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public bool Updated { get; set; }

    }
}
