using ImplicitDataTemplate.View.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImplicitDataTemplate.EmployeeDetail
{
    public class EmployeeDetailViewModel:INotifyPropertyChanged
    {
        private string _employeeId;
        private Employee _employee;
        public event EventHandler BackToMain;
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand BackToMainCommand { get; set; }
        public string EmployeeId
        {
            get { return _employeeId; }
            set
            {
                if (_employeeId != value)
                {
                    _employeeId = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmployeeId)));
                }
            }
        }
        public Employee Employee
        {
            get { return _employee; }
            set
            {
                if (_employee != value)
                {
                    _employee = value;
                    PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Employee)));
                }
            }
        }

        public EmployeeDetailViewModel()
        {
            BackToMainCommand = new RelayCommand(OnBackToMain);
        }

        private void OnBackToMain(object obj)
        {
            BackToMain?.Invoke(this, EventArgs.Empty);
        }

        public void GetData()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
                return;
            Employee = GlobalDataAccess.GetEmployees(EmployeeId).FirstOrDefault();
        }
    }
}
