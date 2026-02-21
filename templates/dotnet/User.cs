/// <summary>
/// User Entity
/// 
/// This class represents a user in the system.
/// Database Table: users
/// Description: Stores user account information and profile details
/// </summary>
public class User
{
    /// <summary>
    /// Unique identifier for the user
    /// Column: user_id
    /// Type: UNIQUEIDENTIFIER
    /// Nullable: false
    /// Primary Key: true
    /// Description: Unique identifier generated at user creation
    /// </summary>
    public string UserId { get; set; }
    
    /// <summary>
    /// User's email address
    /// Column: email
    /// Type: NVARCHAR(255)
    /// Nullable: false
    /// Unique: true
    /// Description: User's primary email for authentication and notifications
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// User's full name
    /// Column: full_name
    /// Type: NVARCHAR(255)
    /// Nullable: false
    /// Description: Complete name of the user
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// User's account creation timestamp
    /// Column: created_at
    /// Type: DATETIME2
    /// Nullable: false
    /// Default: GETUTCDATE()
    /// Description: When the user account was created
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// User's last update timestamp
    /// Column: updated_at
    /// Type: DATETIME2
    /// Nullable: true
    /// Description: When the user account was last updated
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
    
    /// <summary>
    /// User's account status
    /// Column: status
    /// Type: NVARCHAR(50)
    /// Nullable: false
    /// Default: 'ACTIVE'
    /// Enum Values: 'ACTIVE', 'INACTIVE', 'SUSPENDED'
    /// Description: Current status of the user account
    /// </summary>
    public string Status { get; set; }
}