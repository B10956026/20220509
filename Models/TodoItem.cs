using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20220509.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; } // 防止過度張貼
    }
}
