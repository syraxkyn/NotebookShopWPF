using MyAPP.Model;
using System.Collections.Generic;
using System.ComponentModel;
using MyAPP.View;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Image = MyAPP.Model.Image;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Net.Mail;
using System.Net;

namespace MyAPP.ViewModel
{
    public class DataManageVM:INotifyPropertyChanged
    {
        #region OBJECTS
        private List<Order> allCurrentOrders = DataWorker.GetAllUserOrders(Id);
        public List<Order> AllCurrentOrders
        {
            get { return allCurrentOrders; }
            set
            {
                allCurrentOrders = value;
                NotifyPropertyChanged("allCurrentOrders");
            }
        }

        private List<Notebook> allNotebooks = DataWorker.GetAllNotebooks();
        public List<Notebook> AllNotebooks
        {
            get { return allNotebooks; }
            set
            {
                allNotebooks = value;
                NotifyPropertyChanged("allNotebooks");
            }
        }
        private List<Review> allReviews = DataWorker.GetAllReviews();
        public List<Review> AllReviews
        {
            get { return allReviews; }
            set
            {
                allReviews = value;
                NotifyPropertyChanged("allReviews");
            }
        }
        private List<Order> allOrders = DataWorker.GetAllOrders();
        public List<Order> AllOrders
        {
            get { return allOrders; }
            set
            {
                allOrders = value;
                NotifyPropertyChanged("allOrders");
            }
        }
        private List<User> allUsers = DataWorker.GetAllUsers();
        public List<User> AllUsers
        {
            get { return allUsers; }
            set
            {
                allUsers = value;
                NotifyPropertyChanged("allUsers");
            }
        }
        private List<Support> allSupports = DataWorker.GetAllSupports();
        public List<Support> AllSupports
        {
            get { return allSupports; }
            set
            {
                allSupports = value;
                NotifyPropertyChanged("allSupports");
            }
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #region METHODS TO OPEN WINDOW
        //open add window methods
        private void OpenAddNotebookWindowMethod()
        {
            AddNewNotebookWindow newNotebookWindow = new AddNewNotebookWindow();
            SetCenterPositionAndOpen(newNotebookWindow);
        }
        private void OpenReviewsWindowMethod()
        {
            ReviewsWindow newReviewsWindow = new ReviewsWindow();
            SetCenterPositionAndOpen(newReviewsWindow);
        }
        private void OpenGiveFeedbackWindowMethod()
        {
            GiveFeedbackWindow newGiveFeedbackWindow = new GiveFeedbackWindow();
            SetCenterPositionAndOpen(newGiveFeedbackWindow);
        }
        private void OpenRegisterWindowMethod()
        {
            RegisterUserWindow newRegisterWindow = new RegisterUserWindow();
            SetCenterPositionAndOpen(newRegisterWindow);
        }
        private void OpenLoginWindowMethod()
        {
            LoginUserWindow newLoginWindow = new LoginUserWindow();
            SetCenterPositionAndOpen(newLoginWindow);
        }
        private void OpenUserWindowMethod()
        {
            UserWindow newUserWindow = new UserWindow();
            SetCenterPositionAndOpen(newUserWindow);
        }
        private void OpenMainWindowMethod()
        {
            MainWindow newMainWindow = new MainWindow();
            SetCenterPositionAndOpen(newMainWindow);
        }
        private void OpenSupportWindowMethod()
        {
            SupportWindow newSupportWindow = new SupportWindow();
            SetCenterPositionAndOpen(newSupportWindow);
        }
        //open edit windows methods
        private void OpenEditNotebookWindowMethod(Notebook notebook)
        {
            EditNotebookWindow newNotebookWindow = new EditNotebookWindow(notebook);
            SetCenterPositionAndOpen(newNotebookWindow);
        }
        private void SetCenterPositionAndOpen(Window window)
        {

            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion
        #region COMMANDS TO OPEN WINDOWS
        private RelayCommand exitMainWnd;
        public RelayCommand ExitMainWnd
        {
            get
            {
                return exitMainWnd ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    RegisterUserWindow newRegisterWindow = new RegisterUserWindow();
                    wnd.Hide();
                    SetNullValuesToProperties();
                    SetNullValuesToUserProperties();
                    newRegisterWindow.ShowDialog();
                    wnd.Close();
                });
            }
        }
        private RelayCommand openRegisterUserWnd;
        public RelayCommand OpenRegisterUserWnd
        {
            get
            {
                return openRegisterUserWnd ?? new RelayCommand(obj =>
                {
                    OpenRegisterWindowMethod();
                });
            }
        }
        private RelayCommand openUserWnd;
        public RelayCommand OpenUserWnd
        {
            get
            {
                return openUserWnd ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    wnd.Hide();
                    OpenUserWindowMethod();
                    wnd.Show();
                });
            }
        }
        private RelayCommand openLoginUserWnd;
        public RelayCommand OpenLoginUserWnd
        {
            get
            {
                return openLoginUserWnd ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    wnd.Hide();
                    SetNullValuesToUserProperties();
                    OpenLoginWindowMethod();
                    wnd.Close();
                });
            }
        }
        private RelayCommand openReviewsWnd;
        public RelayCommand OpenReviewsWnd
        {
            get
            {
                return openReviewsWnd ?? new RelayCommand(obj =>
                {
                    OpenReviewsWindowMethod();
                });
            }
        }
        private RelayCommand openGiveFeedbackWnd;
        public RelayCommand OpenGiveFeedbackWnd
        {
            get
            {
                return openGiveFeedbackWnd ?? new RelayCommand(obj =>
                {
                    OpenGiveFeedbackWindowMethod();
                });
            }
        }
        private RelayCommand openAddNewNotebookWnd;
        public RelayCommand OpenAddNewNotebookWnd
        {
            get
            {
                return openAddNewNotebookWnd ?? new RelayCommand(obj =>
                {
                    OpenAddNotebookWindowMethod();
                });
            }
        }
        private RelayCommand openSupportWnd;
        public RelayCommand OpenSupportWnd
        {
            get
            {
                return openSupportWnd ?? new RelayCommand(obj =>
                {
                    OpenSupportWindowMethod();
                });
            }
        }
        #endregion
        #region PROPERTIES
        #region NOTEBOOK PROPERTIES
        public static string Notebook { get; set; }
        public static string NotebookName { get; set; }
        public static string NotebookType { get; set; }
        public static int NotebookPrice { get; set; }
        public static Image NotebookImage { get; set; }
        #endregion
        #region IMAGE PROPERTIES
        public static string ImagePath { get;set; }
        public static byte[] ImageData { get; set; }
        #endregion
        #region SELECTED EL PROPERTIES
        public TabItem SelectedTabItem { get; set; }
        public static Notebook SelectedNotebook { get; set; }
        public static Order SelectedOrder{ get; set; }
        #endregion
        #region USER PROPERTIES
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string RePassword { get; set; }
        public static DateTime Created { get; set; }
        public static string Mail { get; set; }
        public static string MailMessage { get; set; }
        #endregion
        #region REVIEW PROPERTIES
        public static string Content { get; set; }
        #endregion
        #endregion
        #region COMMANDS TO ADD
        private RelayCommand addNewNotebook;
        public RelayCommand AddNewNotebook
        {
            get
            {
                return addNewNotebook ?? new RelayCommand(obj =>
                {
                    bool NN = NotebookName == null || NotebookName.Replace(" ", "").Length == 0 || NotebookName.Length == 0;
                    bool NT = NotebookType == null || NotebookType.Replace(" ", "").Length == 0 || NotebookType.Length == 0;
                    bool NP = NotebookPrice <= 0;
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (NN)
                    {
                        SetRedBlockControll(wnd,"NameBlock");
                    }
                    if (NT)
                    {
                        SetRedBlockControll(wnd, "TypeBlock");
                    }
                    if (NP)
                    {
                        SetRedBlockControll(wnd, "PriceBlock");
                    }
                    else if(!NN&&!NT&&!NP)
                    {
                        resultStr = DataWorker.CreateNotebook(0,NotebookName,NotebookType,NotebookPrice,NotebookImage);
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                        wnd.Close();
                        UpdateAllNotebooksView();
                    }
                }
                );
            }
        }
        private RelayCommand addNewImage;
        public RelayCommand AddNewImage
        {
            get
            {
                return addNewImage ?? new RelayCommand(obj =>
                {
                    var dialog = new OpenFileDialog
                    {
                        CheckFileExists = true,
                        Multiselect = false,
                        Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*"
                    };

                    if (dialog.ShowDialog() != true) { return; }
                    ImagePath = dialog.FileName;
                    ImageData = File.ReadAllBytes(ImagePath);
                    NotebookImage=new Image { Id=0,FileName=ImagePath,Data=ImageData};
                }
                );
            }
        }
        #endregion
        #region COMMANDS TO DELETE
        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get
            {
                return deleteItem ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                //если ноутбук
                if (SelectedTabItem.Name == "NotebooksTab" && SelectedNotebook != null)
                    {
                        resultStr = DataWorker.DeleteNotebook(SelectedNotebook);
                        UpdateAllDataView();
                    }
                    //обновление
                    SetNullValuesToProperties();
                    ShowMessageToUser(resultStr);
                });
            }
        }
        private RelayCommand cancelOrder;
        public RelayCommand CancelOrder
        {
            get
            {
                return deleteItem ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                    if (SelectedOrder != null)
                    {
                        resultStr = DataWorker.DeleteOrder(SelectedOrder);
                        UpdateAllOrdersUserWindow();
                    }
                    ShowMessageToUser(resultStr);
                    //обновление
                    SetNullValuesToProperties();
                });
            }
        }
        #endregion
        #region COMMANDS TO OPEN EDIT WND
        private RelayCommand openEditItemWnd;
        public RelayCommand OpenEditItemWnd
        {
            get
            {
                return openEditItemWnd ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                    //если ноутбук
                    if (SelectedTabItem.Name == "NotebooksTab" && SelectedNotebook != null)
                    {
                        OpenEditNotebookWindowMethod(SelectedNotebook);
                    }
                    //обновление
                    SetNullValuesToProperties();
                });
            }
        }
        #endregion
        #region USER COMMANDS
        private RelayCommand sortNotebook;
        public RelayCommand SortNotebook
        {
            get
            {
                return sortNotebook ?? new RelayCommand(obj =>
                  {
                      AllNotebooks.Sort((x,y)=>x.Price.CompareTo(y.Price));
                      UpdateAllNotebooksMyView();
                  });
            }
        }
        private RelayCommand searchNotebook;
        public RelayCommand SearchNotebook
        {
            get
            {
                return searchNotebook ?? new RelayCommand(obj =>
                {
                    List<Notebook> notebooks = new List<Notebook>();
                    notebooks = AllNotebooks.FindAll(x => x.Name.Contains(Notebook));
                    AllNotebooks = notebooks;
                    UpdateAllNotebooksMyView();
                    AllNotebooks = DataWorker.GetAllNotebooks();
                });
            }
        }
        private RelayCommand resetFilters;
        public RelayCommand ResetFilters
        {
            get
            {
                return sortNotebook ?? new RelayCommand(obj =>
                {
                    AllNotebooks = DataWorker.GetAllNotebooks();
                    UpdateAllNotebooksMyView();
                });
            }
        }
        private RelayCommand buyNotebook;
        public RelayCommand BuyNotebook
        {
            get
            {
                return buyNotebook ?? new RelayCommand(obj =>
                {
                    string resultStr = "Не выбран ноутбук";
                    UserWindow usr = new UserWindow();
                    if (SelectedNotebook != null)
                    {
                        resultStr = DataWorker.CreateOrder(SelectedNotebook, DataWorker.FindIdByLogin(Login));
                    }
                    UpdateAllOrdersUserWindow();
                    ShowMessageToUser(resultStr);
                });
            }
        }
        private RelayCommand registerUser;
        public RelayCommand RegisterUser
        {
            get
            {
                return registerUser ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string PasswNoMatch = "Пароли не сходятся";
                    string LoginExists = "Данный пользователь уже существует";
                    if (!DataWorker.GetLogins(Login))
                    {
                        if (Password == RePassword && Password != null && RePassword != null)
                        {
                            DataWorker.RegisterUser(Login, Password);
                            SetNullValuesToProperties();
                            SetNullValuesToUserProperties();
                            wnd.Hide();
                            OpenLoginWindowMethod();
                            wnd.Close();
                        }
                        else
                        {
                            ShowMessageToUser(PasswNoMatch);
                        }
                    }
                    else
                    {
                        ShowMessageToUser(LoginExists);
                    }
                }
                );
            }
        }
        private RelayCommand sendMessage;
        public RelayCommand SendMessage
        {
            get
            {
                return sendMessage ?? new RelayCommand(obj =>
                {
                    try
                    {
                        Window wnd = obj as Window;
                        if (Mail == null || Mail.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "MailBlock");
                        }
                        if (MailMessage == null || MailMessage.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "MessageBlock");
                        }
                        else
                        {
                            string resultStr = "";
                            var smtpClient = new System.Net.Mail.SmtpClient("smtp.mail.ru", 587);
                            smtpClient.Credentials = new System.Net.NetworkCredential("tankiformonkey5@mail.ru", "yRALFyxfxCQnqFswLdfm");
                            smtpClient.EnableSsl = true;
                            smtpClient.Send(new System.Net.Mail.MailMessage("tankiformonkey5@mail.ru", $"{Mail}",
                                "Магазин ноутбуков",
                                "Здравствуйте, ваше обращение доставлено, в ближайшее время мы вам ответим"));
                            resultStr = DataWorker.CreateSupport(Mail, MailMessage);
                            ShowMessageToUser(resultStr);
                            wnd.Close();
                            SetNullValuesToProperties();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                );
            }
        }
        private RelayCommand loginUser;
        public RelayCommand LoginUser
        {
            get
            {
                return loginUser ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = DataWorker.CheckUserData(Login, Password);
                    if (resultStr == "Данного пользователя не существует")
                    {
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                    }
                    if (resultStr == "Введен неверный пароль")
                    {
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                    }
                    if (resultStr == "Отлично")
                    {
                        resultStr = DataWorker.LoginUser(Login, Password);
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                        if (Login.ToUpper()=="ADMIN")
                        {
                            MainWindow main = new MainWindow();
                            main.Show();
                        }
                        else
                        {
                            MyView my = new MyView();
                            my.Show();
                        }
                    }
                }
                );
            }
        }
        private RelayCommand exitUser;
        public RelayCommand ExitUser
        {
            get {
                return exitUser ?? new RelayCommand(obj =>
                {
                    string result = Login;
                    SetNullValuesToProperties();
                    SetNullValuesToUserProperties();
                    ShowMessageToUser(result + ", вы успешно вышли.");
                });
            }
        }
        private RelayCommand giveFeedback;
        public RelayCommand GiveFeedback
        {
            get
            {
                return giveFeedback ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (Content != null)
                    {
                        resultStr = DataWorker.CreateReview(DataWorker.FindIdByLogin(Login), Content);
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                        UpdateAllReviewsRevWindow();
                    }
                });
            }
        }
        #endregion
        #region EDIT COMMANDS
        private RelayCommand editNotebook;
        public RelayCommand EditNotebook
        {
            get {
                return editNotebook ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    bool SN = SelectedNotebook == null;
                    bool NT = NotebookType == null || NotebookType.Replace(" ", "").Length == 0;
                    bool NP = NotebookPrice <= 0;
                    string resultStr = "Не выбран ноутбук";
                    string noTypeStr = "Не выбран тип";
                    string noPriceStr = "Не выбрана цена";
                    if (SN)
                    {
                        ShowMessageToUser(resultStr);
                    }
                    if (NT)
                    {
                        ShowMessageToUser(noTypeStr);
                    }
                    if (NP)
                    {
                        ShowMessageToUser(noPriceStr);
                    }
                    if(!SN&&!NT&&!NP)
                    {
                        resultStr = DataWorker.EditNotebook(SelectedNotebook, NotebookType, NotebookPrice);
                        UpdateAllDataView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        window.Close();
                    }
                });
                }

        }
        #endregion
        #region UPDATE VIEWS
        private void SetNullValuesToProperties()
        {
            NotebookName = null;
            NotebookType = null;
            NotebookPrice = 0;
            NotebookImage = null;
            ImagePath = null;
            ImageData = null;
            Content = null;
        }
        private void SetNullValuesToUserProperties()
        {
            Login = null;
            Id = 0;
            Password = null;
            RePassword = null;
            Created = Convert.ToDateTime(null);
        }
        private void UpdateAllDataView()
        {
            UpdateAllNotebooksView();
        }
        private void UpdateAllOrdersUserWindow()
        {
            AllCurrentOrders = DataWorker.GetAllUserOrders(Id);
            UserWindow.AllCurrentOrdersView.ItemsSource = null;
            UserWindow.AllCurrentOrdersView.Items.Clear();
            UserWindow.AllCurrentOrdersView.ItemsSource = AllCurrentOrders;
            UserWindow.AllCurrentOrdersView.Items.Refresh();
        }
        private void UpdateAllReviewsRevWindow()
        {
            AllReviews=DataWorker.GetAllReviews();
            ReviewsWindow.AllReviewsView.ItemsSource = null;
            ReviewsWindow.AllReviewsView.Items.Clear();
            ReviewsWindow.AllReviewsView.ItemsSource = AllReviews;
            ReviewsWindow.AllReviewsView.Items.Refresh();
        }
        private void UpdateAllNotebooksMyView()
        {
            MyView.AllNotebooksView.ItemsSource = null;
            MyView.AllNotebooksView.Items.Clear();
            MyView.AllNotebooksView.ItemsSource = AllNotebooks;
            MyView.AllNotebooksView.Items.Refresh();
        }
        private void Update()
        {
            AllNotebooks = DataWorker.GetAllNotebooks();
        }
        private void UpdateAllNotebooksView()
        {
            AllNotebooks=DataWorker.GetAllNotebooks();
            MainWindow.AllNotebooksView.ItemsSource = null;
            MainWindow.AllNotebooksView.Items.Clear();
            MainWindow.AllNotebooksView.ItemsSource=AllNotebooks;
            MainWindow.AllNotebooksView.Items.Refresh();
        }
        #endregion
        #region SOME SIMPLE METHODS
        private string GetFileName()
        {
            string FileName =null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            FileName = openFileDialog1.FileName;
            return FileName;
        }
        private void ShowMessageToUser(string message)
        {
            MessageView messageView = new MessageView(message);
            SetCenterPositionAndOpen(messageView);
        }
        private void SetRedBlockControll(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }
        private void SetVisibility(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.Visibility = Visibility.Hidden;
        }
        #endregion
    }
}