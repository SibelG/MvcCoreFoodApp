#pragma checksum "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27cbf6e0cac4ed3e69d42143ee2dfb91da56fb1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27cbf6e0cac4ed3e69d42143ee2dfb91da56fb1f", @"/Views/Category/CategoryGet.cshtml")]
    #nullable restore
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Online_Shop.Data.Models.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoryGet</h1>\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
 using (Html.BeginForm("CategoryUpdate", "Category", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "*", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
Write(Html.TextAreaFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\" btn btn-warning\">Update</button>\r\n");
#nullable restore
#line 27 "C:\Users\sblgn\source\repos\Online_Shop\Online_Shop\Views\Category\CategoryGet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Online_Shop.Data.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
