﻿using DellChallenge.D2.Web.Models;
using DellChallenge.D2.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DellChallenge.D2.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _productService.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewProductModel newProduct)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(newProduct);
                return RedirectToAction("Index");
            }

            return View(newProduct);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {            
            var product = _productService.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                _productService.Edit(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}