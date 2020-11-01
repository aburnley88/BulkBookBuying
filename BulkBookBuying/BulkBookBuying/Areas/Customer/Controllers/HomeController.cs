﻿using System.Collections.Generic;
using System.Diagnostics;
using BulkBookBuying.DataAccess.Repository.IRepository;
using BulkBookBuying.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BulkBookBuying.Models.ViewModels;
using BulkBookBuying.Models.Models;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Linq;
using BulkBookBuying.Utility;

namespace BulkBookBuying.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
        //    System.Console.WriteLine(( _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType").GetType())); 
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }
         public IActionResult Details(int id)
         {
            
            var productFromDb = _unitOfWork.Product.GetFirstOrDefault(u=> u.Id == id, includeProperties:"Category,CoverType");

            
                ShoppingCart cartObject = new ShoppingCart()
                {
                    Product = productFromDb,
                    ProductId = productFromDb.Id
                };

            return View(cartObject);
         }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
            public IActionResult Details(ShoppingCart CartObject)
            {
                CartObject.Id = 0;
                if (ModelState.IsValid)
                {
                    //the we will add to cart
                    var claimsIdentity = (ClaimsIdentity)User.Identity;
                    var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                    CartObject.ApplicationuserId = claim.Value;
                    
                    ShoppingCart customerCart = _unitOfWork.ShoppingCart.GetFirstOrDefault(
                        u=>u.ApplicationuserId== CartObject.ApplicationuserId && u.ProductId == CartObject.ProductId
                        ,includeProperties:"Product"
                        );

                    if (customerCart == null)
                    {
                        _unitOfWork.ShoppingCart.Add(CartObject);

                    }
                    else
                    {
                        customerCart.Count+= CartObject.Count;
                        _unitOfWork.ShoppingCart.Update(customerCart);

                    }
                    _unitOfWork.Save();
                    var count = _unitOfWork.ShoppingCart.GetAll(c=>c.ApplicationuserId == CartObject.ApplicationuserId)
                        .ToList().Count();

                    HttpContext.Session.SetObject(SD.ssShoppingCart, count);
                    return RedirectToAction(nameof(Index));
                    

                }
                else
                {
                    var productFromDb = _unitOfWork.Product.
                        GetFirstOrDefault(u=> u.Id == CartObject.ProductId, includeProperties:"Category,CoverType");
           
                    ShoppingCart cartObject = new ShoppingCart()
                    {
                        Product = productFromDb,
                        ProductId = productFromDb.Id
                    };
                return View(cartObject);

                }
           
            }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
