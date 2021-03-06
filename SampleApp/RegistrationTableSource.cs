//
//  SignInTableSource.cs
//
//  Author:
//       developer  
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
using System.Collections.Generic;
using System.Linq;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Core;
using SampleApp.Portable;
using UIKit;

namespace SampleApp
{
    public class RegistrationTableSource : MvxTableViewSource
    {
        private static readonly NSString RegistrationCell = new NSString("RegistrationCell");
        private UITableView _tableView = null;
        private RegistartionViewModel _viewmodel;

        public RegistrationTableSource(RegistartionViewModel viewmodel, UITableView tableView)
                            : base(tableView)
        {
            //modelList = viewmodel;
            _viewmodel = viewmodel;
            _tableView = tableView;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 1;
        }


        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            if (_tableView != null)
            {
                var registrationCell = _tableView.DequeueReusableCell(RegistrationCell, indexPath) as RegistrationCell;
                if (registrationCell != null)
                {
                    var bindable = registrationCell as IMvxDataConsumer;
                    bindable.DataContext = _viewmodel;

                }

                return registrationCell;
            }
            return new UITableViewCell();
        }
    }
}
