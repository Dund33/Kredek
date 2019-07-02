using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LukaszDrozdzLab5Homework.Models;
using System.Data.SqlClient;

namespace LukaszDrozdzLab5Homework.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// String used for connecting with the database
        /// </summary>
        readonly string connectionString = @"Data Source=DESKTOP-TSOGQMH\SQLEXPRESS;database=LukaszDrozdzLab5Homework;Trusted_Connection=yes;";

        /// <summary>
        /// Retrieve information about coal
        /// </summary>
        /// <returns></returns>
        private List<CoalBasicViewModel> GetBasicAllCoalInfo()
        {
            List<CoalBasicViewModel> basicCoal = new List<CoalBasicViewModel>();
            string command = "SELECT * FROM CoalBasic";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader sqlData = sqlCommand.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        CoalBasicViewModel tmpCoal = new CoalBasicViewModel();
                        tmpCoal.ID = (int)sqlData["ID"];
                        tmpCoal.Name = (string)sqlData["CoalName"];
                        tmpCoal.Amount = (double)sqlData["Amount"];
                        tmpCoal.Price = (decimal)sqlData["Price"];
                        basicCoal.Add(tmpCoal);

                    }

                }
                sqlConnection.Close();
            }

            return basicCoal;
        }

        /// <summary>
        /// Get full info about coal
        /// </summary>
        /// <param name="coalID"></param>
        /// <returns></returns>
        CoalFullViewModel GetFullCoalInfo(int coalID)
        {
            List<CoalFullViewModel> fullCoal = new List<CoalFullViewModel>();
            string command = @"SELECT * FROM CoalFull WHERE ID = @id;";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlCommand.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = coalID;
                sqlConnection.Open();
                using (SqlDataReader sqlData = sqlCommand.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        CoalFullViewModel tmpCoal = new CoalFullViewModel();
                        tmpCoal.ID = (int)sqlData["ID"];
                        tmpCoal.Name = (string)sqlData["CoalName"];
                        tmpCoal.Amount = (double)sqlData["Amount"];
                        tmpCoal.Price = (decimal)sqlData["Price"];
                        tmpCoal.Wex = (double)sqlData["Wex"];
                        tmpCoal.Wa = (double)sqlData["Wa"];
                        tmpCoal.Wtr = (double)sqlData["Wtr"];
                        tmpCoal.Ar = (double)sqlData["Ar"];
                        tmpCoal.Ad = (double)sqlData["Ad"];
                        tmpCoal.Str = (double)sqlData["Str"];
                        tmpCoal.Std = (double)sqlData["Std"];
                        tmpCoal.Vdaf = (double)sqlData["Vdaf"];
                        tmpCoal.Ri = (double)sqlData["Ri"];
                        tmpCoal.Qir = (double)sqlData["Qir"];
                        fullCoal.Add(tmpCoal);
                    }

                }
                sqlConnection.Close();
            }

            if (fullCoal.Count > 0)
            {
                return fullCoal.First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get basic info about coal
        /// </summary>
        /// <param name="coalID"></param>
        /// <returns></returns>
        private CoalBasicViewModel GetBasicCoalInfo(int coalID)
        {
            List<CoalBasicViewModel> basicCoal = new List<CoalBasicViewModel>();
            string command = "SELECT * FROM CoalBasic WHERE ID = @id";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", coalID);
                using (SqlDataReader sqlData = sqlCommand.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        CoalBasicViewModel tmpCoal = new CoalBasicViewModel();
                        tmpCoal.ID = (int)sqlData["ID"];
                        tmpCoal.Name = (string)sqlData["CoalName"];
                        tmpCoal.Amount = (double)sqlData["Amount"];
                        tmpCoal.Price = (decimal)sqlData["Price"];
                        basicCoal.Add(tmpCoal);

                    }

                }
                sqlConnection.Close();
            }

            if (basicCoal.Count > 0)
            {
                return basicCoal.First();
            }
            else
            {
                return null;
            }
        }
       
        /// <summary>
        /// Change amount of coal
        /// </summary>
        /// <param name="coalID"></param>
        /// <param name="amount"></param>
        private void SetAmountOfCoal(int coalID, double amount)
        {
            string command = @"UPDATE Stock SET Amount=@amount WHERE CoalID=@coalID;";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@amount", amount);
                sqlCommand.Parameters.AddWithValue("@coalID", coalID);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Check if client exist in the database
        /// </summary>
        /// <returns></returns>
        private bool ClientExists(string PESEL)
        {
            string command = "SELECT * FROM Clients WHERE PESEL=@pesel";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@pesel", PESEL);
                using (SqlDataReader data = sqlCommand.ExecuteReader())
                {
                    while (data.Read())
                    {
                        return true;
                    }
                }
                sqlConnection.Close();
            }

            return false;
        }

        /// <summary>
        /// Home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Browse all kinds of coal
        /// </summary>
        /// <returns></returns>
        public IActionResult BrowseCoal()
        {
            return View(GetBasicAllCoalInfo());
        }

        /// <summary>
        /// Present user with form for modifying coal properties
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditCoalCertificate(int ID)
        {
            return View();
        }

        /// <summary>
        /// Edit property certificate of coal
        /// </summary>
        /// <param name="coal"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditCoalCertificate(CoalFullViewModel coal)
        {
            string commandCertificate = "UPDATE CoalCertificates SET Wex = @wex, Wa = @wa, Wtr = @wtr, Ar = @ar, Ad = @ad, Str = @str, Std = @std, Vdaf = @vdaf, Ri = @ri, Qir = @qir WHERE CoalID = @id";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
             
                using (SqlCommand command = new SqlCommand(commandCertificate, sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", coal.ID);
                    command.Parameters.AddWithValue("@wex", coal.Wex);
                    command.Parameters.AddWithValue("@wa", coal.Wa);
                    command.Parameters.AddWithValue("@wtr", coal.Wtr);
                    command.Parameters.AddWithValue("@ar", coal.Ar);
                    command.Parameters.AddWithValue("@ad", coal.Ad);
                    command.Parameters.AddWithValue("@str", coal.Str);
                    command.Parameters.AddWithValue("@std", coal.Std);
                    command.Parameters.AddWithValue("@vdaf", coal.Vdaf);
                    command.Parameters.AddWithValue("@ri", coal.Ri);
                    command.Parameters.AddWithValue("@qir", coal.Qir);
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            ViewBag.SuccessMessage = "Zmieniono";
            return View();
        }

        /// <summary>
        /// Present user with detailed information about the coal
        /// </summary>
        /// <param name="coalID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CoalDetails(int coalID)
        {
            Debug.WriteLine(coalID);
            CoalFullViewModel coal = GetFullCoalInfo(coalID);
            return View(coal);
        }

        /// <summary>
        /// Present user with form for selling coal
        /// </summary>
        /// <param name="coalID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SellCoalAnonymously(int coalID)
        {
            CoalBasicViewModel coal = GetBasicCoalInfo(coalID);
            ViewBag.CoalName = coal.Name;
            return View();
        }

        /// <summary>
        /// Save transaction
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SellCoalAnonymously(AnonymousTransactionViewModel transaction)
        {
            CoalBasicViewModel coal = GetBasicCoalInfo(transaction.CoalID);
            if(transaction.AmountOfCoal > coal.Amount)
            {
                ViewBag.ErrorMessage = "Za mało węgla w składzie!";
            }
            else
            {
                double currentAmount = coal.Amount;
                currentAmount -= transaction.AmountOfCoal;
                SetAmountOfCoal(transaction.CoalID, currentAmount);
                transaction.Cost = coal.Price * (decimal)transaction.AmountOfCoal;
                transaction.Tax = transaction.Cost * (decimal)0.23;

                string command = @"INSERT INTO TransactionsAnonymous (ClientFirstName, ClientLastName, ClientAddress, PESEL, CoalID, AmountOfCoal, Cost, Tax, DocumentID)
                VALUES (@clientFirstName, @clientLastName, @clientAddress, @pesel, @coalID, @amountOfCoal, @cost, @tax, @documentID);";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@clientFirstName", transaction.ClientFirstName);
                    sqlCommand.Parameters.AddWithValue("@clientLastName", transaction.ClientLastName);
                    sqlCommand.Parameters.AddWithValue("@clientAddress", transaction.ClientAddress);
                    sqlCommand.Parameters.AddWithValue("@pesel", transaction.PESEL);
                    sqlCommand.Parameters.AddWithValue("@coalID", transaction.CoalID);
                    sqlCommand.Parameters.AddWithValue("@amountOfCoal", transaction.AmountOfCoal);
                    sqlCommand.Parameters.AddWithValue("@cost", transaction.Cost);
                    sqlCommand.Parameters.AddWithValue("@tax", transaction.Tax);
                    sqlCommand.Parameters.AddWithValue("@documentID", transaction.DocumentID);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                ViewBag.SuccessMessage = "Sprzedano!";
            }
            
            return View();
        }
        
        /// <summary>
        /// Present user with form for selling coal
        /// </summary>
        /// <param name="coalID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SellCoal(int coalID)
        {
            CoalBasicViewModel coal = GetBasicCoalInfo(coalID);
            ViewBag.CoalName = coal.Name;
            return View();
        }
        
        /// <summary>
        /// Sell coal
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SellCoal(TransactionViewModel transaction)
        {
            CoalBasicViewModel coal = GetBasicCoalInfo(transaction.CoalID);

            if (!ClientExists(transaction.PESEL))
            {
                ViewBag.ErrorMessage = "Klient nie występuje w bazie!";
                return View();
            }

            if (transaction.AmountOfCoal > coal.Amount)
            {
                ViewBag.ErrorMessage = "Za mało węgla w składzie!";
            }
            else
            {
                double currentAmount = coal.Amount;
                currentAmount -= transaction.AmountOfCoal;
                SetAmountOfCoal(transaction.CoalID, currentAmount);
                transaction.Cost = coal.Price * (decimal)transaction.AmountOfCoal;
                transaction.Tax = transaction.Cost * (decimal)0.23;

                string command = @"INSERT INTO Transactions (PESEL, CoalID, AmountOfCoal, Cost, Tax, DocumentID)
                VALUES (@pesel, @coalID, @amountOfCoal, @cost, @tax, @documentID);";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@pesel", transaction.PESEL);
                    sqlCommand.Parameters.AddWithValue("@coalID", transaction.CoalID);
                    sqlCommand.Parameters.AddWithValue("@amountOfCoal", transaction.AmountOfCoal);
                    sqlCommand.Parameters.AddWithValue("@cost", transaction.Cost);
                    sqlCommand.Parameters.AddWithValue("@tax", transaction.Tax);
                    sqlCommand.Parameters.AddWithValue("@documentID", transaction.DocumentID);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                ViewBag.SuccessMessage = "Sprzedano!";
            }

            return View();
        }

        /// <summary>
        /// Get coal id
        /// </summary>
        /// <param name="coalName"></param>
        /// <returns></returns>
        private int GetCoalID(string coalName)
        {
            string command = @"SELECT ID FROM CoalTypes WHERE CoalName = @coalName";
            List<int> results = new List<int>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@coalName", coalName);
                using (SqlDataReader sqlData = sqlCommand.ExecuteReader())
                {
                    while (sqlData.Read()){
                        results.Add((int)sqlData["ID"]);
                    }
                }
                sqlConnection.Close();
            }

                return results.First();
        }

        /// <summary>
        /// Present user with coal delivery form
        /// </summary>
        /// <param name="coalID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CoalDelivery(int coalID)
        {
            return View();
        }

        /// <summary>
        /// Save coal delivery
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CoalDelivery(DeliveryViewModel delivery)
        {
            string command = @"INSERT INTO Deliveries (CoalID, AmountOfCoal, Cost, Tax, DocumentID, Date)
                VALUES (@coalID, @amountOfCoal, @cost, @tax, @documentID, @date);";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@coalID", delivery.CoalID);
                sqlCommand.Parameters.AddWithValue("@amountOfCoal", delivery.AmountOfCoal);
                sqlCommand.Parameters.AddWithValue("@cost", delivery.Cost);
                sqlCommand.Parameters.AddWithValue("@tax", delivery.Tax);
                sqlCommand.Parameters.AddWithValue("@documentID", delivery.DocumentID);
                sqlCommand.Parameters.AddWithValue("@date", delivery.Date);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            ViewBag.SuccessMessage = "Dodano dostawę!";
            CoalBasicViewModel coal = GetBasicCoalInfo(delivery.CoalID);
            double amount = coal.Amount;
            amount += delivery.AmountOfCoal;
            SetAmountOfCoal(delivery.CoalID, amount);
            return View();
        }

        /// <summary>
        /// Present user with coal adddition form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddNewCoal()
        {
            return View();
        }

        /// <summary>
        /// And new kind of coal
        /// </summary>
        /// <param name="coal"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddNewCoal(CoalFullViewModel coal)
        {
            string commandCoal = "INSERT INTO CoalTypes (CoalName) VALUES (@coalName)";
            string commandCertificate = "INSERT INTO CoalCertificates (CoalID, Wex, Wa, Wtr, Ar, Ad, Str, Std, Vdaf, Ri, Qir) " +
                "VALUES (@id, @wex, @wa, @wtr, @ar, @ad, @str, @std, @vdaf, @ri, @qir)";

            string commandStock = "INSERT INTO Stock (CoalID, Amount, Price) VALUES (@coalID, @amount, @price)";
            int coalID;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(commandCoal, sqlConnection))
                {
                    command.Parameters.AddWithValue("@coalName", coal.Name);
                    command.ExecuteNonQuery();
                }

                coalID = GetCoalID(coal.Name);

                using (SqlCommand command = new SqlCommand(commandCertificate, sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", coalID);
                    command.Parameters.AddWithValue("@wex", coal.Wex);
                    command.Parameters.AddWithValue("@wa", coal.Wa);
                    command.Parameters.AddWithValue("@wtr", coal.Wtr);
                    command.Parameters.AddWithValue("@ar", coal.Ar);
                    command.Parameters.AddWithValue("@ad", coal.Ad);
                    command.Parameters.AddWithValue("@str", coal.Str);
                    command.Parameters.AddWithValue("@std", coal.Std);
                    command.Parameters.AddWithValue("@vdaf", coal.Vdaf);
                    command.Parameters.AddWithValue("@ri", coal.Ri);
                    command.Parameters.AddWithValue("@qir", coal.Qir);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(commandStock, sqlConnection))
                {
                    command.Parameters.AddWithValue("@coalID", coalID);
                    command.Parameters.AddWithValue("@amount", 0);
                    command.Parameters.AddWithValue("@price", coal.Price);
                    command.ExecuteNonQuery();
                }

                    sqlConnection.Close();
            }
            ViewBag.SuccessMessage = "Dodano!";
            return View();
        }

        /// <summary>
        /// Present user with coal modification form
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditCoal(int ID)
        {
            return View();
        }

        /// <summary>
        /// Change coal name, price and/or amount
        /// </summary>
        /// <param name="coal"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditCoal(CoalBasicViewModel coal)
        {
            decimal newPrice = coal.Price;
            string commandTypes = "UPDATE CoalTypes SET CoalName = @name WHERE ID = @id";
            string commandStock = "UPDATE Stock SET Price = @price , Amount = @amount WHERE CoalID = @id";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(commandStock, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", coal.ID);
                    sqlCommand.Parameters.AddWithValue("@price", coal.Price);
                    sqlCommand.Parameters.AddWithValue("@amount", coal.Amount);
                    sqlCommand.ExecuteNonQuery();

                }

                using (SqlCommand sqlCommand = new SqlCommand(commandTypes, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", coal.ID);
                    sqlCommand.Parameters.AddWithValue("@name", coal.Name);
                    sqlCommand.ExecuteNonQuery();
                }

                sqlConnection.Close();

            }

            ViewBag.SuccessMessage = "Zmieniono!";
            return View();
        }

         /// <summary>
         /// Browse all clients
         /// </summary>
         /// <returns></returns>
        [HttpGet]
        public IActionResult BrowseClients()
        {
            string command = "SELECT * FROM Clients";

            List<ClientViewModel> clients = new List<ClientViewModel>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader data = sqlCommand.ExecuteReader())
                {
                    while (data.Read())
                    {
                        ClientViewModel tmpClient = new ClientViewModel();
                        tmpClient.FirstName = (string)data["FirstName"];
                        tmpClient.LastName = (string)data["LastName"];
                        tmpClient.Address = (string)data["Address"];
                        tmpClient.PESEL = (string)data["PESEL"];
                        tmpClient.ID = (int)data["ID"];
                        clients.Add(tmpClient);
                    }
                }
                sqlConnection.Close();
            }
            
                return View(clients);
        }

        /// <summary>
        /// Edit client info
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditClient(int ID)
        {
            return View();
        }
         /// <summary>
         /// Edit client info
         /// </summary>
         /// <param name="client"></param>
         /// <returns></returns>
        [HttpPost]
        public IActionResult EditClient(ClientViewModel client)
        {
            string command = "UPDATE Clients SET FirstName = @firstName, LastName = @lastName, Address=@address, PESEL = @pesel WHERE ID = @id";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@firstName", client.FirstName);
                sqlCommand.Parameters.AddWithValue("@lastName", client.LastName);
                sqlCommand.Parameters.AddWithValue("@pesel", client.PESEL);
                sqlCommand.Parameters.AddWithValue("@id", client.ID);
                sqlCommand.Parameters.AddWithValue("@address", client.Address);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

                ViewBag.SuccessMessage = "Zmieniono";
            return View();
        }

        /// <summary>
        /// Present user with client registration form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddClient()
        {
            return View();
        }

        /// <summary>
        /// Adds new client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddClient(ClientViewModel client)
        {
            string command = "INSERT INTO Clients (FirstName, LastName, Address, PESEL) VALUES (@firstName, @lastName, @address, @pesel)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {

                sqlCommand.Parameters.AddWithValue("@firstName", client.FirstName);
                sqlCommand.Parameters.AddWithValue("@lastName", client.LastName);
                sqlCommand.Parameters.AddWithValue("@pesel", client.PESEL);
                sqlCommand.Parameters.AddWithValue("@address", client.Address);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return View();
        }


        /// <summary>
        /// Presents user with a list of transactions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BrowseTransactions()
        {
            string command = "SELECT * FROM TransactionFull";

            List<FullTransactionViewModel> transactions = new List<FullTransactionViewModel>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader data = sqlCommand.ExecuteReader())
                {
                    while (data.Read())
                    {
                        FullTransactionViewModel tmpTransaction = new FullTransactionViewModel();
                        tmpTransaction.FirstName = (string)data["FirstName"];
                        tmpTransaction.LastName = (string)data["LastName"];
                        tmpTransaction.PESEL = (string)data["PESEL"];
                        tmpTransaction.DocumentID = (int)data["DocumentID"];
                        tmpTransaction.CoalName = (string)data["CoalName"];
                        tmpTransaction.AmountOfCoal = (double)data["AmountOfCoal"];
                        tmpTransaction.Tax = (decimal)data["Tax"];
                        tmpTransaction.Cost = (decimal)data["Cost"];
                        transactions.Add(tmpTransaction);
                    }
                }
                sqlConnection.Close();
            }
            return View(transactions);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
