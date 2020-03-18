using DringsAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DringsAndGo.Data.Interfaces
{
   public interface ICategoryRepository
    { 
        IEnumerable<Category> Categories { get; }
    }
}
