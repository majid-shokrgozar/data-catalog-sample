/**
 * User Entity
 * 
 * This class represents a user in the system.
 * Database Table: users
 * Description: Stores user account information and profile details
 * 
 * @author Data Team
 * @version 1.0
 * @since 2026-01-01
 */
public class User {
    
    /**
     * Unique identifier for the user
     * Column: user_id
     * Type: UUID/String
     * Nullable: false
     * Primary Key: true
     * Description: Unique identifier generated at user creation
     */
    private String userId;
    
    /**
     * User's email address
     * Column: email
     * Type: VARCHAR(255)
     * Nullable: false
     * Unique: true
     * Description: User's primary email for authentication and notifications
     */
    private String email;
    
    /**
     * User's full name
     * Column: full_name
     * Type: VARCHAR(255)
     * Nullable: false
     * Description: Complete name of the user
     */
    private String fullName;
    
    /**
     * User's account creation timestamp
     * Column: created_at
     * Type: TIMESTAMP
     * Nullable: false
     * Default: CURRENT_TIMESTAMP
     * Description: When the user account was created
     */
    private java.time.LocalDateTime createdAt;
    
    /**
     * User's last update timestamp
     * Column: updated_at
     * Type: TIMESTAMP
     * Nullable: true
     * Description: When the user account was last updated
     */
    private java.time.LocalDateTime updatedAt;
    
    /**
     * User's account status
     * Column: status
     * Type: ENUM('ACTIVE', 'INACTIVE', 'SUSPENDED')
     * Nullable: false
     * Default: 'ACTIVE'
     * Description: Current status of the user account
     */
    private String status;
    
    /**
     * Gets the user ID
     * @return the user ID
     */
    public String getUserId() {
        return userId;
    }
    
    /**
     * Sets the user ID
     * @param userId the user ID to set
     */
    public void setUserId(String userId) {
        this.userId = userId;
    }
    
    /**
     * Gets the user's email
     * @return the email address
     */
    public String getEmail() {
        return email;
    }
    
    /**
     * Sets the user's email
     * @param email the email to set
     */
    public void setEmail(String email) {
        this.email = email;
    }
    
    /**
     * Gets the user's full name
     * @return the full name
     */
    public String getFullName() {
        return fullName;
    }
    
    /**
     * Sets the user's full name
     * @param fullName the full name to set
     */
    public void setFullName(String fullName) {
        this.fullName = fullName;
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
    
    /**
     * Gets the last update timestamp
     * @return the update timestamp
     */
    public java.time.LocalDateTime getUpdatedAt() {
        return updatedAt;
    }
    
    /**
     * Sets the last update timestamp
     * @param updatedAt the update timestamp to set
     */
    public void setUpdatedAt(java.time.LocalDateTime updatedAt) {
        this.updatedAt = updatedAt;
    }
    
    /**
     * Gets the user's status
     * @return the account status
     */
    public String getStatus() {
        return status;
    }
    
    /**
     * Sets the user's status
     * @param status the status to set
     */
    public void setStatus(String status) {
        this.status = status;
    }
}