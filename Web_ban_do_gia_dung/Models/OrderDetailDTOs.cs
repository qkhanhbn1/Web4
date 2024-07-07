namespace Web_ban_do_gia_dung.Models
{
    public class OrderDetailDTOs
    {
        public int Id { get; set; }

        public int OrdersId { get; set; }

        public int SpId { get; set; }

        public string? Quantity { get; set; }

        public decimal? Price { get; set; }

        public decimal? TotalAmount { get; set; }
    }
}
