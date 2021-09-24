﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walks> GetAll();
        List<Walks> GetWalksByWalkerId(int walkerId);
    }
}
