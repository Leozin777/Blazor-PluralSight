using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));
            return base.OnInitializedAsync();
        }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(Employee selectedEmployee)
        {
            NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
        }
    }
}
