﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServ1
{
    public class SubUser
    {
        //מגדיר תכונות בסיסיות
        //defining reqired properties
        private int id;
        private int belongsToUpperUser;
        private string fName;
        private string lName;
        private string role;
        private string email;
        private string password;

        public SubUser()
        {

        }

        public int Id { get => id; set => id = value; }
        public int BelongsToUpperUser { get => belongsToUpperUser; set => belongsToUpperUser = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Role { get => role; set => role = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public SubUser Copy()
        {
            return new SubUser() { Id = this.id, BelongsToUpperUser = this.BelongsToUpperUser, FName = this.FName, LName = this.LName, Role = this.Role };
        }
    }
}