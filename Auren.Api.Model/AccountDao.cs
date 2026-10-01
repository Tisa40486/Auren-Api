using Auren.Data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Auren.Api.Model
{

    [Table("BankAccount")]
    public class BankAccountDao : IModelDao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("FK_User")]
        public int UserId { get; set; }
        public UserDao? User { get; set; }
    }
}