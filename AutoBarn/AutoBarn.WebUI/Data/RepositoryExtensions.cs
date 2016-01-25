using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Data
{
    public static class RepositoryExtensions
    {
        public static IList<Model> GetFullVehicleModel(this IRepository<Model> repository)
        {
            return repository.GetAll()
                .Include(x => x.Make)
                .Include(x => x.Services).ToList();
        } 
    }
}