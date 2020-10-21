using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TestApp1.Services
{
    public class ConfigurationMessageService : IMessageService
    {
        private IConfiguration _Configuration;
        public ConfigurationMessageService(IConfiguration configuration)
        {
            _Configuration = configuration;
        }
        string IMessageService.GetMessage()
        {
            return _Configuration["Message"];
        }
    }
}
