﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SghBridgeContract.Interfaces.Component
{
    /// <summary>
    /// This inteface is implemented by libraries that exchange data with bridge Framework
    /// </summary>
    public interface IModelHandler
    {
        bool IsInitiated { get; set; }

        void SetModel(IModelDTO mo);
        IModelDTO GetModel();

        void  SetPoint(IPointDTO p);
        IPointDTO GetPoint(string Id);

        void SetAllPoints(List<IPointDTO> Ipoints);
        List<IPointDTO> GetAllPoints();

    }
}
