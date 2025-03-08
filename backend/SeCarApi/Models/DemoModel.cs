using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeCarApi.Models
{
    public class DemoModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = default!;
        public bool IsComplete { get; set; }
    }
}