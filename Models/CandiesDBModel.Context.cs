﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetCandyStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CandiesDBEntities : DbContext
    {
        public CandiesDBEntities()
            : base("name=CandiesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<StatusCode> StatusCodes { get; set; }
        public virtual DbSet<vwProduct> vwProducts { get; set; }
        public virtual DbSet<vwShoppingCart> vwShoppingCarts { get; set; }
        public virtual DbSet<vwShoppingCartItem> vwShoppingCartItems { get; set; }
    
        public virtual ObjectResult<GetProductsByCategoryId_Result> GetProductsByCategoryId(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsByCategoryId_Result>("GetProductsByCategoryId", categoryIdParameter);
        }
    
        public virtual int AddToCart(string cartGUID, Nullable<int> productId, Nullable<decimal> productPrice, Nullable<int> quantity, Nullable<byte> statusCode)
        {
            var cartGUIDParameter = cartGUID != null ?
                new ObjectParameter("cartGUID", cartGUID) :
                new ObjectParameter("cartGUID", typeof(string));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            var productPriceParameter = productPrice.HasValue ?
                new ObjectParameter("productPrice", productPrice) :
                new ObjectParameter("productPrice", typeof(decimal));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var statusCodeParameter = statusCode.HasValue ?
                new ObjectParameter("statusCode", statusCode) :
                new ObjectParameter("statusCode", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddToCart", cartGUIDParameter, productIdParameter, productPriceParameter, quantityParameter, statusCodeParameter);
        }
    
        public virtual ObjectResult<GetShoppingCartItems_Result> GetShoppingCartItems(string cartGUID)
        {
            var cartGUIDParameter = cartGUID != null ?
                new ObjectParameter("cartGUID", cartGUID) :
                new ObjectParameter("cartGUID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShoppingCartItems_Result>("GetShoppingCartItems", cartGUIDParameter);
        }
    
        public virtual int CreateShoppingCart(string cartGUID, Nullable<byte> status)
        {
            var cartGUIDParameter = cartGUID != null ?
                new ObjectParameter("cartGUID", cartGUID) :
                new ObjectParameter("cartGUID", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateShoppingCart", cartGUIDParameter, statusParameter);
        }
    
        public virtual int CalculateCartTotal(string cartGUID)
        {
            var cartGUIDParameter = cartGUID != null ?
                new ObjectParameter("cartGUID", cartGUID) :
                new ObjectParameter("cartGUID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalculateCartTotal", cartGUIDParameter);
        }
    
        public virtual ObjectResult<GetShoppingCart_Result> GetShoppingCart(string cartGUID)
        {
            var cartGUIDParameter = cartGUID != null ?
                new ObjectParameter("cartGUID", cartGUID) :
                new ObjectParameter("cartGUID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShoppingCart_Result>("GetShoppingCart", cartGUIDParameter);
        }
    
        public virtual ObjectResult<GetProductsBySearch_Result> GetProductsBySearch(string searchTerm)
        {
            var searchTermParameter = searchTerm != null ?
                new ObjectParameter("searchTerm", searchTerm) :
                new ObjectParameter("searchTerm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsBySearch_Result>("GetProductsBySearch", searchTermParameter);
        }
    }
}
