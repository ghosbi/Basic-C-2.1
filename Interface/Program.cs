﻿using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.Design.Serialization;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {

        static void Main(string[] args)
        {
            Mail newMail = new Mail();

            ((IWriter)newMail).Writer("Хеллоу всем");

            Worker worker = new Worker();

            ((IWorker)worker).Build();

            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();
            viberInIPhone.GetDeviceInfo(new IPhone());

            IMessenger<IPhone> viberInIphone = new Viber<Phone>();

            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();
            userService.Update(user);

        }

    }
    public class UserService : IUpdater<User>
    {
        

        public void Update(User entity)
        {
           
        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    public class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }

        public void GetDeviceInfo(T device)
        {
            T device1 = new T();
            Console.WriteLine(device1);
            
        }
    }

    public class Viber : IMessenger<Phone>
    {
        public Phone DeviceInfo()
        {
            return null;
        }

        public void GetDeviceInfo(Phone device)
        {
            
        }
    }

    public interface IMessenger <in T>
    {
        void GetDeviceInfo(T device);
    }
    public class IPhone: Phone { }
    public class Phone { }
    public class Computer { }
    

    public class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {
            throw new NotImplementedException();
        }

        void IDevice.TurnOff()
        {
            throw new NotImplementedException();
        }

        void IDevice.TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public interface IBook
    {
        void Read();
    }
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    public class FileManager : IWriter1, IReader, IMailer
    {
        void IReader.Read()
        {
            throw new NotImplementedException();
        }

        void IMailer.SendEmail()
        {
            throw new NotImplementedException();
        }

        void IWriter1.Write()
        {
            throw new NotImplementedException();
        }
    }

    public interface IWriter1
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {

        }
    }

    public interface IWorker
    {
        void Build();
    }

    public class Mail : IWriter
    {
        void IWriter.Writer(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface IWriter
    {
        void Writer(string message);
    }

    public interface IManager
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }

    public class Manager : IManager
    {
        public void Create()
        {

        }

        public void Delete()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }
    }
}