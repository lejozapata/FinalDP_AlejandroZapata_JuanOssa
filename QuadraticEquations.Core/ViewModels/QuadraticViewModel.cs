using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticEquationsService _quadraticEquationsService;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _CalculateCommand;

        public QuadraticViewModel(IQuadraticEquationsService quadraticEquationsService)
        {
            _quadraticEquationsService = quadraticEquationsService;
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
            X1 = 0;
            X2 = 0;
            Calculate();
        }

        private void Calculate()
        {
            X1 = _quadraticEquationsService.GetResult(X1, X2);
            X2 = _quadraticEquationsService.GetResult(X1, X2);
        }
    }
}
