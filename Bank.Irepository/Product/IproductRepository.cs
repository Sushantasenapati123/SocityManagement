using Bank.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.Product
{
    public interface IproductRepository
    {
        public Task<IEnumerable<ProductEntity>> listproduct();
        public Task<IEnumerable<ProductEntity>> listsubcat();
        public Task<IEnumerable<ProductEntity>> listcat();
        public int insertProduct(ProductEntity rl);
        public int insertsales(ProductEntity rl);
       
    }
}
