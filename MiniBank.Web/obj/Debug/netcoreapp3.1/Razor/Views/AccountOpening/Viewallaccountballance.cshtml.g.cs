#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b246e6fb005520de25f96f85ed12b086cac5b22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountOpening_Viewallaccountballance), @"mvc.1.0.view", @"/Views/AccountOpening/Viewallaccountballance.cshtml")]
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
#line 1 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\_ViewImports.cshtml"
using MiniBank.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\_ViewImports.cshtml"
using MiniBank.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b246e6fb005520de25f96f85ed12b086cac5b22", @"/Views/AccountOpening/Viewallaccountballance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountOpening_Viewallaccountballance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.AccountOpening.AccountopeningEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Saving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Share_Cap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Current", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Fixed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Recuring", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Loan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    var ResultData = ViewBag.Result as List<Bank.Domain.AccountOpening.AccountopeningEntity>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
 if (ViewBag.Role == "Manager")//Executive Assistant
{
    Layout = "~/Views/Shared/ManagerLayout.cshtml";
}
else if ((ViewBag.Role == "Executive Assistant"))
{
    Layout = "~/Views/Shared/FrontOfficeLayout.cshtml";
}
else
{
    Layout = "~/Views/Shared/_Layout.cshtml";
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                <li class=""breadcrumb-item"">Society Management</li>
                <li class=""breadcrumb-item active"" aria-current=""page""><b> View Customer Account Balance</b></li>
            </ol>
        </nav>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
");
            WriteLiteral("            <div class=\"search-container\">\r\n                <div class=\"search-sec\" style=\"display:block;\">\r\n");
            WriteLiteral(@"                </div>
                <div class=""text-center""> <a class=""searchopen"" title=""Search"" data-toggle=""tooltip"" data-placement=""bottom""> <i class=""icon-angle-arrow-down""></i> </a></div>
            </div>

            <!-- Search Panel -->
            <!--===================================================-->
            <div class=""card-body "">
");
#nullable restore
#line 54 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                 if (ResultData != null && ResultData.ToList().Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table data-toggle=""table"" id=""tblDoctor"" class=""table"">
                            <thead>
                                <tr>
                                    <th width=""60px"" class=""align-top text-center"">Sl#</th>
                                    <th width=""350px"" class=""align-top"">
                                        Branch Name
                                    </th>
                                    <th width=""350px"" class=""align-top"">
                                        Account Type
                                    </th>
                                    <th width=""350px"" class=""align-top"">
                                        Name
                                    </th>
                                    <th width=""350px"" class=""align-top"">
                                        Cust code
                                    </th>
                                    <th width=""350");
            WriteLiteral(@"px"" class=""align-top"">
                                        Account Number
                                    </th>



                                    <th width=""350px"" class=""align-top"">
                                        Amount
                                    </th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 86 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 92 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 94 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                   Write(list.Branch_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 97 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                   Write(list.HeadOfAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 100 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                   Write(list.customername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 103 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                   Write(list.Customer_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 106 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                   Write(list.Accountno);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n");
#nullable restore
#line 109 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                     if (@list.HeadOfAccount == "Fixed")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 112 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                       Write(list.Opening_Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 114 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 118 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                       Write(list.Minimum_Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 120 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <td>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 131 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"

                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 137 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 141 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\MiniBankingSystemSubrajit\MiniBank.Web\Views\AccountOpening\Viewallaccountballance.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""clearfix col-sm-12""></div>
            </div>
            <div class=""modal fade"" id=""SubmitModal"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5>Customer Details</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""modalMsg""></h6>
                        </div>
                        <div class=""modal-footer"">
");
            WriteLiteral(@"
                            <input type=""submit"" class=""btn btn-info btn-sm submitConfirm hbtn"" value=""Yes"" styk=""display:none"" />
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal fade"" id=""OpenAC"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5>Choose Account Type</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""DmodalMsg""></h6>

                            <select id=""TypAc"" class=""form-control");
            WriteLiteral("\" onchange=\"DisplayPage()\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b246e6fb005520de25f96f85ed12b086cac5b2217557", async() => {
                WriteLiteral("Saving");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b246e6fb005520de25f96f85ed12b086cac5b2218749", async() => {
                WriteLiteral("Share Cap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b246e6fb005520de25f96f85ed12b086cac5b2219944", async() => {
                WriteLiteral("Current");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b246e6fb005520de25f96f85ed12b086cac5b2221137", async() => {
                WriteLiteral("Fixed");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b246e6fb005520de25f96f85ed12b086cac5b2222328", async() => {
                WriteLiteral("Recuring");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b246e6fb005520de25f96f85ed12b086cac5b2223522", async() => {
                WriteLiteral("Loan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-success btn-sm No hbtn"" data-dismiss=""modal"" onclick=""OK()"">Yes</button>
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal fade"" id=""BindDropDown"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5>Choose Account To View</h5>
                        </div>
                        <div class");
            WriteLiteral(@"=""modal-body"">
                            <h6 class=""DmodalMsg""></h6>

                            <select id=""BindAccount"" class=""form-control"">
                            </select>

                        </div>
                        <div class=""modal-footer"">
");
            WriteLiteral(@"                            <button type=""button"" class=""btn btn-success btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"" onclick=""ViewAccount(id)"">Yes</button>
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>


            <div class=""modal fade"" id=""DSubmitModal"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5>Customer Details</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""DmodalMsg""></h6>
                        </di");
            WriteLiteral(@"v>
                        <div class=""modal-footer"">
                            <input type=""submit"" class=""btn btn-info btn-sm DsubmitConfirm hbtn"" value=""Yes"" styk=""display:none"" />
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        getDataTable();
    })
    function ViewAccount(id,acctyp) {
        debugger
        if (acctyp == ""Fixed"")
        {
            location.href = ""/AccountOpening/Fixdeposit_insertpageForViewByAdmin?id="" + id;
        }
        else {
            location.href = ""/AccountOpening/ViewAccountDetails?id=""+ id;
        }


    }
    function BindDropDown(CUSTOMER_id, Customer_Code) {

        $(""#BindAccount"").empty();
        $.ajax({
            url: ""/AccountOpening/Bind");
            WriteLiteral(@"DdlForaccount?id="" + Customer_Code,
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
    function OpenACC(Id, CustId) {
        $('.modalMsg').text('Are you Want To Open Account ?');
        $('.submitConfirm').css('display', 'block');
        $('#OpenAC').modal(""show"");
        x = Id;
        cid = CustId;

    }
    var type = ""Saving"";
    function DisplayPage() ");
            WriteLiteral(@"{
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
            ""searching"": true,
            //""bStateSave"": true,
            ""dom"": 'Bfrtip',
            ""autoWidth"": false,
            ""buttons"": [
                //{
                //    extend: 'print',
                //    title: 'Manage Block',
                //    exportOptions: {
                //        columns: [0, 1, 2, 3, 4]
                // ");
            WriteLiteral(@"   },
                //    customize: function (win) { $(win.document.body).css('font-size', '10pt').prepend('<img src=""' + origin + '/images/t5-logo-white.png""  style=""position:absolute; top:0; left:0;"" />'); $(win.document.body).find('table').addClass('compact').css('font-size', 'inherit'); }

                //}
                ,
                {
                    extend: 'pageLength'
                }
            ],
            ""lengthMenu"": [
                [10, 25, 50, 100, 1000 - 1],
                ['10 rows', '25 rows', '50 rows', '100 rows', '1000 rows', 'Show all']
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

    $("".subm");
            WriteLiteral(@"itConfirm"").click(function () {
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
            url: ""/Custmer/Deletecustomer?id="" + dl,
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


            },");
            WriteLiteral("\n            error: function (error) {\r\n                jsonValue = jQuery.parseJSON(error.responseText);\r\n                bootbox.alert(\"Error : \" + jsonValue);\r\n            }\r\n        });\r\n\r\n    });\r\n\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bank.Domain.AccountOpening.AccountopeningEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
