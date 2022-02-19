using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo__FactoryDemo2_.Models
{
    public static class Builder // buna diger uygulamada factory demistik ama bu sekilde de kullaniliyor
                                // bir de bundan herhangi bir instantie olusturmayacagiz, o yuzden static yapiyoruz.
    {
        public static IStudent GetStudent()
        {
            return new Student();
        }
        public static ILogger GetLogger()
        {
            return new Logger(); // console ekranina yazdirma
            //return new LogToFile(); //c'deki ilgili klasore yazdirma
        }
        public static IMessageSender GetMessageSender()
        {
            return new Emailer();
        }
        public static IToDo GetToDo()
        {
            return new ToDo(GetMessageSender(), GetLogger());
        }
    }
}
