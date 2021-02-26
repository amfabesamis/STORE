using System;

namespace ABModels
{
    /// <summary>
    /// This class contains all the fields and properties that define a store location.
    /// Include WHAT PRODUCTS ARE AVAILABLE IN THIS LOCATION AND HOW MUCH OF THESE PRODUCTS ARE AVAILABLE
    /// </summary>
    public class Location
    {
        public string Address { get; set; }
        public string LocationName { get; set; }
        //TODO: add some property for the location inventory
    }
}