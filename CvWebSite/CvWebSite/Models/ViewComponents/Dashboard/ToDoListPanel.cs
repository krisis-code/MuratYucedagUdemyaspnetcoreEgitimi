using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Models.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        TodoListManager todoListManager = new TodoListManager(new EfTodolistDal());

        public IViewComponentResult Invoke()
        {
            var values = todoListManager.TGetList();
            return View(values);

        }
    }
}
