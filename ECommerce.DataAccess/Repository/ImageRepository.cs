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
	public class ImageRepository : Repository<Image>, IImageRepository
	{
		public ImageRepository(ApplicationDbContext db) : base(db)
		{
		}

		public void Update(Image Image)
		{
			_db.Update(Image);
		}
	}
}
