#pragma checksum "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfdb937a237c162aa076e41eda00e839278f401e"
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
#line 2 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
using blalogin.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployee/{Id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Employee</h2>\n<hr>\n\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "form", "Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                                                obj.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Id = __value, obj.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\n                ");
            __builder.AddMarkupContent(22, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "form", "Name");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                                                obj.EmployeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.EmployeName = __value, obj.EmployeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\n                <label for=\"Gender\" class=\"control-label\"></label>\n                ");
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                obj.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Gender = __value, obj.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", true);
            __builder.AddContent(40, "-Select Gender");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "Male");
            __builder.AddContent(44, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                    ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "Female");
            __builder.AddContent(48, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\n                ");
            __builder.AddMarkupContent(55, "<label for=\"Designation\" class=\"control-label\">Designation</label>\n                ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "form", "Designation");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                                                       obj.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Designation = __value, obj.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "\n                ");
            __builder.AddMarkupContent(66, "<label for=\"City\" class=\"control-label\">City</label>\n                ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "form", "City");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                                                obj.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.City = __value, obj.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n\n    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.AddMarkupContent(78, "\n        ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-md-4");
            __builder.AddMarkupContent(81, "\n            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "form-group");
            __builder.AddMarkupContent(84, "\n                ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "button");
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                                                        UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n                ");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "btn btn-primary");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Srikanth\source\repos\blalogin\Pages\EditEmployee.razor"
        [Parameter]
    public string Id { get; set; }
    Employee obj = new Employee();
    protected override async Task OnInitializedAsync()
    {
        obj = await Task.Run(() => employeeService.GetEmployeeAsync(Convert.ToInt32(Id)));
    }
    protected async void UpdateEmployee()
    {
        await employeeService.UpdateEmployeeAsync(obj);
        NavigationManager.NavigateTo("Employees");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employees");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591