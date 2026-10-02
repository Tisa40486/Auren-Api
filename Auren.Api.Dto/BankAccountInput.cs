namespace Auren.Api.Dto
{
    public class BankAccountInput
    {
        public required string Name { get; set; }
        public int UserId { get; set; }
        public float Balance { get; set; } = 0;
    }
}
