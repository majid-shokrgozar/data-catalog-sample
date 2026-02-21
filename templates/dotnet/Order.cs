/// <summary>
/// Order Entity
/// 
/// This class represents an order in the e-commerce system.
/// Database Table: orders
/// Description: Stores order information including customer details, items, and status
/// </summary>
public class Order
{
    /// <summary>
    /// Unique order identifier
    /// Column: order_id
    /// Type: UNIQUEIDENTIFIER
    /// Nullable: false
    /// Primary Key: true
    /// Description: Unique identifier for each order
    /// </summary>
    public string OrderId { get; set; }
    
    /// <summary>
    /// Customer user ID
    /// Column: user_id
    /// Type: UNIQUEIDENTIFIER
    /// Nullable: false
    /// Foreign Key: users.user_id
    /// Description: Reference to the customer who placed the order
    /// </summary>
    public string UserId { get; set; }
    
    /// <summary>
    /// Order total amount
    /// Column: total_amount
    /// Type: DECIMAL(10, 2)
    /// Nullable: false
    /// Description: Total cost of the order including taxes
    /// </summary>
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Order status
    /// Column: status
    /// Type: NVARCHAR(50)
    /// Nullable: false
    /// Default: 'PENDING'
    /// Enum Values: 'PENDING', 'CONFIRMED', 'SHIPPED', 'DELIVERED', 'CANCELLED'
    /// Description: Current status of the order
    /// </summary>
    public string Status { get; set; }
    
    /// <summary>
    /// Order creation timestamp
    /// Column: created_at
    /// Type: DATETIME2
    /// Nullable: false
    /// Default: GETUTCDATE()
    /// Description: When the order was placed
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Order completion timestamp
    /// Column: completed_at
    /// Type: DATETIME2
    /// Nullable: true
    /// Description: When the order was completed/delivered
    /// </summary>
    public DateTime? CompletedAt { get; set; }
}