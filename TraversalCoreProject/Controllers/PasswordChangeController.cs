﻿using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange", new
            {
                userId = user.Id,
                token = passwordResetToken
            }, HttpContext.Request.Scheme);

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "softwaredeveloper.en@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User",forgetPasswordViewModel.Mail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Değişiklik Talebi";
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            //google hesabı uygulama şifrelerinden alınan kod gelecek
            client.Authenticate("softwaredeveloper.en@gmail.com", "kod gelecek");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId,string token)
        {
            TempData["userId"] = userId;
            TempData["token"]= token;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var userId = TempData["userId"];
            var token = TempData["token"];
            if (userId == null || token == null)
            {
                //hata mesajı
            }
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
