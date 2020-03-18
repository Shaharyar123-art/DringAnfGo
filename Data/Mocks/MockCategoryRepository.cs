using DringsAndGo.Data.Interfaces;
using DringsAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DringsAndGo.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                { new Category{ CategoryName="Alcoholic", Description="All Alcohol Drinks"},
                    new Category { CategoryName="Non-Alcoholic", Description="All Non-Alcoholic Drinks"},

                };
            }
        }
    }
}
