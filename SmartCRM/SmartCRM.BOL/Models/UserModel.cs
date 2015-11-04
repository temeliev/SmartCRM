﻿namespace SmartCRM.BOL.Models
{
    using BLToolkit.EditableObjects;

    public abstract class UserModel : EditableObject<UserModel>
    {
        public abstract uint UserId { get; set; }

        public abstract string Username { get; set; }

        public abstract string Password { get; set; }

        public abstract bool IsEnabled { get; set; }

        public abstract bool IsAdmin { get; set; }

        public static UserModel Create()
        {
            return UserModel.CreateInstance();
        }
    }
}
