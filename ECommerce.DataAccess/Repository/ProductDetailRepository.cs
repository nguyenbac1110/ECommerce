using Microsoft.EntityFrameworkCore;
using ECommerce.DataAccess.Data;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;
using ECommerce.Models.ViewModels;
using ECommerce.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository
{
	public class ProductDetailRepository : Repository<ProductDetail>, IProductDetailRepository
	{
		public ProductDetailRepository(ApplicationDbContext db) : base(db)
		{
		}

		public void Update(ProductDetail productDetail)
		{
			_db.Update(productDetail);
		}
	}
}
