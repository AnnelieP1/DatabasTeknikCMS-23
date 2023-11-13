using Customer_Embroidery_DataBase.Context;
using Customer_Embroidery_DataBase.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    private readonly DataBase _dataBase;
    public ProductRepository(DataBase dataBase) : base(dataBase)
    {
        _dataBase = dataBase;
    }
}
