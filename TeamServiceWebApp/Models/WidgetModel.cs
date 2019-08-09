using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamServiceWebApp.Models
{
    public class WidgetModel
    {
        public WidgetModel()
        {
            Description = string.Empty;
            ItemNumber = 0;
            IsActive = true;
        }

        public string Description { get; set; }
        public int ItemNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
