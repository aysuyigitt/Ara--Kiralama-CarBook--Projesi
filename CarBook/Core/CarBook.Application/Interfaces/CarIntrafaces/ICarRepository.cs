﻿using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarIntrafaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrand();
        List<Car> GetLast5CarsWithBrands();
        int GetCarCount();

    }
}
