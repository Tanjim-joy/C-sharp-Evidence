﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceXm
{
    public interface IExteriorFeature
    {
        void AddFeature(string[] feature);
        string GetFeature();
    }
}
