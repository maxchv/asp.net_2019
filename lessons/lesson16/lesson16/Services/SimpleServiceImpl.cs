using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson16.Services
{
    public class SimpleServiceImpl: ISimpleService
    {
        public string Message { get; set; } = "Hello Word";
    }
}
