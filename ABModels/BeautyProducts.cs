using System;

namespace ABModels
{
    /// <summary>
    /// This class contains all necessary field to define a product.
    /// </summary>
    public class BeautyProducts
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Brands { get; set; }
        public string Types { get; set; }
        public string Color { get; set; }
        public string Sizes { get; set; }
        public string Description { get; set; }

    }
}