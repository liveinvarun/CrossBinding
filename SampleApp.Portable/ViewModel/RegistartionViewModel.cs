//
//  RegistartionViewModel.cs
//
//  Author:
//       developer <Varun.ravindranath@cognizant.com>
//
//  Copyright (c) 2017 (c) Varun R
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SampleApp.Portable
{
    public class RegistartionViewModel : MvxViewModel
    {

        private string _username;
        public RegistartionViewModel()
        {
        }

        bool _isEnabled = true;
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                _isEnabled = value;
                RaisePropertyChanged(() => IsEnabled);
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged(() => Username);
            }
        }

        private MvxCommand _login;
        public MvxCommand Login
        {
            get
            {
                _login = _login ?? new MvxCommand(DoLogin, () => IsEnabled);
                return _login;
            }
        }



        private void DoLogin()
        {
            // call the logb service
        }
    }
}
