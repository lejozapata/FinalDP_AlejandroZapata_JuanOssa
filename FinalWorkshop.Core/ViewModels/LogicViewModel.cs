﻿using FinalWorkshop.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalWorkshop.Core.ViewModels
{
    public class LogicViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _CalculateCommand;

        public LogicViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }

        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _CalculateCommand = _CalculateCommand ?? new MvxCommand(Calculate);
                return _CalculateCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();
            A = 2;
            B = 8;
            C = 3;
            X1 = 0;
            X2 = 0;
        }

        private void Calculate()
        {
            X1 = _calculationService.GetResultX1(A, B, C, X1);
            X2 = _calculationService.GetResultX2(A, B, C, X2);

        }




    }
}
