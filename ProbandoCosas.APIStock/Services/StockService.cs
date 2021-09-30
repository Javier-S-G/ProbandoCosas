using ProbandoCosas.APIStock.Repositories;
using ProbandoCosas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbandoCosas.APIStock.Services
{
    public class StockService : IStock
    {
        private IStockRepository _stockService;

        public ProductStock GetStockById(int id)
        {
            return _stockService.GetProductById(id);
        }

        public List<ProductStock> GetStocks()
        {
            return _stockService.GetProductsStock();
        }

        public bool ProductExists(int id)
        {
            var stocks = _stockService.GetProductsStock();
            var item = stocks.FirstOrDefault(x => x.Id == id);
            return item != null;
        }

        public bool UpdateStock(ProductStock product)
        {
            throw new NotImplementedException();
        }
    }
}