﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppArch.Domain.Entities;

namespace AppArch.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
