#pragma checksum "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2566db58871f1610caa7791bd3cbc760df801695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Book_Publisher), @"mvc.1.0.view", @"/Views/Admin/Book/Publisher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2566db58871f1610caa7791bd3cbc760df801695", @"/Views/Admin/Book/Publisher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Book_Publisher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/book/publisher/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/book/publisher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "NHÀ XUẤT BẢN";
    ViewBag.PageName = "NHÀ XUẤT BẢN";
    ViewBag.Link = "/admin/book/publisher";
    var user = ViewData["User"] as User;
    
    List<Publisher> Publishers = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n   <style>\r\n       \r\n     /* Styles for validation helpers\r\n-----------------------------------------------------------*/\r\n\r\n\r\n    .alert.alert-danger.validation-summary-valid {\r\n        display: none;\r\n    }\r\n   </style>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n                    <div class=\"card mb-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2566db58871f1610caa7791bd3cbc760df8016956342", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 27 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
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
#line 29 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 32 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 34 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2566db58871f1610caa7791bd3cbc760df8016958853", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm kiếm nhà xuất bản"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                            <div class=""input-group-append"">
                                                <button type=""submit"" class=""input-group-text"" id=""basic-addon2"">Tìm kiếm</button>
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
                                <span>
                                    <i class=""fas fa-table mr-1""></i>
                                    Danh sách nhà xuất bản
                                </span>
                                 <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#addPublisher"" >Thêm mới</button>
                            </div>
                         
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Nhà xuất bản</th>
                                     ");
            WriteLiteral(@"           <th>Mô tả</th>
                                                <th colspan=""2"" class=""text-center"">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 66 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                              
                                                int index = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                             foreach (var item in Publishers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 72 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 73 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 74 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"width: 100px\"><button class=\"btn btn-sm btn-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#editPublisher");
#nullable restore
#line 75 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                                                                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Cập nhật</button></td>\r\n                                                    <td style=\"width: 100px\"><button class=\"btn btn-danger btn-sm\"  type=\"button\" data-toggle=\"modal\" data-target=\"#deleteModal");
#nullable restore
#line 76 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                                                                                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 78 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"

                                                index ++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                     </div>\r\n\r\n");
            WriteLiteral(@"     <div class=""modal fade"" id=""addPublisher"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm mới nhà xuất bản</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2566db58871f1610caa7791bd3cbc760df80169516200", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Nhà xuất bản:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""name"">
                </div>
                <div class=""form-group"">
                    <label for=""message-text"" class=""col-form-label"">Ghi chú:</label>
                    <textarea class=""form-control"" id=""message-text"" name=""description""></textarea>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Đồng ý</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n     </div>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 120 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
        foreach (var item in Publishers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 5900, "\"", 5928, 2);
            WriteAttributeValue("", 5905, "editPublisher", 5905, 13, true);
#nullable restore
#line 122 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
WriteAttributeValue("", 5918, item.Id, 5918, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Chỉnh sửa nhà xuất bản</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2566db58871f1610caa7791bd3cbc760df80169519838", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Nhà xuất bản:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""name""");
                BeginWriteAttribute("value", " value=\"", 6710, "\"", 6730, 1);
#nullable restore
#line 136 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
WriteAttributeValue("", 6718, item.Name, 6718, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"message-text\" class=\"col-form-label\">Ghi chú:</label>\r\n                    <textarea class=\"form-control\" id=\"message-text\" name=\"description\">");
#nullable restore
#line 140 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
                                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Đồng ý</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6400, "/admin/book/publisher/update/", 6400, 29, true);
#nullable restore
#line 131 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
AddHtmlAttributeValue("", 6429, item.Id, 6429, 10, false);

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
            WriteLiteral("\r\n     </div>\r\n     </div>\r\n     </div>\r\n");
#nullable restore
#line 151 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 156 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
        foreach (var item in Publishers){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 7465, "\"", 7491, 2);
            WriteAttributeValue("", 7470, "deleteModal", 7470, 11, true);
#nullable restore
#line 158 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
WriteAttributeValue("", 7481, item.Id, 7481, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Xóa nhà xuất bản</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn có muốn xóa nhà xuất bản ?
            </div>
            <div class=""modal-footer"">
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2566db58871f1610caa7791bd3cbc760df80169524963", async() => {
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Hủy</button>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Đồng ý</button>\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8191, "/admin/book/publisher/delete/", 8191, 29, true);
#nullable restore
#line 171 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
AddHtmlAttributeValue("", 8220, item.Id, 8220, 10, false);

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
#line 179 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Book\Publisher.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   <script>\r\n\r\n       \r\n   </script>\r\n");
            }
            );
            WriteLiteral("   ");
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
