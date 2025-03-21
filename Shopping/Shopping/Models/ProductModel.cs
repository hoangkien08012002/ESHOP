﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "yeu cau nhap ten san pham")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "yeu cau nhap mo ta san pham")]
		public string Description { get; set; }
		[Required, MinLength(4, ErrorMessage = "yeu cau nhap gia san pham")]
		public decimal Price { get; set; }
		public string Slug {  get; set; }
		public int BranId {  get; set; }
		public int CategoryId {  get; set; }

		public CategoryModel Category { get; set; }
		public BrandModel Brand { get; set; }
		public string Image {  get; set; }
	}
}
