﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }

        [JsonIgnore]
        public Brand Brand { get; set; }
        public string CarName { get; set; }
        public int Year { get; set; }
        public int CategoryID { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }
        public string Image { get; set; }
        public string Gear { get; set; }
        public int km { get; set; }
        public byte PersonCount { get; set; }
        public string GasType { get; set; }
        public bool Status { get; set; }
        public decimal RentPrice { get; set; }
        public List<Price> Prices { get; set; }
        public int CarStatusID { get; set; }

        [JsonIgnore]
        public CarStatus CarStatus { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDetail> CarDetails { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
