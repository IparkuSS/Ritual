using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ritual.Domain.Repositories.Abstract;

namespace Ritual.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public IWreathRepository Wreath { get; set; }
        public ICrossRepository Cross { get; set; }
        public IDifferentRepositor Dif { get; set; }
        public IMonumentRepository Mon { get; set; }
        public IInitMonRepositor IM { get; set; }
        public IBasketRepositor Bas { get; set; }
        public IMessegeRepositor Mes { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository,
            IServiceItemsRepository serviceItemsRepository,
            IWreathRepository wreathRepository,
            ICrossRepository crossRepository,
            IDifferentRepositor differentRepositor, IMonumentRepository monumentRepository,
            IInitMonRepositor initMonRepositor, IBasketRepositor basketRepositor, IMessegeRepositor messegeRepositor)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            Wreath = wreathRepository;
            Cross = crossRepository;
            Dif = differentRepositor;
            Mon = monumentRepository;
            IM = initMonRepositor;
            Bas = basketRepositor;
            Mes = messegeRepositor;
        }
    }
}
