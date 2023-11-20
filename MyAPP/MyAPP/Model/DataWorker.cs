using MyAPP.Model.Data;
using MyAPP.ViewModel;
using System.Collections.Generic;
using System.Linq;
namespace MyAPP.Model
{
    public static class DataWorker
    {
        public static List<Notebook> GetAllNotebooks()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                var result = db.Notebooks.ToList();
                return result;
            }
        }
        public static List<Support> GetAllSupports()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.SupportList.ToList();
                return result;
            }
        }
        public static List<Review> GetAllReviews()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Reviews.ToList();
                return result;
            }
        }
        public static List<Order> GetAllOrders()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Orders.ToList();
                return result;
            }
        }
        public static List<Order> GetAllUserOrders(int UserId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Orders.Where(o => o.UserId == UserId).ToList();
                return result;
            }
        }
        public static List<User> GetAllUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Users.ToList();
                return result;
            }
        }

        public static List<Image> GetAllImages()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Images.ToList();
                return result;
            }
        }
        public static string CreateNotebook(int id,string name,string type,int price,Image image)
        {
            string result = "Уже существует";
            using(ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли ноутбук
                bool checkIsExist = db.Notebooks.Any(el => el.Name == name && el.Type == type && el.Price == price);
                if (!checkIsExist)
                {
                    Notebook newNotebook = new Notebook
                    {
                        Id = id, 
                        Name = name, 
                        Type = type, 
                        Price = price,
                        NotebookImage=image 
                    };
                    db.Notebooks.Add(newNotebook);
                    db.SaveChanges();
                    result = "Сделано";
                }
                return result;
            }
        }
        public static string CreateReview(int UserId,string Content)
        {
            string result = "Not ok";
            using (ApplicationContext db = new ApplicationContext())
            {
                Review newReview = new Review
                {
                    UserId = UserId,
                    Content = Content,
                    Created = System.DateTime.Now
                };
                db.Reviews.Add(newReview);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }
        public static string CreateSupport(string Mail, string Content)
        {
            string result = "Not ok";
            using (ApplicationContext db = new ApplicationContext())
            {
                Support newSupport = new Support
                {
                    Content = Content,
                    Mail = Mail,
                    Created = System.DateTime.Now
                };
                db.SupportList.Add(newSupport);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }
        public static int FindIdByLogin(string Login)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Users.FirstOrDefault(p => p.Login == Login);
                return result.Id;
            }
        }
        public static string CreateOrder(Notebook notebook,int userId)
        {
            string result = "Не получилось";
            using (ApplicationContext db = new ApplicationContext())
            {
                Order newOrder = new Order
                {
                    Id=0,
                    NotebookId = notebook.Id,
                    UserId = userId
                };
                db.Orders.Add(newOrder);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }
        public static string RegisterUser(string login, string password)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли пользователь
                bool checkIsExist = db.Users.Any(el => el.Login == login);
                if (!checkIsExist)
                {
                    User newUser = new User
                    {
                        Id = 0,
                        Login = login,
                        Password = password,
                        Orders = null,
                        Created = System.DateTime.Now
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    result = "Сделано";
                }
                return result;
            }
        }
        public static string LoginUser(string login, string password)
        {
            DataManageVM.Login = login;
            DataManageVM.Password = password;
            DataManageVM.Id = FindIdByLogin(login);
            using (ApplicationContext db = new ApplicationContext())
            {
                DataManageVM.Created = db.Users.FirstOrDefault(d => d.Id == DataManageVM.Id).Created;
            }
            return "Добри дзень " + login;
        }
        public static string CheckUserData(string login, string password)
        {
            string result = "Отлично";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли пользователь
                bool checkIsLoginExist = db.Users.Any(el => el.Login == login);
                bool checkIsPasswordCorrect = db.Users.Any(el => el.Login == login && el.Password == password);
                if (checkIsLoginExist)
                {
                    if (checkIsPasswordCorrect)
                    {
                        result = "Отлично";
                    }
                    else
                    {
                        result = "Введен неверный пароль";
                    }
                }
                else
                {
                    result = "Данного пользователя не существует";
                }
                return result;
            }
        }
        public static bool GetLogins(string login)
        {
            bool result = false;
            using (ApplicationContext db = new ApplicationContext())
            {
                result = db.Users.Any(el => el.Login == login);
            }
            return result;
        }
        public static string CreateImage(int id,string filename, byte[] data)
        {
            string result = "Не удалось создать картинку";
            using (ApplicationContext db = new ApplicationContext())
            {
                Image newImage = new Image
                {
                    Id = id,
                    FileName= filename,
                    Data = data
                };
                db.Images.Add(newImage);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }
        public static string DeleteNotebook(Notebook notebook)
        {
            string result = "Такого ноутбука не существует";
            using( ApplicationContext db = new ApplicationContext())
            {
                db.Notebooks.Remove(notebook);
                db.SaveChanges();
                DeleteImage(GetImageById(notebook.ImageId));
                result = "Сделано! Ноутбук " + notebook.Name + " удален из меню";
            }
            return result;
        }
        public static string DeleteOrder(Order order)
        {
            string result = "Такого ноутбука не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                result = "Сделано! Заказ " + order.Id + " отменен";
            }
            return result;
        }
        public static void DeleteImage(Image image)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Images.Remove(image);
                db.SaveChanges();
            }
        }
        public static string EditNotebook(Notebook oldNotebook,string newType,int newPrice)
        {
            string result= "Такого ноутбука не существует";
            using(ApplicationContext db = new ApplicationContext())
            {
                Notebook notebook = db.Notebooks.FirstOrDefault(d => d.Id == oldNotebook.Id);
                notebook.Type= newType;
                notebook.Price = newPrice;
                db.SaveChanges();
                result = "Сделано! Ноутбук " + notebook.Name + " изменен";
            }
            return result;
        }

        //получение картинки по id
        public static Image GetImageById(int id)
        {
            using( ApplicationContext db = new ApplicationContext())
            {
                Image im = db.Images.FirstOrDefault(p=>p.Id==id);
                return im;
            }
        }
        public static string GetLoginById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault(p => p.Id==id);
                return user.Login;
            }
        }
        public static Notebook GetNotebookById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Notebook notebook = db.Notebooks.FirstOrDefault(p => p.Id == id);
                return notebook;
            }
        }
    }
}
