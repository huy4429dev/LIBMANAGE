#pragma checksum "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d88b8c47f34f6eb3c554a68a40512a750a8523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5d88b8c47f34f6eb3c554a68a40512a750a8523", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/lien-he"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
		<!-- Start Bradcaump area -->
		<div class=""ht__bradcaump__area bg-image--6"">
			<div class=""container"">
				<div class=""row"">
					<div class=""col-lg-12"">
						<div class=""bradcaump__inner text-center"">
							<h2 class=""bradcaump-title"">Liên hệ</h2>
							<nav class=""bradcaump-content"">
								<a class=""breadcrumb_item"" href=""index.html"">Trang chủ</a>
								<span class=""brd-separetor"">/</span>
								<span class=""breadcrumb_item active"">Liên hệ</span>
							</nav>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- End Bradcaump area -->
		<!-- Start Contact Area -->
		<section class=""wn_contact_area bg--white pt--80 pb--80"">
			<div class=""google__map pb--80"">
				<div class=""container"">
					<div class=""row"">
						<div class=""col-md-12"">
							<div id=""googleMap"">
								<iframe class=""w-100"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7864042.220233749!2d101.41295700192096!3d15.758312883650813!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!");
            WriteLiteral("1s0x31157a4d736a1e5f%3A0xb03bb0c9e2fe62be!2zVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1608043600584!5m2!1svi!2s\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1218, "\"", 1236, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>
							</div>
						</div>
					</div>
				</div>
			</div>
			<div class=""container"">
				<div class=""row"">
					<div class=""col-lg-8 col-12"">
						<div class=""contact-form-wrap"">
							<h2 class=""contact__title"">Liên hệ ngay với chúng tôi</h2>
							<p>Đội ngũ tư vấn của chúng tôi luôn trực 24/24 để giải đáp thắc mắc của bạn </p>
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d88b8c47f34f6eb3c554a68a40512a750a85236602", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 44 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                if (ViewData["SendContactSuccess"] != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"alert alert-success\">\r\n                                        ");
#nullable restore
#line 47 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                   Write(ViewData["SendContactSuccess"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 49 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                   if (ViewData.ModelState.Any(x => x.Value.Errors.Any()))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                                        <a class=\"close\" data-dismiss=\"alert\">×</a>\r\n");
#nullable restore
#line 54 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                         foreach (var modelError in Html.ViewData.ModelState.SelectMany(keyValuePair =>
                                        keyValuePair.Value.Errors))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <p>");
#nullable restore
#line 57 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                          Write(modelError.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 58 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 60 "E:\project\c#\LIB2\LIBMANAGE\Views\Contact\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div id=""alert-contact"" class=""pb-4"">
									
                                    Gửi liên hệ thành công
                                </div>


								<div class=""single-contact-form space-between"">
									<input id=""subject-contact"" type=""text"" name=""Subject"" placeholder=""Chủ đề*"">
								</div>
								<div class=""single-contact-form space-between"">
									<input  id=""fullname-contact"" type=""text"" name=""FullName"" placeholder=""Họ tên*"">
									<input  id=""email-contact"" type=""email"" name=""Email"" placeholder=""Email*"">
								</div>
								<div class=""single-contact-form message"">
									<textarea id=""content-contact"" name=""Content"" placeholder=""Nhập nội dung liên hệ..""></textarea>
								</div>
								<div class=""contact-btn"">
									<button id=""send-contact"" type=""button"">Gửi liên hệ</button>
								</div>
							");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						</div>
						<div class=""form-output"">
							<p class=""form-messege"">
						</div>
					</div>
					<div class=""col-lg-4 col-12 md-mt-40 sm-mt-40"">
						<div class=""wn__address"">
							<h2 class=""contact__title"">BOIGHOR .</h2>
							<p>Hãy liên hệ với BOIGHOR để chúng tôi có thể tư vấn trực tiếp cho bạn về sản phẩm và dịch vụ bạn quan tâm. Chúng tôi luôn sẵn lòng lắng nghe và hỗ trợ bạn. </p>
							<div class=""wn__addres__wreapper"">

								<div class=""single__address"">
									<i class=""icon-location-pin icons""></i>
									<div class=""content"">
										<span>Địa chỉ:</span>
										<p>666 5t DHV - NA - Việt Nam</p>
									</div>
								</div>

								<div class=""single__address"">
									<i class=""icon-phone icons""></i>
									<div class=""content"">
										<span>Điện thoại:</span>
										<p>716-298-1822</p>
									</div>
								</div>

								<div class=""single__address"">
									<i class=""icon-envelope icons""></i>
									<div class=""conten");
            WriteLiteral(@"t"">
										<span>Email:</span>
										<p>716-298-1822</p>
									</div>
								</div>

								<div class=""single__address"">
									<i class=""icon-globe icons""></i>
									<div class=""content"">
										<span>website:</span>
										<p><a href=""#"">http://boighor.com.vn/contact</a></p>
									</div>
								</div>

							</div>
						</div>
					</div>
				</div>
			</div>
		</section>

");
            DefineSection("Css", async() => {
                WriteLiteral(@"
	<style>
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
			-webkit-animation: spin 2s linear infinite; /* Safari */
			animation: spin 2s linear infinite;
		}

    </style>
	
");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
	<script>
            
            let btnSendContact = document.querySelector('#send-contact');
            let inputEmailSendContact = document.querySelector('#email-contact');
            let inputContentSendContact = document.querySelector('#content-contact');
            let inputFullNameSendContact = document.querySelector('#fullname-contact');
            let inputSubjectSendContact = document.querySelector('#subject-contact');
            let alertSendContact = document.querySelector('#alert-contact');
            let formContact = document.querySelector('#form-contact');

			let loader = `<div class=""fix-center"">
										<img style=""width:50px"" src=""/assets/loading.gif"" alt="""">
									</div>`;

            btnSendContact.addEventListener('click', customerSendContact);



            function customerSendContact() {

            const data = { email: inputEmailSendContact.value , subject: inputSubjectSendContact.value , fullname: inputFullNameSendContact.value, content: input");
                WriteLiteral(@"ContentSendContact.value};


            alertSendContact.style.color = '#343a40 ';
            alertSendContact.innerHTML = loader;

            fetch('/contact', {
            method: 'POST',
				headers: {
				'Content-Type': 'application/json',
				},
				body: JSON.stringify(data),
				})
				.then(response => response.json())
				.then(data => {
				if (data.success != null) {
					alertSendContact.style.color = 'green';
					alertSendContact.textContent = data.success;
					formContact.reset();
				}
				else {
				alertSendContact.style.color = 'red';
				alertSendContact.textContent = data.error[0].errorMessage;
				}
				})
				.catch((error) => {
				console.error('Error:', error);
				})
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
