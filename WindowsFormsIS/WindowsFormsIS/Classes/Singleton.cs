using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsIS.Classes {
    internal class Singleton {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        // Propriedade para armazenar dados
        public DataStructure data { get; set; }

        // Construtor privado para evitar instanciação externa
        private Singleton() { }

        // Método para obter a instância da classe
        public static Singleton Instance 
        {
            get 
            {
                if (_instance == null) 
                {
                    lock (_lock) 
                    {
                        if (_instance == null) 
                        {
                            _instance = new Singleton();
                            _instance.data = new DataStructure();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
