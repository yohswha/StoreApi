﻿using System;
namespace StoreApi.Models
{
	public interface ICategoryRepository
	{
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> AddAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}

