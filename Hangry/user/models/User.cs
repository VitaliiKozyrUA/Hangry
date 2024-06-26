﻿using Hangry.common.data.models;
using Hangry.user.login.data.datasources;
using Hangry.user.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hangry.user.login.data.models
{
    internal class User : IFormattable, IEquatable<User>
    {
        private static UserLocalDataSource userLocalDataSource = new UserLocalDataSource();
        public int Id { get; }
        public string Name { get; }
        public string Address { get; }
        public string Password { get; }

        public User(int id, string name, string address, string password)
        {
            if (id < 0) throw new ArgumentException();
            if (name.Length == 0) throw new ArgumentException();
            if (address.Length == 0) throw new ArgumentException();
            if (password.Length == 0) throw new ArgumentException();

            Id = id;
            Name = name;
            Address = address;
            Password = password;
        }

        public static User? LogIn(Credentials credentials)
        {
            if(credentials.Username.Length == 0) throw new ArgumentException();
            if(credentials.Password.Length == 0) throw new ArgumentException();
            return userLocalDataSource.Get(credentials);
        }

        public void Register()
        {
            userLocalDataSource.Add(this);
        }

        public void SaveOrders(List<Order> orders)
        {
            foreach (var order in orders)
            {
                if(order.Quantity <= 0) throw new ArgumentException();
                if (order.UserId != Id) throw new ArgumentException();
                if (order.Date.Length <= 0) throw new ArgumentException();
            }
            OrderLocalDataSource.AddAll(orders);
        }

        public List<Order> GetOrders()
        {
            return OrderLocalDataSource.GetWhereUserId(Id);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                return hashCode;
            }
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}";
        }

        public bool Equals(User? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            User other = (User)obj;
            return Id == other.Id && Name.Equals(other.Name) && Address.Equals(other.Address);
        }
    }
}
