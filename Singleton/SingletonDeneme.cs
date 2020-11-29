using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonDeneme
    {
        private static SingletonDeneme singletonDeneme;
        private static Guid _id;
        private static object _lockObject = new object();
        private string _title;

        private SingletonDeneme(Guid id, string title)
        {
            _title = title;
            _id = id;
        }

        public Guid id
        {
            get { return _id; }
        } 
        
        public string title
        {
            get { return _title; }
            set { _title = title; }
        }
         

        public static SingletonDeneme GetSingleton()
        {
            if (singletonDeneme == null)
            {
                lock (_lockObject) { 
                    if(singletonDeneme == null) { 
                        singletonDeneme = new SingletonDeneme(Guid.NewGuid(),title:"Berkay");
                    }
                }
            }    
            return singletonDeneme;
        }
    }
}
