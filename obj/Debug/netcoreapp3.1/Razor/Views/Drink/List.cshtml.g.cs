#pragma checksum "C:\Users\Dell\source\repos\DringsAndGo\DringsAndGo\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c1fd61576eb6bf6d9834cd3f05f16dc035f8ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Drink/List.cshtml", typeof(AspNetCore.Views_Drink_List))]
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
#line 1 "C:\Users\Dell\source\repos\DringsAndGo\DringsAndGo\Views\Drink\List.cshtml"
using DringsAndGo.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c1fd61576eb6bf6d9834cd3f05f16dc035f8ad", @"/Views/Drink/List.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Drink>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 65, true);
            WriteLiteral("\r\n<div>\r\n    <h4> All the Drinks are shown here </h4>\r\n</div>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Dell\source\repos\DringsAndGo\DringsAndGo\Views\Drink\List.cshtml"
   
    foreach(var drink in Model)
    {

#line default
#line hidden
            BeginContext(169, 42, true);
            WriteLiteral("        <div>\r\n            <h4>Drink Name:");
            EndContext();
            BeginContext(212, 10, false);
#line 12 "C:\Users\Dell\source\repos\DringsAndGo\DringsAndGo\Views\Drink\List.cshtml"
                      Write(drink.Name);

#line default
#line hidden
            EndContext();
            BeginContext(222, 29, true);
            WriteLiteral("</h4>\r\n            <p>Price :");
            EndContext();
            BeginContext(252, 25, false);
#line 13 "C:\Users\Dell\source\repos\DringsAndGo\DringsAndGo\Views\Drink\List.cshtml"
                 Write(drink.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(277, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\Users\Dell\source\repos\DringsAndGo\DringsAndGo\Views\Drink\List.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Drink>> Html { get; private set; }
    }
}
#pragma warning restore 1591
