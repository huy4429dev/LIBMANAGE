#pragma checksum "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c63abb5d8b9dd63d3068543045277d743c24cf46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Post_Index), @"mvc.1.0.view", @"/Views/Admin/Post/Index.cshtml")]
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
#line 6 "C:\Users\HUY 4\Desktop\LIB2\Views\_ViewImports.cshtml"
using LibManage.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
using LibManage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63abb5d8b9dd63d3068543045277d743c24cf46", @"/Views/Admin/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PostIndexViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/post/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/common/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/common/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "TIN MỚI";
    ViewBag.PageName = "TIN MỚI";
    ViewBag.Link = "/admin/post";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <main>\r\n                     <div class=\"card mb-4\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c63abb5d8b9dd63d3068543045277d743c24cf466715", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 11 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            \r\n");
#nullable restore
#line 13 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 16 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 18 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                             if(@TempData["error"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    ");
#nullable restore
#line 22 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                               Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 24 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c63abb5d8b9dd63d3068543045277d743c24cf4610018", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm kiếm bài viết"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                            <div class=""input-group-append"">
                                                <button type=""submit"" class=""input-group-text"" id=""basic-addon2""><i class=""fas fa-search""></i></button>
                                            </div>
                                    </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                            <div class=""card-header d-flex justify-content-between "">
                                 <a href=""/admin/post/create"" class=""btn btn-primary btn-sm"" ><i class=""fas fa-plus""></i></a>
                            </div>
                         
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
    <tr>
      <th class=""th-sm"" >#ID
      </th>
       <th class=""th-sm"" >
         
      </th>
      <th class=""th-sm"">Tiêu đề
      </th>
      <th class=""th-sm"">Mô tả
      </th>
      <th class=""th-sm"">Tác giả
      </th>
      <th class=""th-sm text-center"">Thời gian
      </th>
      <th colspan=""2"" class=""text-center"">Action</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 62 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
     foreach (var item in  Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr style=\"cursor:pointer\">\r\n      <td>");
#nullable restore
#line 65 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td class=\"text-center\">\r\n        <img style=\"width:50px\"");
            BeginWriteAttribute("src", " src=\"", 2790, "\"", 2811, 1);
#nullable restore
#line 67 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
WriteAttributeValue("", 2796, item.Thumbnail, 2796, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2812, "\"", 2818, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n      </td>\r\n      <td style=\"width:25%\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2875, "\"", 2904, 2);
            WriteAttributeValue("", 2882, "/admin/post/", 2882, 12, true);
#nullable restore
#line 70 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
WriteAttributeValue("", 2894, item.Id, 2894, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n          ");
#nullable restore
#line 71 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
      Write(item.Title.Length > 30 ? item.Title.Substring(0,30) + "..." : item.Title );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n      </td>\r\n      <td style=\"width:25%\">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 3065, "\"", 3094, 2);
            WriteAttributeValue("", 3072, "/admin/post/", 3072, 12, true);
#nullable restore
#line 75 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
WriteAttributeValue("", 3084, item.Id, 3084, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n             ");
#nullable restore
#line 76 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
         Write(item.Description.Length > 30 ? item.Description.Substring(0,30) + "..." : item.Description );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </a>\r\n      </td>\r\n      <td>\r\n        ");
#nullable restore
#line 80 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
    Write(item.Author ?? "Admin");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n      <td class=\"text-center\">\r\n        ");
#nullable restore
#line 83 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
   Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n       <td style=\"width: 100px\" class=\"text-center\" ><a");
            BeginWriteAttribute("href", " href = \"", 3421, "\"", 3452, 2);
            WriteAttributeValue("", 3430, "/admin/post/", 3430, 12, true);
#nullable restore
#line 85 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
WriteAttributeValue("", 3442, item.Id, 3442, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-success\" >Sửa</a></td>\r\n       <td style=\"width: 100px\" class=\"text-center\"><button class=\"btn btn-danger btn-sm btn-delete\" type=\"button\" data-toggle=\"modal\" data-target=\"#deleteModal");
#nullable restore
#line 86 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
                                                                                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button></td>\r\n    </tr>\r\n");
#nullable restore
#line 88 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"

     
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
      //  var deleteButtons = document.querySelectorAll('.btn-delete');
      //  deleteButtons.forEach(item => item.addEventListener('click', function(e){ e.stopPropagation(); 

      //  }));
    </script>
  </tbody>
                                    </table>
                                </div>
                            </div>
                     </div>
 </main>

");
            WriteLiteral("\r\n");
#nullable restore
#line 107 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
        foreach (var item in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4230, "\"", 4256, 2);
            WriteAttributeValue("", 4235, "deleteModal", 4235, 11, true);
#nullable restore
#line 109 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
WriteAttributeValue("", 4246, item.Id, 4246, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Xóa bài viết</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn có muốn xóa bài viết ?
            </div>
            <div class=""modal-footer"">
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c63abb5d8b9dd63d3068543045277d743c24cf4619296", async() => {
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Hủy</button>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Lưu</button>\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4948, "/admin/post/delete/", 4948, 19, true);
#nullable restore
#line 122 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
AddHtmlAttributeValue("", 4967, item.Id, 4967, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 130 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Post\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c63abb5d8b9dd63d3068543045277d743c24cf4621844", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n      .show-Content{\r\n        cursor: pointer;\r\n      }\r\n      .show-Content:hover{\r\n         color:blue;\r\n      }\r\n          .alert.alert-danger.validation-summary-valid {\r\n        display: none;\r\n    }\r\n    </style>\r\n");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c63abb5d8b9dd63d3068543045277d743c24cf4623398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#dtBasicExample').DataTable( 
               {  
                 ""order"": [[ 0, ""desc"" ]],
               },
            );
            $('.dataTables_length').addClass('bs-select');
        });
      function blogDetail(id){
        window.location.href = ""/admin/post/"" + id;
      }
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PostIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591