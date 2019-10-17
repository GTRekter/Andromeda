using System;
using System.Net.Mail;
using Andromeda.Models.View.Response;
using Andromeda.Models.View.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Andromeda.Controllers
{
    [Route("api/[controller]")]
    public class EmailController
    {
        [HttpPost("[action]")]
        public BaseResponse SendEmail(SendMailRequest request)
        {
            BaseResponse viewModel = new BaseResponse();

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("[YOUR-SMPT-CLIENT]");
                mail.From = new MailAddress(request.Email);
                mail.To.Add("[YOUR-EMAIL-ADDRESS]");
                mail.Subject = string.Format("Personal website - Request Information from {0}", request.Name);
                mail.Body = request.Message;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("[YOUR-USERNAME]", "[YOUR-PASSWORD]");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception exc)
            {
                viewModel.ResultInfo.Result = BaseResponse.ResultInfoDto.ResultEnum.Error;
                viewModel.ResultInfo.ErrorMessage = exc.Message;
            }

            return viewModel;
        }
    }
}
