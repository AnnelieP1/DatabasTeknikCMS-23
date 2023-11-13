using Customer_Embroidery_DataBase.Context;
using Customer_Embroidery_DataBase.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Repositories;

internal class OrderRepository : Repo<OrderEntity>
{
    private readonly DataBase _dataBase;
    public OrderRepository(DataBase dataBase) : base(dataBase)
    {
        _dataBase = dataBase;
    }
}
