﻿using ServiceLayer.Helpers.Constans;
using ServiceLayer.Helpers.Enums;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        //public bool CheckRole(int roleId)
        //{
        //    if (roleId == (int)Roles.SuperAdmin)
        //        return true;
        //    return false;

        //}

        public string Login(string email, string password, int roleId)
        {
            if (email == AccountDatas.Email && password == AccountDatas.Password)
            {
                if (CheckRole(roleId))
                {
                    return ResponseMessages.Success;
                }
                else
                {
                    return ResponseMessages.Unauthorized;
                }

            }
            return ResponseMessages.Failed;
        }

        private bool CheckRole(int roleId)
        {
            if (roleId == (int)Roles.SuperAdmin)
                return true;
            return false;

        }
    }
}
