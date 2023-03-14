﻿using System;

namespace Models.DogfoodCompanyTypes
{
    [Serializable]
    public class Inventory
    {
        public int ProductID { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString() => $"Product {ProductID}, Number in stock {NumberInStock}";
    }
}
