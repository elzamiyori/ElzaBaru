#pragma checksum "C:\Elza\ElzaBaru\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa7abb9bc65aeb762f68e37d387c9afc8c9cc1c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Elza\ElzaBaru\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Elza\ElzaBaru\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Elza\ElzaBaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Elza\ElzaBaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Elza\ElzaBaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Elza\ElzaBaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Elza\ElzaBaru\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Elza\ElzaBaru\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Elza\ElzaBaru\_Imports.razor"
using BlazorFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Elza\ElzaBaru\_Imports.razor"
using BlazorFront.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\" style=\"font-weight:bold;\">LIST EMPLOYEES</h3>\n<br>\n\n");
            __builder.AddMarkupContent(1, "<a href=\"employeepage\" class=\"btn btn-warning\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\" title=\"Add Employee\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add Employee\n</a>\n\n<br><br>");
#nullable restore
#line 12 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"spinner\"></div>");
#nullable restore
#line 15 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-deck");
#nullable restore
#line 20 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
         foreach (var emp in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card m-3");
            __builder.AddAttribute(7, "style", "min-width: 18rem; max-width: 30.5%;");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-header");
            __builder.OpenElement(10, "h3");
            __builder.AddAttribute(11, "class", "text-center");
            __builder.AddContent(12, 
#nullable restore
#line 24 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                                             emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 24 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                                                            emp.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                     if (@emp.Gender == 0)
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<img class=\"card-img-top imageThumbnail\" src=\"images/mau.jpg\">");
#nullable restore
#line 29 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<img class=\"card-img-top imageThumbnail\" src=\"images/nion.jpg\">");
#nullable restore
#line 33 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-footer text-center");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 36 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                                   $"employeedetail/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-info m-1");
            __builder.AddAttribute(22, "data-bs-toggle", "tooltip");
            __builder.AddAttribute(23, "data-bs-placement", "top");
            __builder.AddAttribute(24, "title", "Detail");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\"> Detail</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n\n                        ");
            __builder.AddMarkupContent(27, "<a href=\"employeepage\" class=\"btn btn-success m-1\" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\" title=\"Delete\"><span aria-hidden=\"true\"> Delete</span></a>\n\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 46 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                                   $"editemployee/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "btn btn-danger m-1");
            __builder.AddAttribute(31, "data-bs-toggle", "tooltip");
            __builder.AddAttribute(32, "data-bs-placement", "top");
            __builder.AddAttribute(33, "title", "Edit");
            __builder.AddMarkupContent(34, "<span aria-hidden=\"true\"> Edit</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Elza\ElzaBaru\Pages\EmployeePage.razor"
                        
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
