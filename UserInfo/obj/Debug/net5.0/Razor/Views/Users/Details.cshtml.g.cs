#pragma checksum "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\Users\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ae1199e79c2ca984279d44ab5241de7df1cdd5c733cb87b2d2cccbf825f0fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\_ViewImports.cshtml"
using UserInfo

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ae1199e79c2ca984279d44ab5241de7df1cdd5c733cb87b2d2cccbf825f0fe4", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"46a86b09397ca4b6636784c5cb4d5fa2db8c06f59c00e459634e04279fbe95b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\Users\Details.cshtml"
       UserInfo.Entities.User

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>User Details</h2>\r\n<p><strong>Name:</strong> ");
            Write(
#nullable restore
#line 6 "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\Users\Details.cshtml"
                           Model.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n<p><strong>Surname:</strong> ");
            Write(
#nullable restore
#line 7 "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\Users\Details.cshtml"
                              Model.Surname

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n<p><strong>Image:</strong> <img");
            BeginWriteAttribute("src", " src=\"", 186, "\"", 204, 1);
            WriteAttributeValue("", 192, 
#nullable restore
#line 8 "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\Users\Details.cshtml"
                                      Model.Image

#line default
#line hidden
#nullable disable
            , 192, 12, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"User Image\" style=\"width:100px;\" /></p>\r\n<p><strong>Age:</strong> ");
            Write(
#nullable restore
#line 9 "C:\Users\USER\source\repos\UserInfo\UserInfo\Views\Users\Details.cshtml"
                          Model.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n<a href=\"/Users/Index\">Back to List</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInfo.Entities.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
