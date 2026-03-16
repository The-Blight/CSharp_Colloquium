using System;
using Workshop.Core.Entities;
using Workshop.Core.Enums;

namespace Workshop.Core.Interfaces;

public interface IStockObserver
{
    Action<Part, int, int, StockOperation> OnStockChanged { get;  }
}