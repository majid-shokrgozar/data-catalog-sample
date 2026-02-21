using System;
using System.ComponentModel.DataAnnotations;

namespace ProductService.Entities
{
    /// <summary>
    /// Product Entity class representing products in the e-commerce system
    /// 
    /// Database Table: products
    /// Schema: dbo
    /// Created: 2026-02-21
    /// Owner: Product Management Team
    /// </summary>
    public class ProductEntity
    {
        /// <summary>
        /// Unique identifier for the product
        /// Column Name: product_id
        /// Data Type: UNIQUEIDENTIFIER (Primary Key)
        /// Nullable: false
        /// Description: Unique identifier generated at product creation
        /// </summary>
        [Key]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Product SKU (Stock Keeping Unit)
        /// Column Name: sku
        /// Data Type: NVARCHAR(100)
        /// Nullable: false
        /// Unique: true
        /// Description: Unique stock keeping unit for inventory management
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Sku { get; set; }

        /// <summary>
        /// Product name
        /// Column Name: product_name
        /// Data Type: NVARCHAR(255)
        /// Nullable: false
        /// Description: Display name of the product
        /// </summary>
        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        /// <summary>
        /// Detailed product description
        /// Column Name: description
        /// Data Type: NVARCHAR(MAX)
        /// Nullable: true
        /// Description: Long text description of the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Product price
        /// Column Name: price
        /// Data Type: DECIMAL(10,2)
        /// Nullable: false
        /// Description: Current selling price of the product
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Product cost
        /// Column Name: cost
        /// Data Type: DECIMAL(10,2)
        /// Nullable: false
        /// Description: Cost price of the product
        /// </summary>
        [Required]
        public decimal Cost { get; set; }

        /// <summary>
        /// Current stock quantity
        /// Column Name: stock_quantity
        /// Data Type: INT
        /// Nullable: false
        /// Default: 0
        /// Description: Available quantity in warehouse
        /// </summary>
        [Required]
        public int StockQuantity { get; set; }

        /// <summary>
        /// Product category
        /// Column Name: category
        /// Data Type: NVARCHAR(100)
        /// Nullable: false
        /// Description: Category classification of the product
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Category { get; set; }

        /// <summary>
        /// Product status
        /// Column Name: status
        /// Data Type: NVARCHAR(50)
        /// Nullable: false
        /// Default: ACTIVE
        /// Values: ACTIVE, INACTIVE, DISCONTINUED
        /// Description: Current status of the product
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        /// <summary>
        /// Timestamp when the product was created
        /// Column Name: created_at
        /// Data Type: DATETIME2
        /// Nullable: false
        /// Default: GETUTCDATE()
        /// Description: Record creation timestamp
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the product was last updated
        /// Column Name: updated_at
        /// Data Type: DATETIME2
        /// Nullable: true
        /// Description: Record last modification timestamp
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the user who created the product
        /// Column Name: created_by
        /// Data Type: UNIQUEIDENTIFIER
        /// Nullable: true
        /// Foreign Key: users.user_id
        /// Description: Reference to the user who created this product
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// ID of the user who last updated the product
        /// Column Name: updated_by
        /// Data Type: UNIQUEIDENTIFIER
        /// Nullable: true
        /// Foreign Key: users.user_id
        /// Description: Reference to the user who last modified this product
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}