﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Channels;

namespace BethanysPieShopHRM.App.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        public void Close()
        {
            _employee = null;
        }
    }
}
