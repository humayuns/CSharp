MailMessage o = new MailMessage("From", "To","Subject", "Body");
NetworkCredential netCred= new NetworkCredential("Sender Email","Sender Password");
SmtpClient smtpobj= new SmtpClient("smtp.live.com", 587); 
smtpobj.EnableSsl = true;
smtpobj.Credentials = netCred;
smtpobj.Send(o);
