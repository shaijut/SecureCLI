using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using SecureCliAPI.Models;

namespace SecureCliAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchSecureAPIController : ControllerBase
    {
    
        private readonly ILogger<SearchSecureAPIController> _logger;

        public SearchSecureAPIController(ILogger<SearchSecureAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{secure}")]
        public object Get(string domain)
        {

            var client = new MongoClient("mongodb+srv://YourUserName:YourPassWord@example.example.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");

            var database = client.GetDatabase("YourDB");

            var secureCollection = database.GetCollection<Secure>("YourCollection"); 

            var secureData = secureCollection.Find(data => data.Link == domain).FirstOrDefault();

            bool isSecureDomain = secureData != null ? secureData.IsSecure : false;

            var returnData = new 
                {
                isSecure = isSecureDomain, 
                Message = isSecureDomain ? "Secure to use" : "Not Secure to use"
                };
    
            return returnData;

        }
    }
}
