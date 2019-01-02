using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplicitDataTemplate.EmployeeList;
using ImplicitDataTemplate.EmployeeDetail;
using System.ComponentModel;
using System.Windows.Input;
using ImplicitDataTemplate.View.ViewModel;

namespace ImplicitDataTemplate
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        private object _currentView;
        private EmployeeListViewModel _employeeListViewModel = new EmployeeListViewModel();
        private EmployeeDetailViewModel _employeeDetailViewModel = new EmployeeDetailViewModel();
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                if (_currentView != value)
                {
                    _currentView = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentView)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            _employeeListViewModel = new EmployeeListViewModel();
            _employeeDetailViewModel= new EmployeeDetailViewModel();
            _employeeListViewModel.EmployeeChanged += EmployeeListViewModel_EmployeeChanged;
            _employeeDetailViewModel.BackToMain += EmployeeDetailViewModel_BackToMain;
            CurrentView = _employeeListViewModel;
        }

        private void EmployeeListViewModel_EmployeeChanged(object sender, Employee e)
        {
            if (_employeeListViewModel.SelectedEmployee != null)
            {
                _employeeDetailViewModel.EmployeeId = _employeeListViewModel.SelectedEmployee.Id;
                CurrentView = _employeeDetailViewModel;
            }
        }

       
        private void EmployeeDetailViewModel_BackToMain(object sender, EventArgs e)
        {
            CurrentView = _employeeListViewModel;
        }
    }
}
