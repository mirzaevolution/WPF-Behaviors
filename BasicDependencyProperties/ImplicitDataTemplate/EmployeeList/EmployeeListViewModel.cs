using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplicitDataTemplate.View.ViewModel;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ImplicitDataTemplate.EmployeeList
{
    public class EmployeeListViewModel : INotifyPropertyChanged
    {
        private Employee _selectedEmployee;
        private ObservableCollection<Employee> _employees;

        public event EventHandler<Employee> EmployeeChanged;
        public Employee SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                if(_selectedEmployee!=value)
                {
                    _selectedEmployee = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedEmployee)));
                }
            }
        }
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                if (_employees != value)
                {
                    _employees = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Employees)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void LoadEmployees()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
                return;
            Employees = new ObservableCollection<Employee>(GlobalDataAccess.GetEmployees());
        }
        public void OnEmployeeChanged()
        {
            EmployeeChanged?.Invoke(this, SelectedEmployee);
        }
    }
}
