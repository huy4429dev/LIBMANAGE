#pragma checksum "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "064f0cbe074b72ef98711e7828824e5437fae93a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_New_Detail), @"mvc.1.0.view", @"/Views/New/Detail.cshtml")]
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
#line 1 "E:\project\c#\LIB2\LIBMANAGE\Views\_ViewImports.cshtml"
using LibManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\LIB2\LIBMANAGE\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\c#\LIB2\LIBMANAGE\Views\_ViewImports.cshtml"
using LibManage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\project\c#\LIB2\LIBMANAGE\Views\_ViewImports.cshtml"
using LibManage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\project\c#\LIB2\LIBMANAGE\Views\_ViewImports.cshtml"
using LibManage.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"064f0cbe074b72ef98711e7828824e5437fae93a", @"/Views/New/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_New_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/new/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
  
    Layout = "_Layout";

    Post Post = Model;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Start Bradcaump area -->
		<div class=""ht__bradcaump__area bg-image--6"">
			<div class=""container"">
				<div class=""row"">
					<div class=""col-lg-12"">
						<div class=""bradcaump__inner text-center"">
							<h2 class=""bradcaump-title""></h2>
							<nav class=""bradcaump-content"">
								<a class=""breadcrumb_item"" href=""/"">Trang chủ</a>
								<span class=""brd-separetor"">/</span>
								<span class=""breadcrumb_item active"">");
#nullable restore
#line 17 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                                                Write(Post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
							</nav>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- End Bradcaump area -->
		<div class=""page-blog-details section-padding--lg bg--white"">
			<div class=""container"">
				<div class=""row"">
					<div class=""col-lg-9 col-12"">
						<div class=""blog-details content"">
							<article class=""blog-post-details"">
								<div class=""post-thumbnail"">
									<img");
            BeginWriteAttribute("src", " src=\"", 918, "\"", 939, 1);
#nullable restore
#line 32 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
WriteAttributeValue("", 924, Post.Thumbnail, 924, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"blog images\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"post_wrapper\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"post_header\">\r\n\t\t\t\t\t\t\t\t\t\t<h2>International activities of the Book</h2>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"blog-date-categori\">\r\n\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li>");
#nullable restore
#line 39 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                               Write(Post.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\" title=\"Posts by boighor\" rel=\"author\">");
#nullable restore
#line 40 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                                                                                 Write(Post.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"post_content\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 45 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                   Write(Html.Raw(Post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</article>\r\n\t\t\t\t\t\t\t<div class=\"comments_area\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"fb-comments mt-4\" data-href=\"http://localhost:5000/new/");
#nullable restore
#line 50 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                                                                                  Write(Post.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-width=""100%"" data-numposts=""5""></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-12 md-mt-40 sm-mt-40"">
						<div class=""wn__sidebar"">
							<!-- Start Single Widget -->
							<aside class=""widget search_widget"">
								<h3 class=""widget-title"">Tìm kiếm</h3>
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "064f0cbe074b72ef98711e7828824e5437fae93a8098", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-input\">\r\n\t\t\t\t\t\t\t\t\t\t<input name=\"q\" type=\"text\" placeholder=\"Tiêu đề, tác giả...\">\r\n\t\t\t\t\t\t\t\t\t\t<button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</aside>\r\n\t\t\t\t\t\t\t<!-- End Single Widget -->\r\n\t\t\t\t\t\t\t<!-- Start Single Widget -->\r\n\t\t\t\t\t\t\t<aside class=\"widget recent_widget\">\r\n\t\t\t\t\t\t\t\t<h3 class=\"widget-title\">Bài viết phổ biến</h3>\r\n\t\t\t\t\t\t\t\t<div class=\"recent-posts\">\r\n\t\t\t\t\t\t\t\t\t<ul>\r\n\r\n");
#nullable restore
#line 73 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                         foreach (var item in ViewBag.HotPosts)
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"post-wrapper d-flex\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"thumb\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2612, "\"", 2632, 2);
            WriteAttributeValue("", 2619, "/new/", 2619, 5, true);
#nullable restore
#line 78 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
WriteAttributeValue("", 2624, item.Id, 2624, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2638, "\"", 2659, 1);
#nullable restore
#line 78 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
WriteAttributeValue("", 2644, item.Thumbnail, 2644, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\talt=\"blog images\"></a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<h4><a");
            BeginWriteAttribute("href", " href=\"", 2779, "\"", 2799, 2);
            WriteAttributeValue("", 2786, "/new/", 2786, 5, true);
#nullable restore
#line 82 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
WriteAttributeValue("", 2791, item.Id, 2791, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p> ");
#nullable restore
#line 83 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
                                                       Write(item.CreatedAt.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 87 "E:\project\c#\LIB2\LIBMANAGE\Views\New\Detail.cshtml"
										}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</aside>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div id=\"fb-root\"></div>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n\t\t\t<script async defer crossorigin=\"anonymous\" src=\"https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v9.0&appId=3208946999217769&autoLogAppEvents=1\" nonce=\"yqJuEcR6\"></script>\t\r\n        ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
