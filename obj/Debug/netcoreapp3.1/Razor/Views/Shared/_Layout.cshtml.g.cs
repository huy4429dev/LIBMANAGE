#pragma checksum "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd3c812446462b29744c2c9051a7a46cf0f54dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
using LibManage.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd3c812446462b29744c2c9051a7a46cf0f54dc", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search_mini_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("minisearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/product/view/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
  
	var cart = httpContextAccessor.HttpContext.Session.GetString("cart");
			List<Cart> dataCart = new List<Cart>();
	        if (cart != null)
            {
				dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
			}
    var customer = httpContextAccessor.HttpContext.Session.Get<User>("customer");



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html class=\"no-js\" lang=\"vi\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd3c812446462b29744c2c9051a7a46cf0f54dc6297", async() => {
                WriteLiteral("\r\n <meta charset=\"utf-8\">\r\n <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n <title>Home | Books Library eCommerce Store</title>\r\n <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 687, "\"", 697, 0);
                EndWriteAttribute();
                WriteLiteral(@">
 <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

 <link rel=""apple-touch-icon"" href=""/assets/page/images/icon.png"">

 <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800"" rel=""stylesheet"">
 <link href=""https://fonts.googleapis.com/css?family=Poppins:300,300i,400,400i,500,600,600i,700,700i,800""
  rel=""stylesheet"">
 <link href=""https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700,900"" rel=""stylesheet"">

 <link rel=""stylesheet"" href=""/assets/page/css/bootstrap.min.css"">
 <link rel=""stylesheet"" href=""/assets/page/css/plugins.css"">
 <link rel=""stylesheet"" href=""/assets/page/style.css"">

 <link rel=""stylesheet"" href=""/assets/page/css/custom.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.css"" integrity=""sha512-3pIirOrwegjM6erE5gPSwkUzO+3cTjpnV9lexlNZqvupR64iZBnOOTiiLPb9M36zpMScbmUNIcHUqKD47M719g=="" crossorigin=""anonymous"" />

 <script src=""/assets/page/js/vendor/modernizr-3.5.0.min.");
                WriteLiteral(@"js""></script>
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
   -webkit-animation: spin 2s linear infinite;
   /* Safari */
   animation: spin 2s linear infinite;
  }
  .box-profile a{
	  color:white;
  }
 </style>
");
#nullable restore
#line 65 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
  if (IsSectionDefined("Css"))
	{
	 

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
Write(RenderSection("Css", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                                         
	}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd3c812446462b29744c2c9051a7a46cf0f54dc9720", async() => {
                WriteLiteral(@"

 <div class=""wrapper"" id=""wrapper"">
  <!-- Header -->
  <header id=""wn__header"" class=""oth-page header__area header__absolute sticky__header"">
   <div class=""container-fluid"">
	<div class=""row"">
	 <div class=""col-md-6 col-sm-6 col-6 col-lg-2"">
	  <div class=""logo"">
	   <a href=""/"">
		<img src=""/assets/page/images/logo/logo.png"" alt=""logo images"">
	   </a>
	  </div>
	 </div>
	 <div class=""col-lg-8 d-none d-lg-block"">
	  <nav class=""mainmenu__nav"">
	   <ul class=""meninmenu d-flex justify-content-start"">
		<li><a style=""color:white"" href=""/"">Trang chủ</a></li>
		<li><a style=""color:white"" href=""/new"">Tin tức</a></li>
		<li><a style=""color:white"" href=""/about"">Giới thiệu</a></li>
		<li><a style=""color:white"" href=""/contact"">Liên hệ</a></li>
	   </ul>
	  </nav>
	 </div>
	 <div class=""col-md-6 col-sm-6 col-6 col-lg-2"">
	  <ul class=""header__sidebar__right d-flex justify-content-end align-items-center"">
	   <li class=""shop_search""><a class=""search__active"" href=""#""></a></li>
	   <li clas");
                WriteLiteral("s=\"shopcart\"><a class=\"cartbox_active\" href=\"#\"><span\r\n\t\t  class=\"product_qun\">");
#nullable restore
#line 102 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                          Write(dataCart.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></a>
		<!-- Start Shopping Cart -->
		<div class=""block-minicart minicart__active"">
		 <div class=""minicart-content-wrapper"">
		  <div class=""micart__close"">
		   <span>Đóng</span>
		  </div>
		  <div class=""items-total d-flex justify-content-between"">
		   <span id=""total-product"">");
#nullable restore
#line 110 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                                Write(dataCart.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" sản phẩm</span>
		   <span>Giỏ hàng</span>
		  </div>
		  <div class=""total_amount text-right"">
		   <span>Miễn phí</span>
		  </div>
		  <div class=""mini_action checkout"">
		   <a class=""checkout__btn"" href=""cart.html"">Xác nhận mượn</a>
		  </div>
		  <div class=""single__items"">
		   <div class=""miniproduct"">
");
#nullable restore
#line 121 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                foreach (var item in dataCart)
			   {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<div class=\"item01 d-flex\">\r\n\t\t\t\t<div class=\"thumb\">\r\n\t\t\t\t<a href=\"product-details.html\"><img");
                BeginWriteAttribute("src", "\r\n\t\t\t\t\tsrc=\"", 4159, "\"", 4190, 1);
#nullable restore
#line 126 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4171, item.Product.Image, 4171, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n\t\t\t\t\talt=\"product images\"></a>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"content\">\r\n\t\t\t\t<h6><a href=\"product-details.html\">");
#nullable restore
#line 130 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                                              Write(item.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h6>\r\n\t\t\t\t<span class=\"prize\">");
#nullable restore
#line 131 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                               Write(item.Product?.Authors?.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t<div class=\"product_prize d-flex justify-content-between\">\r\n\t\t\t\t<span class=\"qun\">Qty: ");
#nullable restore
#line 133 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t<ul class=\"d-flex justify-content-end\">\r\n\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 4564, "\"", 4600, 2);
                WriteAttributeValue("", 4571, "/cart/remove/", 4571, 13, true);
#nullable restore
#line 135 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4584, item.Product.Id, 4584, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"zmdi zmdi-delete\"></i></a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 141 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
			   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"		   </div>
		  </div>
		  <div class=""mini_action cart"">
		   <a class=""cart__btn"" href=""/cart"">Chỉnh sửa giỏ hàng</a>
		  </div>
		 </div>
		</div>
		<!-- End Shopping Cart -->
	   </li>
	   <li class=""setting__bar__icon"">
		   <a href=""/account""></a>
");
#nullable restore
#line 153 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
            if(customer != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<div class=\"box-profile\">\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t<a href=\"/customer/profile\">Hồ sơ</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t<a href=\"/customer/logout\">Đăng xuất</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 162 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
		   }

#line default
#line hidden
#nullable disable
                WriteLiteral("\t   </li>\r\n\t  </ul>\r\n\t </div>\r\n\t</div>\r\n   </div>\r\n  </header>\r\n  <!-- //Header -->\r\n  <!-- Start Search Popup -->\r\n  <div class=\"brown--color box-search-content search_active block-bg close__top\">\r\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd3c812446462b29744c2c9051a7a46cf0f54dc15991", async() => {
                    WriteLiteral("\r\n\t<div class=\"field__search\">\r\n\t <input type=\"text\" name=\"search\" placeholder=\"Tìm kiếm sách ...\">\r\n\t <div class=\"action\">\r\n\t  <button type=\"submit\"><i class=\"zmdi zmdi-search\"></i></button>\r\n\t </div>\r\n\t</div>\r\n   ");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   <div class=\"close__wrap\">\r\n\t<span>Đóng</span>\r\n   </div>\r\n  </div>\r\n  <!-- End Search Popup -->\r\n\r\n  ");
#nullable restore
#line 186 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

  <!-- Footer Area -->
  <footer id=""wn__footer"" class=""footer__area bg__cat--8 brown--color"">
   <div class=""footer-static-top"">
	<div class=""container"">
	 <div class=""row"">
	  <div class=""col-lg-12"">
	   <div class=""footer__widget footer__menu"">
		<div class=""ft__logo"">
		 <a href=""index.html"">
		  <img src=""/assets/page/images/logo/3.png"" alt=""logo"">
		 </a>
		 <p>""The number of books will grow continually, and one can predict that a time will
		  come when it will be almost as difficult to learn anything from books as from
		  the direct study of the whole universe. It will be almost as convenient to
		  search for some bit of truth concealed in nature as it will be to find it hidden
		  away in an immense multitude of bound volumes."" — Denis Diderot</p>

		</div>
		<div class=""footer__content"">
		 <ul class=""social__net social__net--2 d-flex justify-content-center"">
		  <li><a href=""#""><i class=""bi bi-facebook""></i></a></li>
		  <li><a href=""#""><i class=""bi bi-google""></i></a></l");
                WriteLiteral(@"i>
		  <li><a href=""#""><i class=""bi bi-twitter""></i></a></li>
		  <li><a href=""#""><i class=""bi bi-linkedin""></i></a></li>
		  <li><a href=""#""><i class=""bi bi-youtube""></i></a></li>
		 </ul>
		</div>
	   </div>
	  </div>
	 </div>
	</div>
   </div>
   <div class=""copyright__wrapper"">
	<div class=""container"">
	 <div class=""row"">
	  <div class=""col-lg-6 col-md-6 col-sm-12"">
	   <div class=""copyright"">
		<div class=""copy__right__inner text-left"">
		 <p>Copyright <i class=""fa fa-copyright""></i> <a href=""#"">Boighor.</a> All Rights
		  Reserved</p>
		</div>
	   </div>
	  </div>
	 </div>
	</div>
   </div>
  </footer>
  <!-- //Footer Area -->
  <!-- QUICKVIEW PRODUCT -->
  <div id=""quickview-wrapper"">
   <!-- Modal -->
   <div class=""modal fade"" id=""productmodal"" tabindex=""-1"" role=""dialog"">
	<div class=""modal-dialog modal__container"" role=""document"">
	 <div class=""modal-content"">
	  <div class=""modal-header modal__header"">
	   <button type=""button"" class=""close"" data-dismiss=""modal"" a");
                WriteLiteral(@"ria-label=""Close""><span
		 aria-hidden=""true"">&times;</span></button>
	  </div>
	  <div class=""modal-body"">
	   <div class=""modal-product"">
		<!-- Start product images -->
		<div class=""product-images"">
		 <div class=""main-image images"">
		  <img alt=""big images"" src=""/assets/page/images/product/big-img/1.jpg"">
		 </div>
		</div>
		<!-- end product images -->
		<div class=""product-info"">
		 <h1>Simple Fabric Bags</h1>
		 <div class=""rating__and__review"">
		  <ul class=""rating"">
		   <li><span class=""ti-star""></span></li>
		   <li><span class=""ti-star""></span></li>
		   <li><span class=""ti-star""></span></li>
		   <li><span class=""ti-star""></span></li>
		   <li><span class=""ti-star""></span></li>
		  </ul>
		  <div class=""review"">
		   <a href=""#"">4 customer reviews</a>
		  </div>
		 </div>
		 <div class=""price-box-3"">
		  <div class=""s-price-box"">
		   <span class=""new-price"">$17.20</span>
		   <span class=""old-price"">$45.00</span>
		  </div>
		 </div>
		 <div class=""quick-desc"">");
                WriteLiteral(@"
		  Designed for simplicity and made from high quality materials. Its sleek geometry
		  and material combinations creates a modern look.
		 </div>
		 <div class=""select__color"">
		  <h2>Select color</h2>
		  <ul class=""color__list"">
		   <li class=""red""><a title=""Red"" href=""#"">Red</a></li>
		   <li class=""gold""><a title=""Gold"" href=""#"">Gold</a></li>
		   <li class=""orange""><a title=""Orange"" href=""#"">Orange</a></li>
		   <li class=""orange""><a title=""Orange"" href=""#"">Orange</a></li>
		  </ul>
		 </div>
		 <div class=""select__size"">
		  <h2>Select size</h2>
		  <ul class=""color__list"">
		   <li class=""l__size""><a title=""L"" href=""#"">L</a></li>
		   <li class=""m__size""><a title=""M"" href=""#"">M</a></li>
		   <li class=""s__size""><a title=""S"" href=""#"">S</a></li>
		   <li class=""xl__size""><a title=""XL"" href=""#"">XL</a></li>
		   <li class=""xxl__size""><a title=""XXL"" href=""#"">XXL</a></li>
		  </ul>
		 </div>
		 <div class=""social-sharing"">
		  <div class=""widget widget_socialsharing_widget"">
		 ");
                WriteLiteral(@"  <h3 class=""widget-title-modal"">Share this product</h3>
		   <ul class=""social__net social__net--2 d-flex justify-content-start"">
			<li class=""facebook""><a href=""#"" class=""rss social-icon""><i
			   class=""zmdi zmdi-rss""></i></a></li>
			<li class=""linkedin""><a href=""#"" class=""linkedin social-icon""><i
			   class=""zmdi zmdi-linkedin""></i></a></li>
			<li class=""pinterest""><a href=""#"" class=""pinterest social-icon""><i
			   class=""zmdi zmdi-pinterest""></i></a></li>
			<li class=""tumblr""><a href=""#"" class=""tumblr social-icon""><i
			   class=""zmdi zmdi-tumblr""></i></a></li>
		   </ul>
		  </div>
		 </div>
		 <div class=""addtocart-btn"">
		  <a href=""#"">Add to cart</a>
		 </div>
		</div>
	   </div>
	  </div>
	 </div>
	</div>
   </div>
  </div>
  <!-- END QUICKVIEW PRODUCT -->
 </div>
 <!-- //Main wrapper -->

 <!-- JS Files -->
 <script src=""/assets/page/js/vendor/jquery-3.2.1.min.js""></script>
 <script src=""/assets/page/js/popper.min.js""></script>
 <script src=""/assets/page/js/bootst");
                WriteLiteral(@"rap.min.js""></script>
 <script src=""/assets/page/js/plugins.js""></script>
 <script src=""/assets/page/js/active.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"" integrity=""sha512-VEd+nq25CkR676O+pLBnDW09R7VQX9Mdiij052gVCp5yVH3jGtH70Ho/UUv4mJDsEdTvqRCFZg0NKGiojGnUCw=="" crossorigin=""anonymous""></script>
<script>
		const URL = window.location.origin;

		const eleCartList = document.querySelector('.miniproduct'); 
		const totalProduct = document.querySelector('#total-product');
		const product_qun = document.querySelector('.product_qun');
		console.log(totalProduct);
		let itemsHTML = '';
		function productCartSmall(id,title,image,quantity){

		 							return     `
														<div class=""item01 d-flex"">
																<div class=""thumb"">
																<a href=""/product/${id}""><img
																	src=""${image}""
																	alt=""product images""></a>
																</div>
																<div class=""content"">
																<h6><a h");
                WriteLiteral(@"ref=""product-details.html"">${title}</a></h6>
																<span class=""prize"">OK</span>
																	<div class=""product_prize d-flex justify-content-between"">
																	<span class=""qun"">Qty: ${quantity}</span>
																	<ul class=""d-flex justify-content-end"">
																		<li><a href=""/cart/remove/${id}""><i class=""zmdi zmdi-delete""></i></a>
																		</li>
																	</ul>
																	</div>
														    	</div>
														</div>
												`
												
		}

		function addCartItem (id,quantity = 1) {
			fetch(`${URL}/cart/add/${id}?quantity=${quantity}`)
			.then(response => response.json())
			.then(data => {

				toastr.success('Thêm vào giỏ thành công');
				data.dataCart.forEach(item => {
					itemsHTML += productCartSmall(item.product.id, item.product.title, item.product.image,item.quantity);
					console.log(itemsHTML);
				});
				eleCartList.innerHTML = itemsHTML;
				totalProduct.innerHTML = data.dataCart.length + ' s");
                WriteLiteral(@"ản phẩm';
				product_qun.innerHTML = data.dataCart.length;
				itemsHTML = '';

			})
			.catch(err => console.log(""ERR: "" + err.message));
		}

		/*function removeCartItem (id) {
			fetch(`${URL}/cart/remove/${id}`)
			.then(response => response.json())
			.then(data => {

				toastr.success('Cập nhật giỏ hàng thành công');
				data.dataCart.forEach(item => {
					itemsHTML += product(item.product.id, item.product.title, item.product.image,item.product.quantity);
				});
				eleCartList.innerHTML = itemsHTML;
				itemsHTML = '';
			})
			.catch(err => console.log(""ERR: "" + err.message));
		}*/

</script>

");
#nullable restore
#line 403 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
  if (IsSectionDefined("Script"))
	{
	 

#line default
#line hidden
#nullable disable
#nullable restore
#line 405 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
Write(RenderSection("Script", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 405 "C:\Users\HUY 4\Desktop\LIB2\Views\Shared\_Layout.cshtml"
                                            
	}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n\r\n</html>");
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
