#pragma checksum "C:\Users\tomek\Downloads\cw11\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4f1f96afb93d9377323ff67b0a976de054fe57"
// <auto-generated/>
#pragma warning disable 1591
namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tomek\Downloads\cw11\_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-hn8lsfub33>Students</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "b-hn8lsfub33");
            __builder.OpenElement(3, "thead");
            __builder.AddAttribute(4, "b-hn8lsfub33");
            __builder.OpenElement(5, "tr");
            __builder.AddAttribute(6, "b-hn8lsfub33");
            __builder.AddMarkupContent(7, "<th b-hn8lsfub33>Avatar</th>\r\n            ");
            __builder.OpenElement(8, "th");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                          SortByFirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-hn8lsfub33");
            __builder.AddMarkupContent(11, "<span class=\"text\" b-hn8lsfub33>First Name</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                          SortByLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "b-hn8lsfub33");
            __builder.AddMarkupContent(16, "<span class=\"text\" b-hn8lsfub33>Last Name</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "th");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                          SortByBirthDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "b-hn8lsfub33");
            __builder.AddMarkupContent(21, "<span class=\"text\" b-hn8lsfub33>BirthDate</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "th");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                          SortByStudies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "b-hn8lsfub33");
            __builder.AddMarkupContent(26, "<span class=\"text\" b-hn8lsfub33>Studies</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.AddMarkupContent(28, "<th b-hn8lsfub33>Actions</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "tbody");
            __builder.AddAttribute(31, "b-hn8lsfub33");
#nullable restore
#line 19 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
         foreach (var stud in StudentsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.AddAttribute(33, "b-hn8lsfub33");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "b-hn8lsfub33");
            __builder.OpenElement(36, "img");
            __builder.AddAttribute(37, "src", 
#nullable restore
#line 22 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                           stud.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "alt", (
#nullable restore
#line 22 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                                              stud.FirstName

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 22 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                                                              stud.LastName

#line default
#line hidden
#nullable disable
            ) + " Avatar");
            __builder.AddAttribute(39, "b-hn8lsfub33");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "b-hn8lsfub33");
#nullable restore
#line 23 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
__builder.AddContent(43, stud.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "b-hn8lsfub33");
#nullable restore
#line 24 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
__builder.AddContent(47, stud.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-hn8lsfub33");
#nullable restore
#line 25 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
__builder.AddContent(51, stud.BirthDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "b-hn8lsfub33");
#nullable restore
#line 26 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
__builder.AddContent(55, stud.Studies);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "b-hn8lsfub33");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                                    () => OpenDetails(stud.IdStudent)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "b-hn8lsfub33");
            __builder.AddContent(62, "Open details");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
                                    () => Delete(stud.IdStudent)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "b-hn8lsfub33");
            __builder.AddContent(67, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\tomek\Downloads\cw11\Pages\Students.razor"
        

    public IEnumerable<Student> StudentsList { get; set; }

    protected override void OnInitialized()
    {
        StudentsList = StudentService.GetStudents();
    }

    private void OpenDetails(int id)
    {
        NavigationManager.NavigateTo($"/students/{id}");
    }
    

    private async Task Delete(int id)
    {
        if(await js.InvokeAsync<bool>("confirm", "Are you sure?"))
        {
            StudentService.DeleteStudent(id);
        }
    }
    private bool order = true;
    private void SortByFirstName()
    {
        if (order == true)
        {
            StudentsList = StudentsList.OrderBy(student => student.FirstName).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.FirstName).ToList();
            order = true;
        }
    }
    private void SortByLastName()
    {
        if (order == true)
        {
            StudentsList = StudentsList.OrderBy(student => student.LastName).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.LastName).ToList();
            order = true;
        }
    }
    private void SortByBirthDate()
    {
        if (order == true)
        {
            StudentsList = StudentsList.OrderBy(student => student.BirthDate).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.BirthDate).ToList();
            order = true;
        }
    }
    private void SortByStudies()
    {
        if (order == true)
        {
            StudentsList = StudentsList.OrderBy(student => student.Studies).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.Studies).ToList();
            order = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
