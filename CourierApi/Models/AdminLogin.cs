﻿using Microsoft.AspNetCore.Identity;

namespace CourierApi.Models
{
    public class AdminLogin
    {
        public int Id {  get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
    }
}
//add-migration 
//update - database