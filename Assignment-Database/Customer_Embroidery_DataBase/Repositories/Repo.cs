using Customer_Embroidery_DataBase.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Repositories;

internal abstract class Repo<TEntity> where TEntity : class
{
    private readonly DataBase _dataBase;

    protected Repo(DataBase dataBase)
    {
     _dataBase = dataBase; 
    }
    //Create
    
}



