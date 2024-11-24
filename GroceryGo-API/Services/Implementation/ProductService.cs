﻿//using Azure.Core;
//using GroceryGo_API.Entities;
//using GroceryGo_API.Services.Interface;
//using Shop_API.Models.Product;
//using Shop_API.Repository.Interface;

//namespace Shop_API.BusinessLogic.Implementation
//{
//    public class ProductService(IProductRepository productRepository) : IProductService
//    {
//        public required IProductRepository ProductRepository { get; set; } = productRepository;

//        public async Task<List<Category>> GetCategoriesAsync()
//        {
//            return await ProductRepository.GetCategoriesAsync();
//        }

//        public async Task<List<ProductModel>> GetProductsAsync(GetProductModelRequest request)
//        {
//            var products = await _productRepository.GetProductsAsync(request);
//            return products;
//        }

//        public async Task<List<CategoryModel>> GetSubCategoriesAsync(int categroyId)
//        {
//            var subCategories = await _productRepository.GetSubCategoriesAsync(categroyId);
//            return subCategories;
//        }

//        public async Task SaveProductsAsync(SaveProductRequest request)
//        {
//            await _productRepository.SaveProductsAsync(request);
//        }

//        public async Task UpdateProductsAsync(ProductModel request)
//        {
//            await _productRepository.UpdateProductsAsync(request);
//        }

//        public async Task DeleteProductsAsync(int productId)
//        {
//            await _productRepository.DeleteProductsAsync(productId);
//        }

//        public async Task<ProductModel> GetProductByIdAsync(int productId)
//        {
//            var product = await _productRepository.GetProductByIdAsync(productId);
//            return product;
//        }

//        public async Task<CategoryModel> GetCategoryBySubcategory(int subCategoryId)
//        {
//            var category = await _productRepository.GetCategoryBySubcategory(subCategoryId);
//            return category;
//        }

//        public async Task<SubcategoryModel> GetSubcategoryById(int subCategoryId)
//        {
//            var category = await _productRepository.GetSubcategoryById(subCategoryId);
//            return category;
//        }
//    }
//}
