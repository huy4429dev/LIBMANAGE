#pragma checksum "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af9ad36558b2c9bf1acf347c09165f002b706fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Employee_Index), @"mvc.1.0.view", @"/Views/Admin/Employee/Index.cshtml")]
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
#nullable restore
#line 1 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af9ad36558b2c9bf1acf347c09165f002b706fc", @"/Views/Admin/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/customer/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "NHÂN VIÊN";
    ViewBag.PageName = "NHÂN VIÊN";
    ViewBag.Link = "/admin/customer";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                               

        List<User> Customers = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n   <style>\r\n    .alert.alert-danger.validation-summary-valid {\r\n        display: none;\r\n    }\r\n   </style>\r\n");
            }
            );
            WriteLiteral("\r\n <main>\r\n                     <div class=\"card mb-4\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af9ad36558b2c9bf1acf347c09165f002b706fc6554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 24 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
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
#line 26 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 29 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 31 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                             if(@TempData["error"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    ");
#nullable restore
#line 35 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                               Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 37 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af9ad36558b2c9bf1acf347c09165f002b706fc9892", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm nhân viên"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
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
                                 <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#addCustomer"" ><i class=""fas fa-plus""></i></button>
                            </div>
                         
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Avatar</th>
                                                <th>Tên nhân viên</th>
                                                <th>Điện thoại</th>
                                                <th>Email</th>
                                ");
            WriteLiteral(@"                <th>Ngày tạo</th>
                                                <th>Trạng thái</th>
                                                <th colspan=""2"" class=""text-center"">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 69 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                              
                                                int index = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                             foreach (var item in Customers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td style=\"width:80px\">");
#nullable restore
#line 75 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                                      Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                    <td style=""width:80px""><img style=""width:60px; border-radius: 50%"" src=""https://banner2.cleanpng.com/20180528/ccc/kisspng-computer-icons-user-avatar-woman-avatar-5b0c5b2f6ecaa1.2446433615275364314538.jpg"" /></td>
                                                    <td>");
#nullable restore
#line 77 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 78 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 79 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 80 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                   Write(item.CreatTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"width:110px\" class=\"text-center\">");
#nullable restore
#line 81 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                                                            Write(item.Status ? @Html.Raw("<i class='far fa-check-circle' style='color: green'></i>") : @Html.Raw("<i class='far fa-times-circle' style='color: red'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\"><button  style=\"font-size:10px\" class=\"btn btn-sm btn-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#editCustomer");
#nullable restore
#line 82 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                                                                                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-edit\"></i></button></td>\r\n                                                    <td class=\"text-center\"><button  style=\"font-size:10px\" class=\"btn btn-danger btn-sm\"  type=\"button\" data-toggle=\"modal\" data-target=\"#deleteModal");
#nullable restore
#line 83 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
                                                                                                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-trash\"></i></button></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 85 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"

                                                index ++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                     </div>\r\n </main>\r\n\r\n\r\n                   \r\n\r\n");
            WriteLiteral(@"     <div class=""modal fade"" id=""addCustomer"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm nhân viên</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af9ad36558b2c9bf1acf347c09165f002b706fc19004", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tài khoản (*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""Username"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Mật khẩu (*):</label>
                    <input type=""password"" class=""form-control"" id=""recipient-name"" name=""Password"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Họ Tên(*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""FullName"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Điện thoại:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-");
                WriteLiteral(@"name"" name=""Phone"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Email:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""Email"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Ngày sinh:</label>
                    <input type=""date"" class=""form-control"" id=""datepicker"" name=""BirthDate"">
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Tạo</button>
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
#line 146 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
        foreach (var item in Customers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 8020, "\"", 8047, 2);
            WriteAttributeValue("", 8025, "editCustomer", 8025, 12, true);
#nullable restore
#line 148 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 8037, item.Id, 8037, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Cập nhật nhân viên</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af9ad36558b2c9bf1acf347c09165f002b706fc23746", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

               <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tài khoản (*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""username""");
                BeginWriteAttribute("value", " value=\"", 8823, "\"", 8845, 1);
#nullable restore
#line 162 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 8831, item.Username, 8831, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled >\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Họ Tên(*):</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"recipient-name\" name=\"FullName\"");
                BeginWriteAttribute("value", " value=\"", 9492, "\"", 9514, 1);
#nullable restore
#line 170 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 9500, item.FullName, 9500, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Điện thoại:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"recipient-name\" name=\"Phone\"");
                BeginWriteAttribute("value", " value=\"", 9768, "\"", 9787, 1);
#nullable restore
#line 174 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 9776, item.Phone, 9776, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Email:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"recipient-name\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 10036, "\"", 10055, 1);
#nullable restore
#line 178 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 10044, item.Email, 10044, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Ngày sinh:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"datepicker\" name=\"BirthDate\"");
                BeginWriteAttribute("value", " value=\"", 10308, "\"", 10331, 1);
#nullable restore
#line 182 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 10316, item.BirthDate, 10316, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
             <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""status"" id=""exampleRadios1"" value=""1"" checked>
            <label class=""form-check-label"" for=""exampleRadios1"">
                Đang hoạt động
            </label>
            </div>
            <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""status"" id=""exampleRadios2"" value=""0"" >
            <label class=""form-check-label"" for=""exampleRadios2"">
                Không hoạt động
            </label>
            </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Cập nhật</button>
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
            AddHtmlAttributeValue("", 8515, "/admin/customer/update/", 8515, 23, true);
#nullable restore
#line 157 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
AddHtmlAttributeValue("", 8538, item.Id, 8538, 10, false);

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
#line 205 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 210 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
        foreach (var item in Customers){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 11368, "\"", 11394, 2);
            WriteAttributeValue("", 11373, "deleteModal", 11373, 11, true);
#nullable restore
#line 212 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
WriteAttributeValue("", 11384, item.Id, 11384, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Xóa nhân viên</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn chắc chắn xóa nhân viên này không ?
            </div>
            <div class=""modal-footer"">
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af9ad36558b2c9bf1acf347c09165f002b706fc31525", async() => {
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Hủy</button>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Xóa</button>\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 12100, "/admin/customer/delete/", 12100, 23, true);
#nullable restore
#line 225 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
AddHtmlAttributeValue("", 12123, item.Id, 12123, 10, false);

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
#line 233 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   <script>\r\n        $( function() {\r\n            $( \"#datepicker\" ).datepicker();\r\n        } );\r\n        \r\n   </script>\r\n");
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
