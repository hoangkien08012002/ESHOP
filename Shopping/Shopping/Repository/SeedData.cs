using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModel macbook = new CategoryModel
				{
					Name = "apple",
					Slug = "apple",
					Description = "Apple is a good product",
					status = 1
				};
				CategoryModel pc = new CategoryModel
				{
					Name = "PC",
					Slug = "PC",
					Description = "PC is a good product",
					status = 1
				};
				BrandModel apple = new BrandModel
				{
					Name = "apple",
					Slug = "apple",
					Description = "apple is a large Brand",
					status = 1
				};
				BrandModel samsung = new BrandModel
				{
					Name = "samsung",
					Slug = "samsung",
					Description = "samsung is a large Brand",
					status = 1
				};
				_context.Products.AddRange(
					new ProductModel {Name = "macbook", Slug="macbook", Description="Macbook is best", Image = "1.jpg" , Category=macbook, Brand=apple,Price=1234},
					new ProductModel {Name = "PC", Slug="PC", Description="PC is best", Image = "1.jpg" , Category=pc, Brand=samsung,Price=1456}
				);
				_context.SaveChanges();

			}
		}
	}
}

