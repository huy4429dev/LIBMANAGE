#pragma checksum "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74a22491558cef1d777eb0a94ed8966eff7dd24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Report_EmployeeReport), @"mvc.1.0.view", @"/Views/Admin/Report/EmployeeReport.cshtml")]
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
#line 6 "E:\project\c#\LIB2\LIBMANAGE\Views\_ViewImports.cshtml"
using LibManage.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
using LibManage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a22491558cef1d777eb0a94ed8966eff7dd24", @"/Views/Admin/Report/EmployeeReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe79261a8952a09445f81073330574e8f71484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Report_EmployeeReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "NHÂN VIÊN";
    ViewBag.PageName = "BÁO CÁO TƯƠNG TÁC NHÂN VIÊN";
    ViewBag.Link = "/admin/report/order";
    var user = ViewData["User"] as User;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
                                                                            
    var dataChart  = new List<object>();
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<div class=""fix-center loading"" 
										style=""background:white; 
											   position: absolute; 
											   top: 0; left: 0; 
											   width:100%;
											   height:100%;
											   z-index: 4"">

										<img style=""position: absolute; top: 30%; width:50px""  src=""/assets/loading.gif""");
            BeginWriteAttribute("alt", " alt=\"", 706, "\"", 712, 0);
            EndWriteAttribute();
            WriteLiteral(@">
</div>
<div class=""d-flex justify-content-end"">
    <div>
        <div class=""form-group"">
            <input class=""form-control"" type=""text"" name=""daterange"" value=""12/01/2020 - 12/12/2020"" />
        </div>
    </div>
</div>
<div class=""row mt-4"">
    <div class=""col-12"">
        <h5 class=""text-center mb-5"" style=""font-weight:400;font-size:20px; color: #414141"">
            Biểu đồ thống kê lượng tương tác nhân viên <br /> 
        <small id=""time""></small> 
        </h5>
        <div class=""d-flex justify-content-center"">
            <figure class=""highcharts-figure"">
                <div id=""container""></div>
            </figure>
        </div>
    </div>
</div>
<div class=""row mt-4"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Nhân viên</th>
                <th>Xác nhận lượt mượn</th>
                <th>Lượt trả đúng hạn</th>
                <th>Lượt trả trễ hạn</th>
                <th>Tiền nộp phạt</th>
                <th>Số sách ");
            WriteLiteral("mượn</th>\r\n                <th>Số khách hàng</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"report-order-table\">\r\n        </tbody>\r\n        <tfoot id=\"report-order-total\">\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css\" />\r\n    <style>\r\n      .fix-center{\r\n        display: none;\r\n      }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/jquery/latest/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/momentjs/latest/moment.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js""></script>
    <script>
      var fromDate = ");
#nullable restore
#line 80 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
                Write(Html.Raw(Json.Serialize("")));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n      var toDate = ");
#nullable restore
#line 81 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
              Write(Html.Raw(Json.Serialize("")));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
      
      $(function() {
              $('input[name=""daterange""]').daterangepicker({
                  timePicker: true,
                  startDate: moment().add(-1, 'month'),
                  endDate: moment(),
                  locale: {
                  format: 'DD/MM/YYYY'
                  }
              },(start,end,label) => { getDataAjax(start,end,label)});
      });
    </script>
    <script>
            const startOfMonth = moment().clone().startOf('month').format('YYYY-MM-DD hh:mm');
            const endOfMonth   = moment().clone().endOf('month').format('YYYY-MM-DD hh:mm'); 
            const curentDate = moment().add('1','d');
            const lastMonth = moment(curentDate).add(-1,'M').add(-1,'day');
            const tableBodyReportOrder = document.querySelector('#report-order-table');
            const tableFooterReportOrder = document.querySelector('#report-order-total');
            const loading = document.querySelector('.fix-center');

            const time");
                WriteLiteral(" = document.querySelector(\'#time\');\r\n            time.innerHTML = \'(\' +  moment(lastMonth).format(\"DD/MM/YYYY\") + \' - \' + moment(curentDate).format(\'DD/MM/YYYY\') + \')\'; \r\n            var data = ");
#nullable restore
#line 105 "E:\project\c#\LIB2\LIBMANAGE\Views\Admin\Report\EmployeeReport.cshtml"
                  Write(Html.Raw(Json.Serialize(ViewBag.Data)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            console.log(data,'DATA');
            const row = (record) => { 
                return  (
                    `<tr class=""text-center"">
                        <td>${record.userName}</td>
                        <td>${record.total}</td>
                        <td>${record.totalOrdrerSuccess}</td>
                        <td>${record.totalOrdrerOverdue}</td>
                        <td>${record.penatyFee.toLocaleString()} đ</td>
                        <td>${record.totalBook}</td>
                        <td>${record.totalCustomer}</td>
                    </tr>` )
            };

            const rowFooterRender = (record) => { 
                return  (
                    `<tr class=""text-center"">
                        <td>Tổng</td>
                        <td>${record.total}</td>
                        <td>${record.totalOrdrerSuccess}</td>
                        <td>${record.totalOrdrerOverdue}</td>
                        <td>${record.penatyFee.toLocaleString()} ");
                WriteLiteral(@"đ</td>
                        <td>${record.totalBook}</td>
                        <td>${record.totalCustomer}</td>
                    </tr>` )
            };

            const renderDataTable = (data) => { 
                let rows = '';
                let rowFooter = {
                    total: 0,
                    totalOrdrerSuccess: 0,
                    totalOrdrerOverdue: 0,
                    penatyFee: 0,
                    totalBook: 0,
                    totalCustomer: 0
                };

                data.forEach(item => {
                    rows += row(item);
                    rowFooter.total += item.total;
                    rowFooter.totalOrdrerSuccess += item.totalOrdrerSuccess;
                    rowFooter.totalOrdrerOverdue += item.totalOrdrerOverdue;
                    rowFooter.penatyFee += item.penatyFee;
                    rowFooter.totalBook += item.totalBook;
                    rowFooter.totalCustomer +=item.totalCustomer;
               ");
                WriteLiteral(@" })
                
                tableBodyReportOrder.innerHTML = rows;
                tableFooterReportOrder.innerHTML = rowFooterRender(rowFooter);
            }

            const enumerateDaysBetweenDates = function(startDate, endDate) {
                var dates = [];
                var currDate = moment(startDate).startOf('day');
                var lastDate = moment(endDate).startOf('day');
                
                while(currDate.add(1, 'days').diff(lastDate) < 0) {
                    dates.push(currDate.clone().toDate());
                }
                return dates;
            };

            const listDates = enumerateDaysBetweenDates(lastMonth, curentDate).map(item => moment(item).format(""DD/MM/YYYY""));

            renderDataTable(data);

            // call ajax

            const URL = window.location.origin;

            function getDataAjax(start, end , label){

                    loading.style.display = 'flex';
                    let productsHTM");
                WriteLiteral(@"L = '';
                    let timerId = null; 
                    fetch(`${URL}/admin/report/order/ajax?toDate=${moment(start).toISOString()}&fromDate=${moment(end).toISOString()}`)
                    .then(response => response.json())
                    .then(data => {
                        timerId = setInterval(() => {
                                loading.style.display = 'none';
                                let listDates = enumerateDaysBetweenDates(moment(start).add(-1,'d'),moment(end).add(1,)).map(item => moment(item).format(""DD/MM/YYYY""));
                                renderCharts(data.data);
                                renderDataTable(data.data);
                                if(timerId != null){
                                    clearInterval(timerId);
                                }
                        },2000);
                    });
                }


      const renderCharts = ( data) => {
                    
          Highcharts.setOptions({
    ");
                WriteLiteral(@"          colors: ['#01BAF2', '#71BF45', '#FAA74B']
          });  

          

        Highcharts.chart('container', {
                        chart: {
                  plotBackgroundColor: null,
                  plotBorderWidth: null,
                  plotShadow: false,
                  type: 'pie',
                  width: 250
                },
                title: {
                  text: 'Lượt cho mượn sách',
                  y:225,
                 style: {
                    fontSize: '14px' 
                }
                },
              legend:{
                enabled:false
              },
                tooltip: {
                  pointFormat: '<b>{point.percentage:.1f}%</b>'
                },
                plotOptions: {
                  pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                      enabled: true,
                      formatter:function(){
    ");
                WriteLiteral(@"                    return this.key+ ': ' + this.y + 'lượt xác nhận';
                      }
                    },
                    showInLegend: true
                  }
                },
                series: [{
                    name: 'Lần mượn',
                    colorByPoint: true,
                    innerSize: '80%',
                    data: data.map((item) => ({
                            name: item.userName,
                            y: item.total,
                     }))
                 }]
              });

            }

            // render first

            renderCharts(data);

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
