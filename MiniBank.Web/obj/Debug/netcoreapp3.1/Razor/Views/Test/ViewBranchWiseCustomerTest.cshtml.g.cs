#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Test\ViewBranchWiseCustomerTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "019761e9798844e14617e1cd59f8d6f542b0ec1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_ViewBranchWiseCustomerTest), @"mvc.1.0.view", @"/Views/Test/ViewBranchWiseCustomerTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019761e9798844e14617e1cd59f8d6f542b0ec1c", @"/Views/Test/ViewBranchWiseCustomerTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_ViewBranchWiseCustomerTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.Customer.CustmerEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("branch_id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("find()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("indsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TypAc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("DisplayPage()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Datatable/JS/buttons.print.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Datatable/CSS/buttons.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Datatable/CSS/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Datatable/JS/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Datatable/JS/dataTables.buttons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Test\ViewBranchWiseCustomerTest.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";
    var ResultData = ViewBag.Result as List<Bank.Domain.Customer.CustmerEntity>;

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019761e9798844e14617e1cd59f8d6f542b0ec1c9441", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group form-row\">\r\n                            <div class=\"col-12 col-md-6 col-xl-3\">\r\n                                <label class=\"control-label\">Select Branch</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019761e9798844e14617e1cd59f8d6f542b0ec1c9954", async() => {
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 30 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Test\ViewBranchWiseCustomerTest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Branch,"branch_id","Branch_Name")) ;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Test\ViewBranchWiseCustomerTest.cshtml"
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
                WriteLiteral("\r\n                            </div>\r\n\r\n");
                WriteLiteral("                        </div>\r\n                    ");
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
            WriteLiteral(@"
                </div>
                <div class=""text-center""> <a class=""searchopen"" title=""Search"" data-toggle=""tooltip"" data-placement=""bottom""> <i class=""icon-angle-arrow-down""></i> </a></div>
            </div>

            <!-- Search Panel -->
            <!--===================================================-->
            <div class=""card-body "">
");
            WriteLiteral(@"                <div class=""table-responsive"">
                    <table id=""customerDatatable"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>

                                <th>Father Name</th>
                                <th>Customer Name</th>
                                <th>Email</th>
                                <th>Phone No</th>
                                <th>Address</th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                    </table>
                    <!--<table data-toggle=""table"" id=""custodmerDatatable"" class=""table"">
                    <thead>
                        <tr>
                            <th width=""60px"" class=""align-top text-center"">Sl#</th>

                            <th width=""150px"" class=""align-top"">
                                Father/Husband
   ");
            WriteLiteral(@"                         </th>
                            <th width=""150px"" class=""align-top"">
                                Name
                            </th>

                            <th width=""150px"" class=""align-top"">
                                Email
                            </th>
                            <th width=""150px"" class=""align-top"">
                                Mobile No.
                            </th>
                            <th width=""150px"" class=""align-top"">
                                Address
                            </th>

                            <th width=""150px"" class=""align-top"">Action</th>
                        </tr>
                    </thead>-->
");
            WriteLiteral("                    <!--</table>-->\r\n");
            WriteLiteral(@"                    <div class=""clearfix col-sm-12""></div>
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
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019761e9798844e14617e1cd59f8d6f542b0ec1c18108", async() => {
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 168 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Test\ViewBranchWiseCustomerTest.cshtml"
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
               ");
            WriteLiteral(@"             <div class=""modal-body"">
                                <h6 class=""DmodalMsg""></h6>

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
                    <div class=""modal-dialog modal-dialog-ce");
            WriteLiteral(@"ntered"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
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
    <div class=""container"">
        <br />
        <div style=""width:90%; margin:0 auto;"">

        </div>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019761e9798844e14617e1cd59f8d6f542b0ec1c23145", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "019761e9798844e14617e1cd59f8d6f542b0ec1c24189", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "019761e9798844e14617e1cd59f8d6f542b0ec1c25308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019761e9798844e14617e1cd59f8d6f542b0ec1c26428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019761e9798844e14617e1cd59f8d6f542b0ec1c27473", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
        function find() {
            if ($.fn.DataTable.isDataTable('#customerDatatable')) {
                $('#customerDatatable').DataTable().destroy();
            }
            $('#customerDatatable').dataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""filter"": true,
                ""ajax"": {
                    ""url"": ""/Test/ViewBranchWiseCustomerTest?id="" + $(""#branch_id"").val(),
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },


                ""columnDefs"": [{
                    ""targets"": [0],
                    ""visible"": false,
                    ""searchable"": false
                }],

                ""columns"": [
                    { ""data"": ""fatheR_HUSBAND"", ""fatheR_HUSBAND"": ""First Name"", ""autoWidth"": true },
                    { ""data"": ""customeR_NAME"", ""name"": ""customeR_NAME"", ""autoWidth"": true },
                    { ""data"": ""email"", ""name"": ""Email"", """);
            WriteLiteral(@"autoWidth"": true },
                    { ""data"": ""phonE_NO_1"", ""name"": ""phonE_NO_1"", ""autoWidth"": true },

                    { ""data"": ""peR_ADDRESS_1"", ""name"": ""Date Of Birth"", ""autoWidth"": true },
                    {
                        ""render"": function (data, row) { return ""<a href='#' class='btn btn-danger' onclick=DeleteCustomer('"" + row.id + ""'); >Delete</a>""; }
                    },
                ]

            });


        }
        //$(document).ready(function () {
        //    getDataTable();

        //})
        function ViewAccount() {
            if ($('#BindAccount').val() != null) {
                if ($(""#BindAccount option:selected"").text().split("":"")[0] == ""Fixed"") {
                    location.href = ""/AccountOpening/Fixdeposit_insertpageForViewByAdmin?id="" + $('#BindAccount').val();
                }
                else {
                    location.href = ""/AccountOpening/ViewAccountDetailsByAdmin?id="" + $('#BindAccount').val();
                }");
            WriteLiteral(@"
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
                }
            });

            $('#BindDropDown').modal(""show"");


        }
        var x;
        var cid;
        function Ope");
            WriteLiteral(@"nACC(Id, CustId) {
            $('.modalMsg').text('Are you Want To Open Account ?');
            $('.submitConfirm').css('display', 'block');
            $('#OpenAC').modal(""show"");
            x = Id;
            cid = CustId;

        }
        var type;
        function DisplayPage() {
            type = $('#TypAc').val()
        }
        function OK() {
            if ($('#TypAc').val() == ""TRANSPORT LOAN"") {
                location.href = ""/AccountOpening/Loaninsertpage?id="" + x + ""&AcType="" + $('#TypAc').val() + ""&CustCode="" + cid;

            }
            else if ($('#TypAc').val() == ""BUSINESS LOAN"") {
                location.href = ""/AccountOpening/Loaninsertpage?id="" + x + ""&AcType="" + $('#TypAc').val() + ""&CustCode="" + cid;

            }
            else if ($('#TypAc').val() == ""FIXED DEPOSIT"") {
                location.href = ""/AccountOpening/Fixdeposit_insertpage?id="" + x + ""&AcType="" + $('#TypAc').val() + ""&CustCode="" + cid;

            }
            else if ($");
            WriteLiteral(@"('#TypAc').val() == ""DailyDeposite"") {
                location.href = ""/AccountOpening/DailyDepositePage?id="" + x + ""&AcType="" + $('#TypAc').val() + ""&CustCode="" + cid;

            }
            else if ($('#TypAc').val() == ""AGENT SUSPENSE"") {
                location.href = ""/AccountOpening/Agentinsertpage?id="" + x + ""&AcType="" + $('#TypAc').val() + ""&CustCode="" + cid;

            }
            else {
                location.href = ""/AccountOpening/insertpage?id="" + x + ""&AcType="" + $('#TypAc').val() + ""&CustCode="" + cid;

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
           ");
            WriteLiteral(@"         //        columns: [0, 1, 2, 3, 4]
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
  ");
            WriteLiteral(@"          code = custcode;
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
                    if (data == ""3"") {
                        $('.modalMsg').text('');
                        $('#DSubmitModal').modal(""hide"");
         ");
            WriteLiteral(@"               $('.msgsuccess').text('Data Deleted successfully.');
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
