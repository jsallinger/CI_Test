using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamServiceWebApp.Models;

namespace TeamServiceWebApp.Controllers
{
    public class WidgetController
    {
        public bool IncrementItemNumber(WidgetModel widget)
        {
            bool isIncremented = false;

            int startItemNumber = widget.ItemNumber;
            widget.ItemNumber++;
            if (startItemNumber < widget.ItemNumber)
                isIncremented = true;

            return isIncremented;
        }
    }
}
