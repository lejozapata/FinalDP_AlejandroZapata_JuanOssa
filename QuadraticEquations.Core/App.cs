﻿using MvvmCross.IoC;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.ViewModels;

namespace QuadraticEquations.Core
{
    class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<QuadraticViewModel>();
        }

    }
}
