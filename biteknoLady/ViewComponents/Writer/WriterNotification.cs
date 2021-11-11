using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoLady.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManager notm = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = notm.GetList();
            return View(values);
        }
    }
}
