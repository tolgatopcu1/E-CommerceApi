using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTO;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly DataContext _context;
        public CartController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<CartDTO>> GetCart()
        {
            var cart = await GetOrCreateCart();

            return CartToCartDTO(cart);
        }
        [HttpPost]
        public async Task<IActionResult> AddItemToCart(int productId, int quantity)
        {
            var cart = await GetOrCreateCart();

            var product = await _context.Products.FindAsync(productId);

            if(product == null) return NotFound();

            cart.AddItem(product, quantity);
            var result = await _context.SaveChangesAsync() > 0;

            if (result)
            {
                return CreatedAtAction("GetCart", CartToCartDTO(cart));
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteItemFromCart(int productId, int quantity)
        {
            var cart = await GetOrCreateCart();

            cart.DeleteItem(productId, quantity);

            var result = await _context.SaveChangesAsync() > 0;

            if (result)
            {
                return CreatedAtAction("GetCart", CartToCartDTO(cart));
            }

            return BadRequest();
        }

        private async Task<Cart> GetOrCreateCart()
        {
            var cart =await _context.Carts
                                        .Include(i => i.CartItems)
                                        .ThenInclude(i=>i.Product)
                                        .Where(i=>i.CustomerId == Request.Cookies["customerId"])
                                        .FirstOrDefaultAsync();

            if(cart==null)
            {
                var customerId = Guid.NewGuid().ToString();

                var cookieOptions =  new CookieOptions {
                    Expires = DateTime.Now.AddMonths(1),
                    IsEssential = true
                };

                Response.Cookies.Append("customerId", customerId, cookieOptions);

                cart= new Cart { CustomerId = customerId };

                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            return cart;
        }

        private CartDTO CartToCartDTO(Cart cart)
        {
            return new CartDTO
            {
                CartId = cart.CartId,
                CustomerId = cart.CustomerId,
                CartItems = cart.CartItems.Select(item => new CartItemDTO{
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Name = item.Product.Name,
                    Price = item.Product.Price,
                    ImageUrl = item.Product.ImageUrl
                }).ToList(),
            };
        }
    }
}