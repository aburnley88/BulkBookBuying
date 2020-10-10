using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BulkBookBuying.DataAccess.Repository.IRepository;
using BulkBookBuying.Models;
using BulkBookBuying.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkBookBuying.Areas.Admin.Controllers
{
   [Area("Admin")]
    public class ProductController : Microsoft.AspNetCore.Mvc.Controller

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            hostEnvironment = webHostEnvironment;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            ProductVm productVm = new ProductVm();
            {
                productVm.Product = new Product();
                productVm.CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
                productVm.CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });

            }

            if (id == null)
            {
                //this is for creating a new product
                return View(productVm);
            }

            productVm.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVm.Product == null)
            {
                return NotFound();
            }

            return View(productVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVm productVm)
        {
            if (ModelState.IsValid)
            {
                //This is for uploading a file. establishes the host enviornment and gets all files in wwwroot\imgs\Products
                string webRootPath = hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"imgs\Products");
                    var extension = Path.GetExtension(files[0].FileName);
                    //if the image url isnt null then this is an edit case rather than a create case
                    if (productVm.Product.ImageUrl != null)
                    {

                        //first delete the image 
                        var imagePath = Path.Combine(webRootPath, productVm.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    using (var fileStreams =
                        new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStreams);
                    }

                    productVm.Product.ImageUrl = @"\imgs\Products\" + fileName + extension;
                }

                else
                {
                    if (productVm.Product.Id != 0)
                    {
                        Product objFromDb = _unitOfWork.Product.Get(productVm.Product.Id);
                        productVm.Product.ImageUrl = objFromDb.ImageUrl;
                    }
                }

                if (productVm.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVm.Product);

                }
                else
                {
                    _unitOfWork.Product.Update(productVm.Product);

                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                {
                    productVm.Product = new Product();
                    productVm.CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem()
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
                    productVm.CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem()
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
                }
                if (productVm.Product.Id != 0)
                {
                    productVm.Product = _unitOfWork.Product.Get(productVm.Product.Id);
                }
            }
            return View(productVm);
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
           
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }
        #endregion
    }
}
    
