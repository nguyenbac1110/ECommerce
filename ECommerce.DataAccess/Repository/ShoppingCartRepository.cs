using Microsoft.EntityFrameworkCore;
using ECommerce.DataAccess.Data;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;
using ECommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository
{
	public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
	{
		public ShoppingCartRepository(ApplicationDbContext db) : base(db)
		{
		}
		
		public void Update(ShoppingCart shoppingCart)
		{
			_db.Update(shoppingCart);
		}
	}
}
