using MvvmCross.IoC;
using MvvmCross.ViewModels;
using FinalWorkshop.Core.ViewModels;

namespace FinalWorkshop.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<LogicViewModel>();
        }

    }
}
