#pragma checksum "C:\Users\liana\Documents\GitHub\Science_SemesterTask\Science_WebSite\Pages\User\PrivateAcc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a39a83e6f461b1075c59af7f4a7a3ac27049d20a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Science_WebSite.Pages.User.Pages_User_PrivateAcc), @"mvc.1.0.razor-page", @"/Pages/User/PrivateAcc.cshtml")]
namespace Science_WebSite.Pages.User
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
#line 1 "C:\Users\liana\Documents\GitHub\Science_SemesterTask\Science_WebSite\Pages\_ViewImports.cshtml"
using Science_WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\liana\Documents\GitHub\Science_SemesterTask\Science_WebSite\Pages\_ViewImports.cshtml"
using Science_WebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a39a83e6f461b1075c59af7f4a7a3ac27049d20a", @"/Pages/User/PrivateAcc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70463eecc1408b0fd1b36eeeeb26a52095c7b424", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User_PrivateAcc : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\liana\Documents\GitHub\Science_SemesterTask\Science_WebSite\Pages\User\PrivateAcc.cshtml"
  
    ViewData["Title"] = "Private Account";
    //Models.User user = Model._ 
    //string id = HttpContext.Request.Cookies["key"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- content ================================================== -->
<div id=""content"">
    <!-- blog-section ================================================== -->
    <section class=""blog-section single2"">
        <div class=""blog-post single-post"">
            <div class=""container"">
                <h2 align=""center"">Профиль</h2>
                <div class=""container"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div id=""myTabContent"" class=""tab-content"">
                                <hr>
                                <div class=""tab-pane fade active in"" id=""detail"">
                                    <h4>Профиль пользователя</h4>
                                    <table class=""table table-th-block"">
                                        <tbody>
                                            <tr><td class=""active"">Имя:</td><td>Marina");
            WriteLiteral("</td></tr>\r\n                                            <tr><td class=\"active\">Email:</td><td>Marizzard@gmail.com");
            WriteLiteral("</td></tr>\r\n");
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End blog section -->

</div>
<!-- End content -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Science_WebSite.Pages.User.PrivateAccModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Science_WebSite.Pages.User.PrivateAccModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Science_WebSite.Pages.User.PrivateAccModel>)PageContext?.ViewData;
        public Science_WebSite.Pages.User.PrivateAccModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591