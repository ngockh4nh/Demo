using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string? Name { get; set; }

        [System.ComponentModel.DisplayName("Mô tả")]
        public string? Description { get; set; }
        public string? ImageUrl {  get; set; }

        [System.ComponentModel.DisplayName("Giá tiền")]
        public decimal Price { get; set; }

        [System.ComponentModel.DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [ForeignKey("Category")]
        [System.ComponentModel.DisplayName("Loại sản phẩm")]
        public int CategoryId { get; set; }
        public virtual Category? category { get; set; }
    }
}
