using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMexInterrogator.BitMex.Controllers
{
    public class UIDoodads
    {
        public string[] getColumnSelections()
        {
            // Get the properties of the Instrument class
            var instrumentProperties = typeof(Instrument).GetProperties();

            // Extract the property names as an array of strings
            var propertyNames = instrumentProperties.Select(property => property.Name).ToArray();

            return propertyNames;
        }

    }
}
