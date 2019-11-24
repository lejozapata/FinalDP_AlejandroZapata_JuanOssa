using FinalWorkshop.Core.Services;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinalWorkshop.Core.ViewModels
{
    public class LogicViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        /*
         Load your private attributes here
         Example:
         private decimal _subTotal;
         private int _generosity;
         private decimal _tip;
        */

        public LogicViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            /*
             Here your initialize attributes
             Example:
            SubTotal = 100;
            Generosity = 10;
            Recalculate();
            */

        }

    }
}
