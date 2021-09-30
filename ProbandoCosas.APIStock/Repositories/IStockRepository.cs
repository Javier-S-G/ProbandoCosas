using ProbandoCosas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbandoCosas.APIStock.Repositories
{
    public interface IStockRepository
    {
        List<ProductStock> GetProductsStock();

        ProductStock GetProductById(int id);

        bool UpdateProduct(ProductStock product);
    }
}