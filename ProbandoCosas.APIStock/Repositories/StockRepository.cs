using Newtonsoft.Json;
using ProbandoCosas.Core.Models;
using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProbandoCosas.APIStock.Repositories
{
    public class StockRepository : IStockRepository
    {
        private string _path;

        public StockRepository(string path)
        {
            _path = path;
        }

        private List<ProductStock> ReadBBDD()
        {
            string contenidoJson = File.ReadAllText(_path);
            JsonConvert.DeserializeObject<List<ProductStock>>(contenidoJson);
        }

        public ProductStock GetProductById(int id)
        {
            return ReadBBDD().FirstOrDefault < x => x.Id == id >;
        }

        public List<ProductStock> GetProductsStock()
        {
            return ReadBBDD();
        }

        public bool UpdateProduct(ProductStock product)
        {
            List<ProductStock> products = ReadBBDD();
            int i = products.FindIndex(x => x.Id == product.Id);
            if (i != -1)
            {
                products[i] = product;
                string updatedProducts = JsonConvert.SerializeObject(product);
                File.WriteAllText(_path, updatedProducts);
                return true;
            }
            return false;
        }
    }
}