﻿using Microsoft.EntityFrameworkCore;
using ECommerce.DataAccess.Data;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository
{
	public class ItemRepository : Repository<Item>, IItemRepository
	{
		public ItemRepository(ApplicationDbContext db) : base(db)
		{
		}
		
		public void Update(Item item)
		{
			_db.Update(item);
		}
	}
}
