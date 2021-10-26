#pragma checksum "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc7a4e0a5ce1ff9cda2bdf2407e3b0573b42cba"
// <auto-generated/>
#pragma warning disable 1591
namespace blalogin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using blalogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Srikanth\source\repos\blalogin\_Imports.razor"
using blalogin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
using blalogin.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AddEmployee");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.AddMarkupContent(6, "<button type=\"button\" class=\"btn btn-primary\"><i class=\"fa fa-plus\"></i>  Add New</button>\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
#nullable restore
#line 10 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
 if (EmpObj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>Loading... !</em></p> ");
#nullable restore
#line 12 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
                             }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\n    ");
            __builder.AddMarkupContent(12, @"<thead>
        <tr>
            <th>Emp Id</th>
            <th>Employee Name</th>
            <th>Gender</th>
            <th>Designation</th>
            <th>City</th>
            <th>Action</th>
            <th>Action</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 28 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
         foreach (var emp in EmpObj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
         emp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
         emp.EmployeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
         emp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
         emp.Designation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 35 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
         emp.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.OpenElement(32, "td");
            __builder.AddMarkupContent(33, "\n        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "EditEmployee/" + (
#nullable restore
#line 37 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
                                                emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\n\n            ");
            __builder.AddMarkupContent(38, "<button type=\"button\" class=\"btn btn-outline-success\"> <i class=\"fa fa-edit\"></i> Edit</button>\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\n\n        ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "Delete/" + (
#nullable restore
#line 45 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
                                          emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "\n            ");
            __builder.AddMarkupContent(47, "<button type=\"button\" class=\"btn btn-outline-danger\"><i class=\"fa fa-trash\"></i>  Delete</button>\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#nullable restore
#line 51 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Srikanth\source\repos\blalogin\Pages\Employees.razor"
        List<Employee> EmpObj;
    protected override async Task OnInitializedAsync()
    {
        EmpObj = await Task.Run(() => employeeService.GetAllEmployeesAsync());
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
