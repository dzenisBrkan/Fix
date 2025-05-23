﻿namespace FIX.Domain.Entities;

public class Users
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public ICollection<Review> Reviews { get; set; }

    //public string Role { get; set; } // e.g., "User", "Admin"
}