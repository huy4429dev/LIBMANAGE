#pragma checksum "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d23715a880e33433801dbf228f7931cdb3969c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\LIB2\Views\_ViewImports.cshtml"
using LibManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\LIB2\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUY 4\Desktop\LIB2\Views\_ViewImports.cshtml"
using LibManage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUY 4\Desktop\LIB2\Views\_ViewImports.cshtml"
using LibManage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUY 4\Desktop\LIB2\Views\_ViewImports.cshtml"
using LibManage.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d23715a880e33433801dbf228f7931cdb3969c", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
  
    var user = httpContextAccessor.HttpContext.Session.Get<User>("user");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c6376", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 428, "\"", 438, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 467, "\"", 477, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <title>Admin - ");
#nullable restore
#line 18 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link href=""/assets/admin/css/styles.css"" rel=""stylesheet"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js""
        crossorigin=""anonymous""></script>
   <style>
        table tr:hover {
            background: #74b9ff;
            transition: 0.2s all;
        }
        .fix-center {
        display: flex;
        justify-content: center;
        align-items: center;
        }

        .loader {
        border: 16px solid #f3f3f3;
        border-radius: 50%;
        border-top: 16px solid #3498db;
        width: 120px;
        height: 120px;
        -webkit-animation: spin 2s linear infinite;
        /* Safari */
        animation: spin 2s linear infinite;
        }
    </style>
    
");
#nullable restore
#line 45 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
     if (IsSectionDefined("Css"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
   Write(RenderSection("Css", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
                                            
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n \r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c9587", async() => {
                WriteLiteral(@"
        <nav class=""sb-topnav navbar navbar-expand navbar-dark bg-dark"">
            <a class=""navbar-brand"" href=""/admin/dashboard"">LIB MANAGE</a>
            <button class=""btn btn-link btn-sm order-1 order-lg-0"" id=""sidebarToggle"" href=""#""><i
                    class=""fas fa-bars""></i></button>
            <ul class=""navbar-nav ml-auto ml-md-0 d-flex w-100 justify-content-end"">
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown""
                        aria-haspopup=""true"" aria-expanded=""false""><i class=""fas fa-user fa-fw""></i></a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
");
                WriteLiteral(@"                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""/admin/logout"">Đăng xuất</a>
                    </div>
                </li>
            </ul>
        </nav>
        <div id=""layoutSidenav"">
            <div id=""layoutSidenav_nav"">
                <nav class=""sb-sidenav accordion sb-sidenav-dark"" id=""sidenavAccordion"">
                    <div class=""sb-sidenav-menu"">
                        <div class=""nav"">
                            <div class=""sb-sidenav-menu-heading"">Core</div>
                            <a class=""nav-link"" href=""/admin/dashboard"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                Dashboard
                            </a>

                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c11569", async() => {
                    WriteLiteral("\r\n                                <div class=\"sb-nav-link-icon\"> <i class=\"fas fa-user\"></i></div>\r\n\r\n                                Hồ sơ\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                            <div class=""sb-sidenav-menu-heading"">Interface</div>

                            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages""
                                aria-expanded=""false"" aria-controls=""collapsePages"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
                                Sách
                                <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                            </a>
                            <div class=""collapse"" id=""collapsePages"" aria-labelledby=""headingTwo""
                                data-parent=""#sidenavAccordion"">
                                <nav class=""sb-sidenav-menu-nested nav accordion"" id=""sidenavAccordionPages"">
                                    <a class=""nav-link collapsed"" href=""/admin/book/booktype"">
                                        Loại sách
                          ");
                WriteLiteral(@"          </a>
                                    <a class=""nav-link collapsed"" href=""/admin/book/author"">
                                        Tác giả
                                    </a>
                                    <a class=""nav-link collapsed"" href=""/admin/book/publisher"">
                                        Nhà xuất bản
                                    </a>
                                    <a class=""nav-link collapsed"" href=""/admin/book"" aria-expanded=""false""
                                        aria-controls=""pagesCollapseAuth"">
                                        Sách
                                    </a>
                                </nav>
                            </div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c14848", async() => {
                    WriteLiteral("\r\n                                <div class=\"sb-nav-link-icon\"><i class=\"fas fa-user-tie\"></i></div>\r\n                                Khách hàng\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c16278", async() => {
                    WriteLiteral("\r\n                                <div class=\"sb-nav-link-icon\"><i class=\"fas fa-address-book\"></i></div>\r\n                                Lịch sử mượn\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                               <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages1""
                                aria-expanded=""false"" aria-controls=""collapsePages"">
                                     <div class=""sb-nav-link-icon""><i class=""fas fa-bookmark""></i></div>
                               Báo cáo
                                <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                            </a>
                            <div class=""collapse"" id=""collapsePages1"" aria-labelledby=""headingTwo""
                                data-parent=""#sidenavAccordion"">
                                <nav class=""sb-sidenav-menu-nested nav accordion"" id=""sidenavAccordionPages"">
                                    <a class=""nav-link collapsed"" href=""/admin/report/order"">
                                        Lượt mượn sách
                                    </a>
                                    <a class=""nav-");
                WriteLiteral(@"link collapsed"" href=""/admin/report/customer"">
                                        Tương tác khách hàng
                                    </a>
                                    <a class=""nav-link collapsed"" href=""/admin/report/employee"">
                                        Tương tác nhân viên
                                    </a>
                                </nav>
                            </div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c19244", async() => {
                    WriteLiteral("\r\n                                <div class=\"sb-nav-link-icon\"><i class=\"fas fa-book-reader\"></i></div>\r\n                                Tin tức\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23715a880e33433801dbf228f7931cdb3969c20674", async() => {
                    WriteLiteral("\r\n                                <div class=\"sb-nav-link-icon\"><i class=\"fas fa-id-card\"></i></div>\r\n                                Phản hồi\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                        </div>
                    </div>
                    <div class=""sb-sidenav-footer"">
                        <div class=""small"">Logged in as:</div>
                        LIB MANAGE
                    </div>
                </nav>
            </div>
            <div id=""layoutSidenav_content"">
                <main>

");
                WriteLiteral("\r\n                    <div class=\"container-fluid\">\r\n                        <h3 class=\"mt-4\">");
#nullable restore
#line 165 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
                                    Write(ViewBag.PageName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        ");
#nullable restore
#line 166 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </main>
                <footer class=""py-4 bg-light mt-auto"">
                    <div class=""container-fluid"">
                        <div class=""d-flex align-items-center justify-content-between small"">
                            <div class=""text-muted"">Copyright &copy; Your Website 2020</div>
                            <div>
                                <a href=""#"">Privacy Policy</a>
                                &middot;
                                <a href=""#"">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src=""https://code.jquery.com/jquery-3.5.1.min.js"" crossorigin=""anonymous""></script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js""
            crossorigin=""anonymous""></script>

");
#nullable restore
#line 187 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
         if (IsSectionDefined("Script"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
   Write(RenderSection("Script", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_LayoutAdmin.cshtml"
                                               
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor httpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
