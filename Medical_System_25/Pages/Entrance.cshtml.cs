﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Medical_System.Operations;
using Medical_System.Models;

namespace Medical_System.Pages
{
    public class EntranceModel : PageModel
    {
        public string Message { get; set; }
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return (Encoding.ASCII.GetString(buffer3) == Encoding.ASCII.GetString(buffer4));
        }
        public IActionResult OnPost(string login, string pasword)
        {
            var auth = AuthenticationOps.GetAuthorization(login).FirstOrDefault();
            if (auth == null)
            {

                Message = "Некорректно введен логин и пароль";

                return Redirect("./Authorization");
            }
            else
            {
                if (VerifyHashedPassword(auth.Password, pasword))
                {
                    var person = PersonOps.GetIdPerson(auth.Pers_id);
                    Response.Cookies.Append("login", login);
                    Response.Cookies.Append("id", person.Id.ToString());
                    Message = "Вы вошли в аккаунт" + person.Name + " " + person.LastName;
                    return Redirect("./Users");
                }
                else
                {
                    Message = "Некорректно введен логин и пароль";
                    return Redirect("./Authorization");
                }
            }
        }
    }
}
