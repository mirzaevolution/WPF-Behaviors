using InvokeCommandAndCallMethod.View.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace InvokeCommandAndCallMethod
{
    public class MainWindowViewModel
    {
        public event EventHandler<string> Information;
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        public MainWindowViewModel()
        {
            ShowEmployeeCommand = new RelayCommand(OnShowEmployee, CanShowEmployee);
        }

        private void OnShowEmployee(object obj)
        {
            if(obj is Employee emp)
            {
                string json = JsonConvert.SerializeObject(obj,Formatting.Indented);
                Information?.Invoke(this, json);
            }
        }
        private ObservableCollection<Employee> GetEmployees()
        {
            Thread.Sleep(3000);
            return new ObservableCollection<Employee>
            {
                new Employee { FirstName="Mirza Ghulam", LastName = "Rasyid", Job = "Developer", DateAccepted = DateTime.Now },
                new Employee { FirstName="Rara", LastName = "Anjani", Job = "Developer", DateAccepted = DateTime.Now },
                new Employee { FirstName="Beggi", LastName = "Mammad", Job = "Developer", DateAccepted = DateTime.Now },
                new Employee { FirstName="Michael", LastName = "Hawk", Job = "Developer", DateAccepted = DateTime.Now },
                new Employee { FirstName="Jason", LastName = "Statham", Job = "Developer", DateAccepted = DateTime.Now }

            };
        }
        public async void LoadEmployees()
        {
            var r = await Task.Run<ObservableCollection<Employee>>(() => GetEmployees());
            foreach(var i in r)
            {
                Employees.Add(i);
            }
        }
        private bool CanShowEmployee(object obj)
        {
            return ((Employee)obj) != null;
        }

        public RelayCommand ShowEmployeeCommand { get; set; }
    }
}
