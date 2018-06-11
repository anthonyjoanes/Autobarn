
using System;
using System.Linq;
using System.Runtime.Caching;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Services.Filters
{
    public class ReviewInfoFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //var reviewText = MemoryCache.Default.Get("Review") as string;

            //if (string.IsNullOrEmpty(reviewText))
            //{
            //    var repository = (IRepository<Review>)DependencyResolver.Current.GetService(typeof(IRepository<Review>));

            //    var review = repository.GetAll().FirstOrDefault();

            //    if (review != null)
            //        MemoryCache.Default.Add("Review", review.Text, DateTimeOffset.MaxValue);

            //    base.OnActionExecuting(filterContext);
            //}



            
        }
    }
}