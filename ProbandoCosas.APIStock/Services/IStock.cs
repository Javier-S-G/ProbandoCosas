using ProbandoCosas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbandoCosas.APIStock.Services
{
    public interface IStock
    {
        List<ProductStock> GetStocks();

        ProductStock GetStockById(int id);

        bool UpdateStock(ProductStock product);

        bool ProductExists(int id);
    }
}