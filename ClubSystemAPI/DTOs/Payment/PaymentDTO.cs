namespace ClubSystemAPI.DTOs.Payment
{
    internal class PaymentDTO
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
    }
}