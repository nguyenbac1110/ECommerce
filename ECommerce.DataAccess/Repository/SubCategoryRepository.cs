using Microsoft.EntityFrameworkCore;
using ECommerce.DataAccess.Data;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository
{
	public class SubCategoryRepository : Repository<SubCategory>,ISubCategoryRepository
	{
		public SubCategoryRepository(ApplicationDbContext db) : base(db)
		{
		}

		public void Update(SubCategory SubCategory)
		{
			_db.Update(SubCategory);
		}
	}
}
