using System;
using Microsoft.EntityFrameworkCore;

namespace StoreApi.Models
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<Supplier> AddAsync(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
            return supplier;
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();

            throw new NotImplementedException();
        }

        public Task<Supplier> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FindAsync(id);

            throw new NotImplementedException();
        }

        public Task<Supplier> UpdateAsync(Supplier supplier)
        {
            _context.Entry(supplier).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return supplier;
            throw new NotImplementedException();
        }
    }
}




