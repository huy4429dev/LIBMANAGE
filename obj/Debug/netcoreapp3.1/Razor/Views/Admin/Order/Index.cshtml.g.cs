#pragma checksum "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2119be64a93397e91572684a8ce1034f3f9fd3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order_Index), @"mvc.1.0.view", @"/Views/Admin/Order/Index.cshtml")]
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
#line 1 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\_ViewImports.cshtml"
using LibManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\_ViewImports.cshtml"
using LibManage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\_ViewImports.cshtml"
using LibManage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\_ViewImports.cshtml"
using LibManage.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2119be64a93397e91572684a8ce1034f3f9fd3e", @"/Views/Admin/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/contact/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "PHIẾU MƯỢN";
    ViewBag.PageName = "PHIẾU MƯỢN";
    ViewBag.Link = "/admin/order";
    var user = ViewData["User"] as User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <main>\r\n                    <div class=\"card mb-4\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2119be64a93397e91572684a8ce1034f3f9fd3e5267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
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
#line 14 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 17 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 19 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                             if(@TempData["error"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    ");
#nullable restore
#line 23 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                               Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 25 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2119be64a93397e91572684a8ce1034f3f9fd3e8633", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm phiếu mượn"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
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
                                  <div>
                                      <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#addCustomer"" ><i class=""fas fa-plus""></i></button>
                                      <button type=""button"" class=""btn btn-success btn-sm"" data-toggle=""modal"" data-target=""#addCustomer"" ><i class=""fas fa-file-download""></i></button>
                                  </div>
                            </div>
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>



    <tr>
      <th class=""th-sm"" >#
      </th>
      <th class=""th-sm"">Họ tên
      </th>
      <th class=""th-sm"">Email
      </th>
      <th class=""th");
            WriteLiteral("-sm \">Điện thoại\r\n      </th>\r\n      <th class=\"th-sm text-center\">Ngày tạo\r\n      </th>\r\n      <th class=\"th-sm text-center\">Trạng thái</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 2931, "\"", 2961, 3);
            WriteAttributeValue("", 2941, "viewDetail(", 2941, 11, true);
#nullable restore
#line 65 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
WriteAttributeValue("", 2952, item.Id, 2952, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2960, ")", 2960, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">\r\n      <td >");
#nullable restore
#line 66 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 67 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
     Write(item.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 68 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
     Write(item.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 69 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
     Write(item.User.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td class=\"text-center\">");
#nullable restore
#line 70 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                         Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td class=\"text-center\">");
#nullable restore
#line 71 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
                          Write(item.Status == OrderStatus.Success ? Html.Raw("<span class='label label-success'> Đã xử lý </span>") : Html.Raw("<span class='label label-warning'> Không xử lý   </span>")  );

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 80 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n                           </div>\r\n                            </div>\r\n                     </div>\r\n </main>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4269, "\"", 4300, 2);
            WriteAttributeValue("", 4274, "basicExampleModal-", 4274, 18, true);
#nullable restore
#line 91 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
WriteAttributeValue("", 4292, item.Id, 4292, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
          aria-hidden=""true"">
          <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
              <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">
                 <p>Subject</p>
                 <p>
");
            WriteLiteral("                 </p>\r\n                 <p>\r\n");
            WriteLiteral(@"                 </p>
                </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                  <span aria-hidden=""true"">&times;</span>
                </button>
              </div>
              <div class=""modal-body"">
");
            WriteLiteral("              </div>\r\n              <div class=\"modal-footer\">\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 117 "C:\Users\HUY 4\Desktop\C#\LibManage\Views\Admin\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  \r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css"">
    <style>
      .show-message{
        cursor: pointer;
      }
      .show-message:hover{
         color:blue;
      }

          .alert.alert-danger.validation-summary-valid {
        display: none;
    }

    tr:hover{
      background-color: #3332;
      transition: 0.4s;
    }
    </style>
");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#dtBasicExample').DataTable( 
               {  
                 ""order"": [[ 0, ""desc"" ]]
               },
            );
            $('.dataTables_length').addClass('bs-select');
        });
    </script>
    <script>
     // change status contact while click show content 
     function viewDetail(id){
       window.location.href = ""/admin/order/"" + id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
