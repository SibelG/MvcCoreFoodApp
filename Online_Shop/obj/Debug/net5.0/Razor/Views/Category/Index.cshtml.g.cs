#pragma checksum "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f035b20be90de2d338bd34282b492a998b0d9e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f035b20be90de2d338bd34282b492a998b0d9e13", @"/Views/Category/Index.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Online_Shop.Data.Models.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n<br/>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Category Name:");
#nullable restore
#line 12 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
                 Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Find\" />\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>CategoryName</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
     foreach(var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
   Write(x.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
   Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
   Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 640, "\"", 685, 2);
            WriteAttributeValue("", 647, "/Category/CategoryDelete/", 647, 25, true);
#nullable restore
#line 31 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
WriteAttributeValue("", 672, x.CategoryId, 672, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 737, "\"", 779, 2);
            WriteAttributeValue("", 744, "/Category/CategoryGet/", 744, 22, true);
#nullable restore
#line 32 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
WriteAttributeValue("", 766, x.CategoryId, 766, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n</tr>\r\n");
#nullable restore
#line 34 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a class=\"btn btn-primary\" href=\"/Category/CategoryAdd\">New Category</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Online_Shop.Data.Models.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591