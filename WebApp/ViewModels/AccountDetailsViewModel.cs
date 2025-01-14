﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic { get; set; }
    public AccountAddressInfo? Address { get; set; }
}



public class AccountBasicInfo
{
    [Required]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone (opttional)", Prompt = "Enter your phone")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Bio (opttional)", Prompt = "Add a short bio")]
    public string? Bio { get; set; } 
}

public class AccountAddressInfo
{
    [Required]
    [Display(Name = "Address line 1", Prompt = "Enter your first address line")]
    public string AddressLine_1 { get; set; } = null!;

    
    [Display(Name = "Address line 2 (optional)", Prompt = "Enter your second address line")]
    public string? AddressLine_2 { get; set; }

    [Required]
    [Display(Name = "postal code", Prompt = "Enter your postal code")]
    public string PostalCode { get; set; } = null!;

    [Required]
    [Display(Name = "city", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
}