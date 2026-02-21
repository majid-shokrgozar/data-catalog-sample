/**
 * Product Entity
 * 
 * This class represents a product in the e-commerce system.
 * Database Table: products
 * Description: Stores product information including details, pricing, and inventory
 * 
 * @author E-Commerce Team
 * @version 1.0
 * @since 2026-01-01
 */
public class Product {
    
    /**
     * Unique product identifier
     * Column: product_id
     * Type: UUID/String
     * Nullable: false
     * Primary Key: true
     * Description: Unique identifier for each product
     */
    private String productId;
    
    /**
     * Product name
     * Column: product_name
     * Type: VARCHAR(255)
     * Nullable: false
     * Description: Display name of the product
     */
    private String productName;
    
    /**
     * Product description
     * Column: description
     * Type: TEXT
     * Nullable: true
     * Description: Detailed description of the product and its features
     */
    private String description;
    
    /**
     * Product price
     * Column: price
     * Type: DECIMAL(10, 2)
     * Nullable: false
     * Description: Current price of the product
     */
    private java.math.BigDecimal price;
    
    /**
     * Product category
     * Column: category
     * Type: VARCHAR(100)
     * Nullable: false
     * Description: Product category for classification
     */
    private String category;
    
    /**
     * Available stock quantity
     * Column: stock_quantity
     * Type: INTEGER
     * Nullable: false
     * Default: 0
     * Description: Current available stock in inventory
     */
    private Integer stockQuantity;
    
    /**
     * Product creation timestamp
     * Column: created_at
     * Type: TIMESTAMP
     * Nullable: false
     * Default: CURRENT_TIMESTAMP
     * Description: When the product was added to the system
     */
    private java.time.LocalDateTime createdAt;
    
    /**
     * Gets the product ID
     * @return the product ID
     */
    public String getProductId() {
        return productId;
    }
    
    /**
     * Sets the product ID
     * @param productId the product ID to set
     */
    public void setProductId(String productId) {
        this.productId = productId;
    }
    
    /**
     * Gets the product name
     * @return the product name
     */
    public String getProductName() {
        return productName;
    }
    
    /**
     * Sets the product name
     * @param productName the product name to set
     */
    public void setProductName(String productName) {
        this.productName = productName;
    }
    
    /**
     * Gets the product description
     * @return the description
     */
    public String getDescription() {
        return description;
    }
    
    /**
     * Sets the product description
     * @param description the description to set
     */
    public void setDescription(String description) {
        this.description = description;
    }
    
    /**
     * Gets the product price
     * @return the price
     */
    public java.math.BigDecimal getPrice() {
        return price;
    }
    
    /**
     * Sets the product price
     * @param price the price to set
     */
    public void setPrice(java.math.BigDecimal price) {
        this.price = price;
    }
    
    /**
     * Gets the product category
     * @return the category
     */
    public String getCategory() {
        return category;
    }
    
    /**
     * Sets the product category
     * @param category the category to set
     */
    public void setCategory(String category) {
        this.category = category;
    }
    
    /**
     * Gets the stock quantity
     * @return the stock quantity
     */
    public Integer getStockQuantity() {
        return stockQuantity;
    }
    
    /**
     * Sets the stock quantity
     * @param stockQuantity the stock quantity to set
     */
    public void setStockQuantity(Integer stockQuantity) {
        this.stockQuantity = stockQuantity;
    }
    
    /**
     * Gets the creation timestamp
     * @return the creation timestamp
     */
    public java.time.LocalDateTime getCreatedAt() {
        return createdAt;
    }
    
    /**
     * Sets the creation timestamp
     * @param createdAt the creation timestamp to set
     */
    public void setCreatedAt(java.time.LocalDateTime createdAt) {
        this.createdAt = createdAt;
    }
}