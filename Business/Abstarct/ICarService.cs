﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int carId);
        List<Car> GetByDailyPrice(int min, int max);
        List<CarDetailDto> GetCarDetailDtos();
    }
}
