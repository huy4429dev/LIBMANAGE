#pragma checksum "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f06eb810022df6c1b972f09c4c69ddffd720228a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Book_Index), @"mvc.1.0.view", @"/Views/Admin/Book/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06eb810022df6c1b972f09c4c69ddffd720228a", @"/Views/Admin/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/book/Books/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/book"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "SÁCH";
    ViewBag.PageName = "SÁCH";
    ViewBag.Link = "/admin/book";
    var user = ViewData["User"] as User;
    
List<Book> Books = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"card mb-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a5990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
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
#line 15 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 18 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 20 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a8481", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm sách"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
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
                                    Danh sách sách
                                </span>
                                 <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#addCategory"" >Thêm mới</button>
                            </div>
                         
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Tiêu đề</th>
                                                <th");
            WriteLiteral(@">Mô tả</th>
                                                <th></th>
                                                <th>PDF</th>
                                                <th>Tác giả</th>
                                                <th>Loại sách</th>
                                                <th>Nhà xuất bản</th>
                                                <th>Năm xuất bản</th>
                                                <th colspan=""2"" class=""text-center"">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 58 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                              
                                                int index = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                             foreach (var item in Books)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 64 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 65 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 66 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        <img style=\"width:50px\"");
            BeginWriteAttribute("src", " src=\"", 3735, "\"", 3752, 1);
#nullable restore
#line 68 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
WriteAttributeValue("", 3741, item.Image, 3741, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3753, "\"", 3759, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                         \r\n                                                    </td>\r\n                                                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 3940, "\"", 3961, 1);
#nullable restore
#line 71 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
WriteAttributeValue(" ", 3947, item.PDFfile, 3948, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"far fa-file-powerpoint\"></i> ");
#nullable restore
#line 71 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                                                                                      Write(item.PDFfile.Substring(item.PDFfile.LastIndexOf("\\") + 1).Length < 10 ? @item.PDFfile.Substring(item.PDFfile.LastIndexOf("\\") + 1) :  @item.PDFfile.Substring(item.PDFfile.LastIndexOf("\\") + 1).Substring(0,10) + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                    <td>");
#nullable restore
#line 72 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(item.Authors.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 73 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(item.BookTypes);

#line default
#line hidden
#nullable disable
            WriteLiteral("`.Name</td>\r\n                                                    <td>");
#nullable restore
#line 74 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(item.Publishers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 75 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                   Write(item.YearPublished);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"width: 100px\"><button class=\"btn btn-sm btn-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#editCategory");
#nullable restore
#line 76 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                                                                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sửa</button></td>\r\n                                                    <td style=\"width: 100px\"><button class=\"btn btn-danger btn-sm\"  type=\"button\" data-toggle=\"modal\" data-target=\"#deleteModal");
#nullable restore
#line 77 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                                                                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 79 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"

                                                index ++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                     </div>\r\n\r\n");
            WriteLiteral(@"     <div class=""modal fade"" id=""addCategory"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm sách</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a19081", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tiêu đề:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""title"">
                </div>
        
                <div class=""form-group"">
                    <label for=""message-text"" class=""col-form-label"">Mô tả:</label>
                    <textarea class=""form-control"" id=""message-text"" name=""description""></textarea>
                </div>

                <div class=""form-group"">
                    <select class=""form-control"" name=""BookTpye"">
                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a20061", async() => {
                    WriteLiteral("Loại sách");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 114 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                         foreach (var item in ViewData["BookTypes"] as IList<BookType>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a21398", async() => {
#nullable restore
#line 116 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 117 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <select class=\"form-control\" name=\"author\">\r\n                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a23635", async() => {
                    WriteLiteral("Tác giả");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 124 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                           foreach (var item in ViewData["Authors"] as IList<Author>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a24968", async() => {
#nullable restore
#line 126 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <select class=\"form-control\" name=\"publisher\">\r\n                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a27208", async() => {
                    WriteLiteral("Nhà xuất bản");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                           foreach (var item in ViewData["Publishers"] as IList<Publisher>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06eb810022df6c1b972f09c4c69ddffd720228a28552", async() => {
#nullable restore
#line 136 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 137 "C:\Users\HUY 4\Desktop\LIB2\Views\Admin\Book\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>


                <div class=""form-group d-flex""> 
                     <div class=""input-file-container"">  
                        <input class=""input-file"" id=""my-file"" type=""file"" data-target=""#thumbnail-result"" data-target-input=""image""  accept=""image/*"">
                        <label tabindex=""0"" for=""my-file"" class=""input-file-trigger""><span> Hình ảnh </span> <i style=""float: right; font-size: 10px; line-height: 20px"" class=""fas fa-arrow-up""></i></label>
                    </div>
                    <a style=""margin-left:20px"" id=""thumbnail-result""");
                BeginWriteAttribute("href", "  href=\"", 8326, "\"", 8334, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </a>

                    <input type=""hidden"" name=""image"">
                </div>

                <div class=""form-group d-flex"">
                     <div class=""input-file-container"" >  
                        <input class=""input-file"" id=""my-file"" type=""file"" data-target=""#pdf-result"" data-target-input=""pdFfile""  accept="".pdf"">
                        <label tabindex=""0"" for=""my-file"" class=""input-file-trigger""><span> Pdf </span> <i style=""float: right; font-size: 10px; line-height: 20px"" class=""fas fa-arrow-up""></i></label>
                    </div>
                    <a style=""margin-left:20px""  id=""pdf-result""");
                BeginWriteAttribute("href", "  href=\"", 8997, "\"", 9005, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </a>
                    <input type=""hidden"" name=""pdFfile"">
                </div>
                 
                <div class=""form-group"">
                        <p>Năm xuất bản: <input type=""text"" id=""datepicker1"" name=""YearPublished""></p>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Thêm mới</button>
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"

<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
<link rel=""stylesheet"" href=""/resources/demos/style.css"">
    <style>

.alert.alert-danger.validation-summary-valid {
  display: none;
}
.input-file-container {
  position: relative;
  width: 150px;
} 
.js .input-file-trigger {
  display: block;
  padding: 6px 12px;
  background: #39D2B4;
  color: #fff;
  font-size: 1em;
  transition: all .4s;
  cursor: pointer;
}
.js .input-file {
  position: absolute;
  top: 0; left: 0;
  width: 150px;
  opacity: 0;
  padding: 14px 0;
  cursor: pointer;
}
.js .input-file:hover + .input-file-trigger,
.js .input-file:focus + .input-file-trigger,
.js .input-file-trigger:hover,
.js .input-file-trigger:focus {
  background: #34495E;
  color: #39D2B4;
}

.file-return {
  margin: 0;
}
.file-return:not(:empty) {
  margin: 1em 0;
}
.js .file-return {
  font-style: italic;
  font-size: .9em;
  font-weight: bold;
}
.js .file-return:not(:empty):before ");
                WriteLiteral("{\r\n  content: \"Selected file: \";\r\n  font-style: normal;\r\n  font-weight: normal;\r\n}\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js""></script>
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css"" rel=""stylesheet""/>
    <script>
        $(""#datepicker1"").datepicker( {
            format: "" yyyy"", // Notice the Extra space at the beginning
            viewMode: ""years"", 
            minViewMode: ""years""
        });
    </script>
   <script>
        document.querySelector(""html"").classList.add('js');

        var fileInput  = document.querySelectorAll( "".input-file"" ),  
            button     = document.querySelectorAll( "".input-file-trigger"" ),
            the_return = document.querySelectorAll("".file-return"");
            
        button.forEach( item  => {
            item.addEventListener( ""keydown"", function( event ) {  
            if ( event.keyCode == 13 || event.keyCode == 32 ) {  
                fileInput.focus();  
            }  
        });
    ");
                WriteLiteral(@"    });

        button.forEach( item  =>
             {item.addEventListener( ""click"", function( event ) {
             fileInput.focus();
             return false;
        });
        });  

        fileInput.forEach ( item => {
            addEventListener( ""change"", function( event ) {  
            the_return.innerHTML = this.value;  
        });
        });  

   </script>

   <script>

       //=========== Upload File 

        var root = window.location.protocol + window.location.host;

        var fileInputs  = document.querySelectorAll( "".input-file"" );

        
        const url = ""/admin/upload"";

        
        fileInputs.forEach(item => {
            item.addEventListener('change', function() {

                    const idShowResult = item.getAttribute('data-target');
                    const nameInput = item.getAttribute('data-target-input');
                    const showResult  = document.querySelector(idShowResult);
                    const inputValu");
                WriteLiteral(@"e = document.querySelector(`[name=${nameInput}]`);

                    var formData = new FormData();

                    formData.append(""file"", item.files[0]);
                    fetch(url, {
                                method: 'POST',
                                body: formData
                            })
                            .then(response => response.json())
                            .then(data => {
                                 
                                 showResult.setAttribute('href',data.path);
                                 showResult.textContent = data.path.substring(data.pathFull.lastIndexOf(""\\"") + 1);
                                 inputValue.value = data.path;
                                 console.log(data.path);
                                 console.log(inputValue.value);
                            })
                            .catch(err => {
                                console.log(err);
                    })
            });");
                WriteLiteral("\r\n        });\r\n        \r\n     \r\n        \r\n        /* var avatar = document.querySelector(\'#profile-avatar\');\r\n        \r\n       \r\n        */\r\n\r\n   </script>\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
