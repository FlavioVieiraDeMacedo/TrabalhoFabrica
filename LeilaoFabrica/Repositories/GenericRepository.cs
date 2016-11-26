using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeilaoFabrica.Repositories
{
    public class GenericRepository<T> : IGenericRespoitory<T> where T : class 
    {
    }
}