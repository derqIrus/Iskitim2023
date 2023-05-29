using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Iskitim2023.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page Main;
        private Page Calculation;
        private Page DB;

        private Page _currentPage;
        public Page CurrentPage { get { return _currentPage; } set { _currentPage = value; RaisePropertyChanged(() => CurrentPage); } }

        private double _frameOpacity;
        public double FrameOpacity { get { return _frameOpacity; } set { _frameOpacity = value; RaisePropertyChanged(() => FrameOpacity); } }

        public MainViewModel()
        {
            Main = new Pages.Main();
            Calculation = new Pages.Calculation();
            DB = new Pages.DB();

            FrameOpacity = 1;

            CurrentPage = Main;
        }

        public ICommand bMenuMain_Click
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(Main));
            }

        }

        public ICommand bMenuCalc_Click
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(Calculation));
            }
        }

        public ICommand bMenuDatabase_Click
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(DB));
            }
        }

        public async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
                CurrentPage = page;
                for (double i = 0.0; i < 1.1; i += 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
            });
        }
    }
}
