using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
	public class CategoryModel
	{
		[Key]
		public int Id { get; set; }
		[Required,MinLength(4, ErrorMessage ="yeu cau nhap ten danh muc")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "yeu cau nhap mo ta")]
		public string Description { get; set; }
		[Required]
		public string Slug { get; set; }
		public int status {  get; set; }
	}
}
