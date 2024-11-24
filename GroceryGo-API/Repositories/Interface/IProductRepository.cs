﻿using GroceryGo_API.Entities;

namespace Shop_API.Repository.Interface
{
    public interface IProductRepository
    {
        Task<List<Category>> GetCategoriesAsync();
    //    Task<List<ProductModel>> GetProductsAsync(GetProductModelRequest request);
    //    Task<List<CategoryModel>> GetSubCategoriesAsync(int categroyId);
    //    Task SaveProductsAsync(SaveProductRequest request);
    //    Task UpdateProductsAsync(ProductModel request);
    //    Task DeleteProductsAsync(int productId);
    //    Task<ProductModel> GetProductByIdAsync(int productId);
    //    Task<CategoryModel> GetCategoryBySubcategory(int subCategoryId);
    //    Task<SubcategoryModel> GetSubcategoryById(int subCategoryId);
    }
}
