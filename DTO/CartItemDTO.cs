namespace API.DTO;
public class CartItemDTO
{

    public int Quantity { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public int ProductId { get; set; }

}