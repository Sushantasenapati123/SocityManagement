#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b09d7bf073c8ff4fe1390c09211875b625f58113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Custmer_Agentwise_ViewDailyDepositeReport), @"mvc.1.0.view", @"/Views/Custmer/Agentwise_ViewDailyDepositeReport.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\_ViewImports.cshtml"
using MiniBank.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\_ViewImports.cshtml"
using MiniBank.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b09d7bf073c8ff4fe1390c09211875b625f58113", @"/Views/Custmer/Agentwise_ViewDailyDepositeReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_Custmer_Agentwise_ViewDailyDepositeReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.Customer.CustmerEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fromdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("todate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("indsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";
    var ResultData = ViewBag.Result as List<Bank.Domain.Customer.CustmerEntity>;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .icon {
        padding-left: 020px;
        background: url(""https://png.pngtree.com/png-vector/20191011/ourmid/pngtree-printer-icon-png-image_1817556.jpg"") no-repeat left;
        background-size: 30px;
    }

    .dynamicTable {
        font: .7em Arial;
        border: 1px solid gray;
    }

    .dynamicTableTh {
        background-color: #584df0;
        color: White;
    }

    .dynamicTableTd {
        padding: 3px;
        width: 90px;
        color: red
    }
</style>

<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                <li class=""breadcrumb-item"">Society Management</li>
                <li class=""breadcrumb-item active"" aria-current=""page""><b>View Report</b></li>
            </ol>
        </nav>
    </div>
</div>


    <div class=""col-md-12 col-sm-12"">
        <div class=""card");
            WriteLiteral(@""">
         

            <!-- Search Panel -->
            <!--===================================================-->
            <div class=""row"">
                <div class=""col-md-12 col-sm-12"">
                    <div class=""card"">
                        <div class=""card-header"">

                        </div>
                        <!-- Search Panel-->


                        <div class=""search-container"">
                            <div class=""search-sec"" style=""display: block;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b09d7bf073c8ff4fe1390c09211875b625f581137945", async() => {
                WriteLiteral(@"
                                    <div class=""form-group form-row"">
                                        <div class=""col-12 col-md-6 col-xl-3"">
                                            <label class=""control-label"" id=""fromdateL"">Agent Code<span class=""text-danger"">*</span></label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b09d7bf073c8ff4fe1390c09211875b625f581138549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 67 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Agent_Code);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""col-12 col-md-6 col-xl-3"">
                                            <label class=""control-label"" id=""fromdateL"">From Date<span class=""text-danger"">*</span></label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b09d7bf073c8ff4fe1390c09211875b625f5811310802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 71 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.From_Date);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""col-12 col-md-6 col-xl-3"">
                                            <label class=""control-label"" id=""todateL"">To Date<span class=""text-danger"">*</span></label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b09d7bf073c8ff4fe1390c09211875b625f5811313051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 75 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.To_Date);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""col-lg-2 "">
                                            <button id=""btnSearch"" onclick=""valid()"" class=""btn btn-primary mt-xl-4 mt-2""> <i class=""fa fa-search""></i> Search</button>
                                        </div>
                                       
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""text-center""> <a class=""searchopen"" title=""Search"" data-toggle=""tooltip"" data-placement=""bottom""> <i class=""icon-angle-arrow-down""></i> </a></div>
                        </div>
                        <b style=""margin-left:25px;"">Total Collection: <span id=""main""></span></b>
                        <!-- Search Panel -->
                        <!--===================================================-->
                        <div class=""card-body "">
");
#nullable restore
#line 90 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                             if (ResultData != null && ResultData.ToList().Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""table-responsive"">
                                    <table data-toggle=""table"" id=""tblDoctor"" class=""table"">
                                        <thead>
                                            <tr>
                                                <th width=""60px"" class=""align-top text-center"">Sl#</th>

                                                <th width=""150px"" class=""align-top"">
                                                    Name
                                                </th>
                                                <th width=""150px"" class=""align-top"">
                                                    Account Number
                                                </th>
                                                <th width=""150px"" class=""align-top"">
                                                    Collection Amount
                                                </th>

                                      ");
            WriteLiteral(@"          <th width=""150px"" class=""align-top"">
                                                    Collection_date
                                                </th>
                                                <th width=""150px"" class=""align-top"">
                                                    Collected_Status
                                                </th>
                                                <th width=""150px"" class=""align-top"" hidden>
                                                    Collected_Status
                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 120 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                              
                                                int count = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                             foreach (var list in ResultData)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td class=\"text-center\">");
#nullable restore
#line 126 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 129 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                   Write(list.customername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 133 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                   Write(list.NewAccountNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 136 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                   Write(list.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 140 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                   Write(list.Collection_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 143 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                   Write(list.Collected_Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td hidden>\r\n                                                        \r\n                                                        <span");
            BeginWriteAttribute("id", " id=\"", 7505, "\"", 7516, 1);
#nullable restore
#line 147 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
WriteAttributeValue("", 7510, count, 7510, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 147 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                                     Write(list.totalsum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 150 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                                                count++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n");
#nullable restore
#line 155 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"norecord\">No Record Found</div>\r\n");
#nullable restore
#line 159 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\Agentwise_ViewDailyDepositeReport.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""clearfix col-sm-12""></div>
                        </div>

                        <!--===================================================-->
                    </div>
                </div>
            </div>
        </div>



   
    <script>
      
       
        function valid() {
            if ($(""#branch_id"").val() == 0) {
                alert(""Plz Select Branch"");
                return false;
            }
            if ($(""#fromdate"").val() == 0) {
                alert(""Plz Select From Date"");
                return false;
            }
            if ($(""#todate"").val() == 0) {
                alert(""Plz Select To Date"");
                return false;
            }
            true
        }
        $(document).ready(function () {
            getDataTable();
            $(""#main"").text($('#1').text());
        })
        function ViewAccount(id) {

            location.href = ""/Custmer/ViewPendingCustomerDetails?id="" +");
            WriteLiteral(@" id;



        }
        function BindDropDown(CUSTOMER_id, Customer_Code) {

            $(""#BindAccount"").empty();
            $.ajax({
                url: ""/AccountOpening/BindDdlForpendingaccount?id="" + Customer_Code,
                type: ""GET"",
                success: function (result) {
                    data = JSON.parse(result);
                    var v;
                    $.each(data.Result, function (i, item) {
                        v += ""<option value="" + item.Openingdetails_id + "">"" + item.HeadOfAccount + "":("" + ""00"" + item.Accountno + "")"" + ""</option>"";
                    });
                    $(""#BindAccount"").html(v);
                },
                error: function (error) {
                    jsonValue = jQuery.parseJSON(error.responseText);
                    bootbox.alert(""Error : "" + jsonValue);
                }
            });

            $('#BindDropDown').modal(""show"");


        }
        var x;
        var cid;
        function OpenACC");
            WriteLiteral(@"(Id, CustId) {
            $('.modalMsg').text('Are you Want To Open Account ?');
            $('.submitConfirm').css('display', 'block');
            $('#OpenAC').modal(""show"");
            x = Id;
            cid = CustId;

        }
        var type = ""Saving"";
        function DisplayPage() {
            type = $('#TypAc').val()
        }

        function OK() {
            debugger
            if (type == ""Loan"") {
                location.href = ""/AccountOpening/Loaninsertpage?id="" + x + ""&AcType="" + type + ""&CustCode="" + cid;

            }
            else if (type == ""Fixed"") {
                location.href = ""/AccountOpening/Fixdeposit_insertpage?id="" + x + ""&AcType="" + type + ""&CustCode="" + cid;

            }
            else {
                location.href = ""/AccountOpening/insertpage?id="" + x + ""&AcType="" + type + ""&CustCode="" + cid;

            }
        }


        //Pagination
        function getDataTable() {
            $('#tblDoctor').DataTable({
       ");
            WriteLiteral(@"         ""searching"": true,
                //""bStateSave"": true,
                ""dom"": 'Bfrtip',
                ""autoWidth"": false,
                ""buttons"": [
                    //{
                    //    extend: 'print',
                    //    title: 'Manage Block',
                    //    exportOptions: {
                    //        columns: [0, 1, 2, 3, 4]
                    //    },
                    //    customize: function (win) { $(win.document.body).css('font-size', '10pt').prepend('<img src=""' + origin + '/images/t5-logo-white.png""  style=""position:absolute; top:0; left:0;"" />'); $(win.document.body).find('table').addClass('compact').css('font-size', 'inherit'); }

                    //}
                    ,
                    {
                        extend: 'pageLength'
                    }
                ],
                ""lengthMenu"": [
                    [10, 25, 50, 100, 1000 - 1],
                    ['10 rows', '25 rows', '50 rows', '100 rows',");
            WriteLiteral(@" '1000 rows', 'Show all']
                ]
            });
        }
        var code;
        function updateDepartment(Id, custcode) {
            $('.modalMsg').text('Are you sure to View the details ?');
            $('.submitConfirm').css('display', 'block');
            $('#SubmitModal').modal(""show"");
            x = Id;
            code = custcode;
            //location.href = ""/RegistrationUser/User_Registration?id="" + DepartmentId;
            // }
        }

        $("".submitConfirm"").click(function () {
            location.href = ""/Custmer/customerinsert?id="" + x + ""&Code="" + code;
        });


        var dl;
        function deleteDoctor(UserId) {
            $('.DmodalMsg').text('Are you sure to delete ?');
            $('.DsubmitConfirm').css('display', 'block');
            $('#DSubmitModal').modal(""show"");
            dl = UserId;
        }

        $("".DsubmitConfirm"").click(function () {
            $.ajax({
                url: ""/Custmer/Deletecustomer?i");
            WriteLiteral(@"d="" + dl,
                type: ""POST"",
                dataType: ""json"",
                contentType: ""application/json;charset=UTF-8"",
                success: function (data) {
                    if (data == ""3"") {
                        $('.modalMsg').text('');
                        $('#DSubmitModal').modal(""hide"");
                        $('.msgsuccess').text('Data Deleted successfully.');
                        $('#SuccessModal').modal('show');
                        /* window.location.href = ""/RegistrationUser/GetAllUsers"";*/
                    }


                },
                error: function (error) {
                    jsonValue = jQuery.parseJSON(error.responseText);
                    bootbox.alert(""Error : "" + jsonValue);
                }
            });

        });


    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bank.Domain.Customer.CustmerEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
