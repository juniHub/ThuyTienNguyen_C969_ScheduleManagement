﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ThuyTienNguyen_C969_ScheduleManagement.DBModel
{
    class Database
    {

       //get all users from database
        public static List<User> getAllUsers()
        {
            List<User> listOfUsers = new List<User>();
            string query = "SELECT * FROM user";


            DBConnection.startConnection();


            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int userID = Convert.ToInt32(dataReader[0]);
                string userName = dataReader[1].ToString();
                string password = dataReader[2].ToString();
                int active = Convert.ToInt32(dataReader[3]);
                DateTime createDate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string createdBy = dataReader[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string lastUpdateBy = dataReader[7].ToString();

                listOfUsers.Add(new User(userID, userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy));
            }

            
           DBConnection.closeConnection();

            return listOfUsers;
        }


        //get all customers from database
        public static void getCustomers()
        {
            string query = "SELECT * FROM customer";


            DBConnection.startConnection();

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int customerID = Convert.ToInt32(dataReader[0]);
                string customerName = dataReader[1].ToString();
                int addressID = Convert.ToInt32(dataReader[2]);
                int active = Convert.ToInt32(dataReader[3]);
                DateTime createDate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string createdBy = dataReader[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string lastUpdateBy = dataReader[7].ToString();

                MainScreen.ListOfCustomers.Add(new Customer(customerID, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy));
            }


            DBConnection.closeConnection();
        }

        //get all appointments from database
        public static void getAppointments()
        {
            
            string query = $"select * from appointment WHERE userId={MainScreen.LoggedInUser.UserID}";
         
            DBConnection.startConnection();

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int appointmentId = Convert.ToInt32(dataReader[0]);
                int customerId = Convert.ToInt32(dataReader[1]);
                int userId = Convert.ToInt32(dataReader[2]);
                string type = dataReader[7].ToString();
                DateTime start = Convert.ToDateTime(dataReader[9]).ToLocalTime();
                DateTime end = Convert.ToDateTime(dataReader[10]).ToLocalTime();
                DateTime createDate = Convert.ToDateTime(dataReader[11]).ToLocalTime();
                string createdBy = dataReader[12].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[13]).ToLocalTime();
                string lastUpdateBy = dataReader[14].ToString();

                MainScreen.ListOfAppointments.Add(new Appointment(appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy));
            }

           DBConnection.closeConnection();
        }


        /***********ADD, DELETE and UPDATE an appointment ***************/

        public static void addAppointment(int customerId, string type, DateTime start, DateTime end)
        {
            DateTime now = DateTime.Now;
            var addedAppointment = new Appointment(customerId, MainScreen.LoggedInUser.UserID, type, start, end, now, MainScreen.LoggedInUser.UserName, now, MainScreen.LoggedInUser.UserName);

           DBConnection.startConnection();

            string query = $"INSERT INTO `appointment` VALUES ({addedAppointment.AppointmentId},{addedAppointment.CustomerId},{addedAppointment.UserId},'not needed','not needed','not needed','not needed','{addedAppointment.Type}','not needed','{addedAppointment.Start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.End.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.CreatedBy}','{addedAppointment.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{addedAppointment.LastUpdateBy}')";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

            
           DBConnection.closeConnection();

            MainScreen.ListOfAppointments.Add(addedAppointment);
        }

        public static void deleteAppointment(Appointment appointment)
        {
            
            DBConnection.startConnection();

            string query = $"DELETE FROM appointment WHERE appointmentId={appointment.AppointmentId};";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

           
            DBConnection.closeConnection();

            MainScreen.ListOfAppointments.Remove(appointment);
        }

        public static void updateAppointment(Appointment appointment, int customerId, string type, DateTime start, DateTime end)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            
            DBConnection.startConnection();

            string query = $"UPDATE appointment SET customerId={customerId},userId={MainScreen.LoggedInUser.UserID},type='{type}',start='{start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}',end='{end.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}',lastUpdate='{nowString}',lastUpdateBy='{MainScreen.LoggedInUser.UserName}' WHERE appointmentId={appointment.AppointmentId};";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

          
            DBConnection.closeConnection();

            Appointment updatedAppointment = new Appointment(appointment.AppointmentId, customerId, MainScreen.LoggedInUser.UserID, type, start, end, appointment.CreateDate, appointment.CreatedBy, now, MainScreen.LoggedInUser.UserName);
            int indexOfAppointmentList = MainScreen.ListOfAppointments.IndexOf(appointment);
            MainScreen.ListOfAppointments.RemoveAt(indexOfAppointmentList);
            MainScreen.ListOfAppointments.Insert(indexOfAppointmentList, updatedAppointment);
        }


        public static void getAddresses()
        {
            string query = "select * from address";


            DBConnection.startConnection();

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int addressID = Convert.ToInt32(dataReader[0]);
                string address1 = dataReader[1].ToString();
                string address2 = dataReader[2].ToString();
                int cityID = Convert.ToInt32(dataReader[3]);
                string postalCode = dataReader[4].ToString();
                string phone = dataReader[5].ToString();
                DateTime createDate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string createdBy = dataReader[7].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[8]).ToLocalTime();
                string lastUpdateBy = dataReader[9].ToString();

                MainScreen.AddressDictionary.Add(addressID, new Address(addressID, address1, address2, cityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy));
            }


            DBConnection.closeConnection();
        }

        //get all cities from database
        public static void getCities()
        {
            string query = "select * from city";


            DBConnection.startConnection();

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int cityID = Convert.ToInt32(dataReader[0]);
                string city = dataReader[1].ToString();
                int countryID = Convert.ToInt32(dataReader[2]);
                DateTime createDate = Convert.ToDateTime(dataReader[3]).ToLocalTime();
                string createdBy = dataReader[4].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[5]).ToLocalTime();
                string lastUpdateBy = dataReader[6].ToString();

                MainScreen.CityDictionary.Add(cityID, new City(cityID, city, countryID, createDate, createdBy, lastUpdate, lastUpdateBy));
            }


            DBConnection.closeConnection();
        }

        //get all countries from database
        public static void getCountries()
        {
            string query = "select * from country";


            DBConnection.startConnection();

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int countryID = Convert.ToInt32(dataReader[0]);
                string country = dataReader[1].ToString();
                DateTime createDate = Convert.ToDateTime(dataReader[2]).ToLocalTime();
                string createdBy = dataReader[3].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string lastUpdateBy = dataReader[5].ToString();

                MainScreen.CountryDictionary.Add(countryID, new Country(countryID, country, createDate, createdBy, lastUpdate, lastUpdateBy));
            }


            DBConnection.closeConnection();
        }


        /***********ADD, DELETE and UPDATE a customer ***************/

        public static int addCustomer(string customerName, int addressID, string user)
        {
            DateTime now = DateTime.Now;
            var addedCustomer = new Customer(customerName, addressID, 1, now, user, now, user);

            
            DBConnection.startConnection();


            string query = $"INSERT INTO `customer` VALUES ({addedCustomer.CustomerId}, '{addedCustomer.CustomerName}', {addedCustomer.AddressId}, {addedCustomer.Active}, '{addedCustomer.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedCustomer.CreatedBy}', '{addedCustomer.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedCustomer.LastUpdateBy}')";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

           
            DBConnection.closeConnection();

            MainScreen.ListOfCustomers.Add(addedCustomer);
            return addedCustomer.CustomerId;
        }

        public static void deleteCustomer(Customer customer)
        {
          
            DBConnection.startConnection();

            string query = $"DELETE FROM customer WHERE customerId={customer.CustomerId};";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

           
            DBConnection.closeConnection();

            MainScreen.ListOfCustomers.Remove(customer);
            deleteAddress(customer.AddressId);
        }

        public static void updateCustomer(Customer customer, string customerName, string user)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

          
            DBConnection.startConnection();

            string query = $"UPDATE customer SET customerName='{customerName}', lastUpdate='{nowString}', lastUpdateBy='{user}' WHERE customerId={customer.CustomerId};";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

         
            DBConnection.closeConnection();

            Customer updatedCustomer = new Customer(customer.CustomerId, customerName, customer.AddressId, customer.Active, customer.CreateDate, customer.CreatedBy, now, user);
            int indexOfCustomerList = MainScreen.ListOfCustomers.IndexOf(customer);
            MainScreen.ListOfCustomers.RemoveAt(indexOfCustomerList);
            MainScreen.ListOfCustomers.Insert(indexOfCustomerList, updatedCustomer);
        }


        /***********ADD, DELETE and UPDATE an address ***************/

        public static int addAddress(string address1, string address2, int cityId, string postalCode, string phone, string userName)
        {
            DateTime now = DateTime.Now;
            var addedAddress = new Address(address1, address2, cityId, postalCode, phone, now, userName, now, userName);

           
            DBConnection.startConnection();


            string query = $"INSERT INTO `address` VALUES ({addedAddress.AddressId}, '{addedAddress.AddressLine}', '{addedAddress.AddressLine2}', {addedAddress.CityId}, '{addedAddress.PostalCode}', '{addedAddress.Phone}', '{addedAddress.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedAddress.CreatedBy}', '{addedAddress.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedAddress.LastUpdateBy}')";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

          
            DBConnection.closeConnection();

            MainScreen.AddressDictionary.Add(addedAddress.AddressId, addedAddress);
            return addedAddress.AddressId;
        }

        public static void deleteAddress(int addressID)
        {
           
            DBConnection.startConnection();

            string query = $"DELETE FROM address WHERE addressId={addressID};";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

         
            DBConnection.closeConnection();

            MainScreen.AddressDictionary.Remove(addressID);
        }

        public static void updateAddress(Address address, string address1, string address2, int cityId, string postalCode, string phone, string user)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

         
            DBConnection.startConnection();

            string query = $"UPDATE address SET address='{address1}', address2='{address2}', cityId={cityId}, postalCode='{postalCode}', phone='{phone}', lastUpdate='{nowString}', lastUpdateBy='{user}' WHERE addressId={address.AddressId};";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.ExecuteNonQuery();

           
            DBConnection.closeConnection();

            MainScreen.AddressDictionary[address.AddressId] = new Address(address.AddressId, address1, address2, cityId, postalCode, phone, address.CreateDate, address.CreatedBy, now, user);
        }
       
    }
}
