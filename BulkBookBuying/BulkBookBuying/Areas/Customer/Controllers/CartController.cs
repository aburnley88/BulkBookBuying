﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BulkBookBuying.DataAccess.Repository.IRepository;
using BulkBookBuying.Models.ViewModels;
using BulkBookBuying.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BulkBookBuying.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<IdentityUser> _userManager;

        public ShoppingCartViewModel ShoppingCartVM {get; set;}

        public CartController(IUnitOfWork unitOfWork, IEmailSender emailSender, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
            _userManager = userManager;

        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ShoppingCartVM = new ShoppingCartViewModel()
            {
                OrderHeader = new Models.Models.OrderHeader(),
                ListCart = _unitOfWork.ShoppingCart.GetAll(u=> u.ApplicationuserId == claim.Value, includeProperties:"Product")
            };
            ShoppingCartVM.OrderHeader.OrderTotal = 0;
            ShoppingCartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUser
            .GetFirstOrDefault(u=> u.Id == claim.Value, 
            includeProperties:"Company");

            foreach (var list in ShoppingCartVM.ListCart)
            {
                list.Price = SD.GetPriceBasedOnQty(list.Count, list.Product.Price, 
                                                 list.Product.Price50, list.Product.Price100);

                ShoppingCartVM.OrderHeader.OrderTotal += (list.Price*list.Count);
                
                list.Product.Description = SD.ConvertToRawHtml(list.Product.Description);
                if(list.Product.Description.Length > 100)
                {
                    list.Product.Description = list.Product.Description.Substring(0,99)+"...";
                }

            }
            return View(ShoppingCartVM);
        }
    }
}
