#pragma checksum "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66faab8f21056d2677d8972554b07539a533f0a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#nullable restore
#line 1 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\_ViewImports.cshtml"
using MyGuild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\_ViewImports.cshtml"
using MyGuild.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66faab8f21056d2677d8972554b07539a533f0a7", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0791dc331182bef88a96a20342953667cdafcdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyGuild.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Пользователь ");
#nullable restore
#line 5 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>Имя</dt>\r\n        <dd>");
#nullable restore
#line 10 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 10 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
                   Write(Model.Server);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Спек</dt>\r\n        <dd>");
#nullable restore
#line 13 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
       Write(Model.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Логи</dt>\r\n");
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 344, "\"", 362, 1);
#nullable restore
#line 17 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
WriteAttributeValue("", 351, Model.Logs, 351, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Кликай!</a>\r\n\r\n        <dt>Доп.инфа</dt>\r\n        <dd>");
#nullable restore
#line 20 "D:\Desktop\respos\Test\0\MyGuild\MyGuild\Views\Home\Details.cshtml"
       Write(Model.Additionalinfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyGuild.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
