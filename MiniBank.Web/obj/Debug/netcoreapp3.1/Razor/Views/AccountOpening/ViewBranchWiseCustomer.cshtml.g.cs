#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16614ce67e77b379ce9db9adf1f3484e519442e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountOpening_ViewBranchWiseCustomer), @"mvc.1.0.view", @"/Views/AccountOpening/ViewBranchWiseCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16614ce67e77b379ce9db9adf1f3484e519442e4", @"/Views/AccountOpening/ViewBranchWiseCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountOpening_ViewBranchWiseCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.Customer.CustmerEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("branch_id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("indsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TypAc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("DisplayPage()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    //Layout = "~/Views/Shared/_Layout.cshtml";
    var ResultData = ViewBag.Result as List<Bank.Domain.Customer.CustmerEntity>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
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
            WriteLiteral(@"
<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                <li class=""breadcrumb-item"">Society Management</li>
                <li class=""breadcrumb-item active"" aria-current=""page""><b>Customer View</b></li>
            </ol>
        </nav>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
");
            WriteLiteral("            <div class=\"search-container\">\r\n                <div class=\"search-sec\" style=\"display: block;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16614ce67e77b379ce9db9adf1f3484e519442e47223", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group form-row\">\r\n                            <div class=\"col-12 col-md-6 col-xl-3\">\r\n                                <label class=\"control-label\">Select Branch</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16614ce67e77b379ce9db9adf1f3484e519442e47736", async() => {
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 42 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Branch,"branch_id","Branch_Name")) ;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.branch_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                                <button id=""btnSearch"" class=""btn btn-primary mt-xl-4 mt-2""> <i class=""fa fa-search""></i> Search</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral(@"
                </div>
                <div class=""text-center""> <a class=""searchopen"" title=""Search"" data-toggle=""tooltip"" data-placement=""bottom""> <i class=""icon-angle-arrow-down""></i> </a></div>
            </div>

            <!-- Search Panel -->
            <!--===================================================-->
            <div class=""card-body "">
");
#nullable restore
#line 59 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
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

                                    <th width=""150px"" class=""align-top"">
                                        Father/Husband
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Name
                                    </th>

                                    <th width=""150px"" class=""align-top"">
                                        Email
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Mobile No.
                                    </th>
                                    <th width=""15");
            WriteLiteral(@"0px"" class=""align-top"">
                                        Address
                                    </th>

                                    <th width=""150px"" class=""align-top"">Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 88 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 94 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 97 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                   Write(list.FATHER_HUSBAND);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 101 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                   Write(list.CUSTOMER_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 104 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                   Write(list.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 107 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                   Write(list.PHONE_NO_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 110 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                   Write(list.PER_ADDRESS_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 113 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                                         if (@list.Branch_Name == @ViewBag.Branchn)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <input type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5110, "\"", 5170, 5);
            WriteAttributeValue("", 5120, "OpenACC(\'", 5120, 9, true);
#nullable restore
#line 115 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
WriteAttributeValue("", 5129, list.CUSTOMER_id, 5129, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5146, "\',\'", 5146, 3, true);
#nullable restore
#line 115 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
WriteAttributeValue("", 5149, list.Customer_Code, 5149, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5168, "\')", 5168, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm  hbtn\" value=\"Open AC\" />\r\n                                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5291, "\"", 5357, 6);
            WriteAttributeValue("", 5301, "BindDropDown(\'", 5301, 14, true);
#nullable restore
#line 116 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
WriteAttributeValue("", 5315, list.CUSTOMER_id, 5315, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5332, "\',", 5332, 2, true);
            WriteAttributeValue(" ", 5334, "\'", 5335, 2, true);
#nullable restore
#line 116 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
WriteAttributeValue("", 5336, list.Customer_Code, 5336, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5355, "\')", 5355, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm No hbtn\" data-dismiss=\"modal\" aria-label=\"Close\">View AC</button>\r\n");
#nullable restore
#line 117 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5654, "\"", 5720, 6);
            WriteAttributeValue("", 5664, "BindDropDown(\'", 5664, 14, true);
#nullable restore
#line 121 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
WriteAttributeValue("", 5678, list.CUSTOMER_id, 5678, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5695, "\',", 5695, 2, true);
            WriteAttributeValue(" ", 5697, "\'", 5698, 2, true);
#nullable restore
#line 121 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
WriteAttributeValue("", 5699, list.Customer_Code, 5699, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5718, "\')", 5718, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm No hbtn\" data-dismiss=\"modal\" aria-label=\"Close\">View AC</button>\r\n");
#nullable restore
#line 122 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 126 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"

                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 132 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 136 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
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
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16614ce67e77b379ce9db9adf1f3484e519442e424536", async() => {
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 168 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewBranchWiseCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Account,"gl_nature","gl_nature")) ;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
                        <div class=""modal-body"">
                         ");
            WriteLiteral(@"   <h6 class=""DmodalMsg""></h6>

                            <select id=""BindAccount"" class=""form-control"">
                            </select>

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-success btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"" onclick=""ViewAccount()"">Yes</button>
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal fade"" id=""DSubmitModal"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-hea");
            WriteLiteral(@"der"">
                            <h5>Customer Details</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""DmodalMsg""></h6>
                        </div>
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
    function ViewAccount() {
        if ($('#BindAccount').val()!=null) {
            if ($(""#BindAccount option:selected"").text().split("":"")[0] == ""Fixed"") {
                location.href = ""/AccountOpening/Fixdeposit_insertpageForView");
            WriteLiteral(@"ByAdmin?id="" + $('#BindAccount').val();
            }
            else {
                location.href = ""/AccountOpening/ViewAccountDetailsByAdmin?id="" + $('#BindAccount').val();
            }
        }
       
        

    }
    function BindDropDown(CUSTOMER_id, Customer_Code) {

        $(""#BindAccount"").empty();
        $.ajax({
            url: ""/AccountOpening/BindDdlForaccount?id="" + Customer_Code,
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
            }");
            WriteLiteral(@"
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
    function DisplayPage() {
        type = $('#TypAc').val()
    }

    function OK() {
        
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
        $('#tblDoctor').DataTa");
            WriteLiteral(@"ble({
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
                ['10 rows', '25 rows', '50 rows', '100 rows', '1000 rows', 'Show all']
            ]
        });
    }
    var ");
            WriteLiteral(@"code;
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
            url: ""/Custmer/Deletecustomer?id="" + dl,
            type: ""POST"",
            dataType: ""json"",
            contentType: ""application/json;charset=UTF-8"",
            success: function (data) {
     ");
            WriteLiteral(@"           if (data == ""3"") {
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
