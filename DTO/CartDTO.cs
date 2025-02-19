namespace API.DTO;
public class CartDTO
{
    public int CartId { get; set; }
    public string? CustomerId { get; set; }

    public List<CartItemDTO> CartItems { get; set; } = new();
}