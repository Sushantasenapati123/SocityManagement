#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountOpening_ViewPendingAccount), @"mvc.1.0.view", @"/Views/AccountOpening/ViewPendingAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef", @"/Views/AccountOpening/ViewPendingAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountOpening_ViewPendingAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.AccountOpening.AccountopeningEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("indsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Saving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Share_Cap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Current", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Fixed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Recuring", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Loan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";
    var ResultData = ViewBag.Result as List<Bank.Domain.AccountOpening.AccountopeningEntity>;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef6506", async() => {
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/27be94b9e4.js\" crossorigin=\"anonymous\"></script>\r\n");
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
            WriteLiteral(@"

<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                <li class=""breadcrumb-item"">Society Management</li>
                <li class=""breadcrumb-item active"" aria-current=""page""><b>Edit Pending Account</b></li>
            </ol>
        </nav>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
");
            WriteLiteral("            <div class=\"search-container\">\r\n                <div class=\"search-sec\" style=\"display: block;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef8304", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
#line 50 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
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
                                        Account Type
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Name
                                    </th>

                                    <th width=""150px"" class=""align-top"">
                                        Branch Code
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Opening Date
                                    </th>
                                    <th wid");
            WriteLiteral("th=\"150px\" class=\"align-top\">Action</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 75 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 81 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 84 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                       Write(list.HeadOfAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 88 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                       Write(list.customername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 91 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                       Write(list.BranchCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 94 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                                       Write(list.OpeningDATE);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n\r\n\r\n                                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4627, "\"", 4697, 5);
            WriteAttributeValue("", 4637, "ViewAccount(\'", 4637, 13, true);
#nullable restore
#line 99 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
WriteAttributeValue("", 4650, list.Openingdetails_id, 4650, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4673, "\',\'", 4673, 3, true);
#nullable restore
#line 99 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
WriteAttributeValue("", 4676, list.HeadOfAccount, 4676, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4695, "\')", 4695, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm No hbtn\" data-dismiss=\"modal\" aria-label=\"Close\"> <i class=\"fa-regular fa-pen-to-square\"></i></button>\r\n                                           \r\n                                    </tr>\r\n");
#nullable restore
#line 102 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"

                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 108 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 112 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\ViewPendingAccount.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef19039", async() => {
                WriteLiteral("Saving");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef20231", async() => {
                WriteLiteral("Share Cap");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef21426", async() => {
                WriteLiteral("Current");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef22619", async() => {
                WriteLiteral("Fixed");
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef23810", async() => {
                WriteLiteral("Recuring");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30b3c4de91a049eb1c5e007c4ba1f5549bcd8ef25004", async() => {
                WriteLiteral("Loan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
            WriteLiteral(@"                            <button type=""button"" class=""btn btn-success btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"" onclick=""ViewAccount()"">Yes</button>
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
                        </div>");
            WriteLiteral(@"
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
    function ViewAccount(id, HeadOfAccount) {
        if (HeadOfAccount == 'Fixed') {
            location.href = ""/AccountOpening/Fixdeposit_insertpage2_forEdit?id="" + id;
        }
       else if (HeadOfAccount == 'Loan') {
            location.href = ""/AccountOpening/Loaninsertpage_ForEdit?id="" + id;
        }
        else
        location.href = ""/AccountOpening/insertpage_ForEdit?id="" +id;



    }

    function BindDropDown(CUSTOMER_id, Customer_");
            WriteLiteral(@"Code) {

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
    function OpenACC(Id, CustId) {
        $('.modalMsg').text('Are you Want To Open Account ?');
        $('.submitConfirm').css('display', 'block');
        $('#OpenAC').modal(""s");
            WriteLiteral(@"how"");
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
            ""searching"": true,
            //""bStateSave"": true,
            ""dom"": 'Bfrtip',
            ""autoWidth"": false,
            ""buttons"": [
                //{
                //    extend: 'print',
                //    title: 'Manage Block',
 ");
            WriteLiteral(@"               //    exportOptions: {
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
    var code;
    function updateDepartment(Id, custcode) {
        $('.modalMsg').text('Are you sure to View the details ?');
        $('.submitConfirm').css('display', 'block');
        $('#SubmitModal').modal(""show"");
        x = Id;
        code = custcode;
        //");
            WriteLiteral(@"location.href = ""/RegistrationUser/User_Registration?id="" + DepartmentId;
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
                if (data == ""3"") {
                    $('.modalMsg').text('');
                    $('#DSubmitModal').modal(""hide"");
                    $('.msgsuccess').text('Data Deleted successfully.');
                    $('#SuccessModal').modal('show');
          ");
            WriteLiteral(@"          /* window.location.href = ""/RegistrationUser/GetAllUsers"";*/
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bank.Domain.AccountOpening.AccountopeningEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
