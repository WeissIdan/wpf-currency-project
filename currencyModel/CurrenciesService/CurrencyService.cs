using currencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using currencyModel;
using CurrencyBL;

namespace CurrenciesService
{
    public class CurrencyService : ICurrencyService
    {
        public CurrencyList GetAllCurrencies()
        {
            CurrenciesManager manager = new CurrenciesManager();
            CurrencyList list= manager.GetCurrencyList();
        return list;
        }

        public double Convert(Currency source, Currency dest, double amount)
        {
            CurrenciesManager manager = new CurrenciesManager();
            return manager.Convert(source, dest, amount);
        }

    }
}
