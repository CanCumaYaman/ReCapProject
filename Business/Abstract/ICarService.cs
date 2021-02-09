﻿using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarService
    {

        List<Car> GetAll();
        
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetByCarId(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
