#pragma checksum "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062fc77a767d0d63ecb15873aa9ebbd67ed82df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewDish), @"mvc.1.0.view", @"/Views/Home/ViewDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewDish.cshtml", typeof(AspNetCore.Views_Home_ViewDish))]
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
#line 1 "D:\CodingDojo\csharp\CrudDelicious\Views\_ViewImports.cshtml"
using CrudDelicious;

#line default
#line hidden
#line 1 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
using CrudDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062fc77a767d0d63ecb15873aa9ebbd67ed82df7", @"/Views/Home/ViewDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3476cfc9014dc11f49172991087a9128dd431e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 27, true);
            WriteLiteral("<a href =\"/\">Home</a>\r\n<h1>");
            EndContext();
            BeginContext(70, 10, false);
#line 4 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(80, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(92, 23, false);
#line 5 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
Write(Model.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(115, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(126, 17, false);
#line 6 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(143, 19, true);
            WriteLiteral("</p>\r\n<p>Calories: ");
            EndContext();
            BeginContext(163, 14, false);
#line 7 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
        Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(177, 20, true);
            WriteLiteral("</p>\r\n<p>Tastiness: ");
            EndContext();
            BeginContext(198, 15, false);
#line 8 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(213, 8, true);
            WriteLiteral("</p>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href = \"", 221, "\"", 249, 2);
            WriteAttributeValue("", 230, "/edit/", 230, 6, true);
#line 9 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
WriteAttributeValue("", 236, Model.DishId, 236, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(250, 13, true);
            WriteLiteral(">Edit</a>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href = \"", 263, "\"", 293, 2);
            WriteAttributeValue("", 272, "/delete/", 272, 8, true);
#line 10 "D:\CodingDojo\csharp\CrudDelicious\Views\Home\ViewDish.cshtml"
WriteAttributeValue("", 280, Model.DishId, 280, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(294, 11, true);
            WriteLiteral(">Delete</a>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
