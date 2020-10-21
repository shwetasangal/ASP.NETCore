using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp1.Services
{
    public class HardCodedMessageService : IMessageService
    {
        string IMessageService.GetMessage()
        {
            return "Hard Coded Message from the Service";
        }


    }
}
