#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\DepositeAmount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1a6c6b6dd19bf8382021ff22428c3328884e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountOpening_DepositeAmount), @"mvc.1.0.view", @"/Views/AccountOpening/DepositeAmount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1a6c6b6dd19bf8382021ff22428c3328884e45", @"/Views/AccountOpening/DepositeAmount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountOpening_DepositeAmount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.AccountOpening.AccountopeningEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Calender/calender2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Calender/Calender.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\DepositeAmount.cshtml"
  
    //ViewData["Title"] = "RoleView";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a6c6b6dd19bf8382021ff22428c3328884e455319", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a6c6b6dd19bf8382021ff22428c3328884e455658", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae1a6c6b6dd19bf8382021ff22428c3328884e456757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
  

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        #Nominee1 {
            background-color: lightgoldenrodyellow;
        }

        #Nominee2 {
            background-color: lightgray;
        }

        body {
            font-family: Arial;
        }

        .tab {
            overflow: hidden;
            border: 1px solid #ccc;
            background-color: #f1f1f1;
        }

            /* Style the buttons inside the tab */
            .tab button {
                background-color: greenyellow;
                float: left;
                border: none;
                outline: none;
                cursor: pointer;
                padding: 14px 16px;
                transition: 0.3s;
                font-size: 17px;
            }
                /* Change background color of buttons on hover */
                .tab button:hover {
                    background-color: #ddd;
                }

                /* Cre");
                WriteLiteral(@"ate an active/current tablink class */
                .tab button.active {
                    background-color: #ccc;
                }

        /* Style the tab content */
        .tabcontent {
            display: none;
            padding: 6px 12px;
            border: 1px solid #ccc;
            border-top: none;
        }
    </style>
");
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


<style type=""text/css"">
    .drpdown {
        width: 150px;
    }

    /*.container {
        padding: 50px;
    }*/

    input[type=reset] {
        background-color: red;
        color: white;
        padding: 12px 20px;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        align-content: center;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a6c6b6dd19bf8382021ff22428c3328884e4510428", async() => {
                WriteLiteral(@"

    <div class=""page-title"">
        <div class=""title-details"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                    <li class=""breadcrumb-item"">Society Management</li>
                    <li class=""breadcrumb-item active"" aria-current=""page""><b>Deposite Amount</b></li>
                </ol>
            </nav>
        </div>
    </div>
    <div class=""row"">

        <div class=""container"">
            <div>
                <div class=""card"">
                    <div class=""card-header"">
                        <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                        </ul>
                        <div class=""indicatorslist"">
                            <p class=""text-danger"">(*) Indicates mandatory </p>
                        </div>

                    </div>
                    <div class=""card-body"">

                        ");
                WriteLiteral(@"<div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Account Number<span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""accountno"" type=""number"" class=""form-control"" onblur=""FindAccountDetails()"" />

                            </div>
                            <label class=""col-12 col-md-2 col-xl-4 control-label"" for=""RegstrationNo""><span class=""text-info"" id=""bal""></span></label>


                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Father Name <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""FName"" class=""form-control"" readonly />
                            </div>

               ");
                WriteLiteral(@"         </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Account Type <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""actype"" class=""form-control"" readonly />
                            </div>

                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Name <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""Name"" class=""form-control"" readonly />
                            </div>
                        </div>

                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""Regs");
                WriteLiteral(@"trationNo"">Branch <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""Branch"" class=""form-control"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Amount <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""Amount"" class=""form-control"" type=""number"" />

                            </div>
                        </div>
                        <div class=""form-group row"">
                            <span id=""bt"" class=""text-danger"" style=""margin-left:30px""></span>
                            <button class=""btn-danger form-control"" style=""width:150px;margin-left:180px;"" id=""submit"" onclick=""Add()"">Submit</button>
    ");
                WriteLiteral(@"                    </div>



                    </div>

                </div>
            </div>
        </div>


    </div>
    <input type=""button"" />
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@7.12.15/dist/sweetalert2.all.min.js""></script>
    <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/sweetalert2@7.12.15/dist/sweetalert2.min.css'></link>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a6c6b6dd19bf8382021ff22428c3328884e4515474", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#submit"").hide();
        });
        function Add() {
            if ($('#Amount').val() == """") {
                Swal.fire(""Please Enter Amount"")
                return false;
              

            }
            var empObj = {
                customername: $('#Name').val(),
                BranchName: $('#Branch').val(),
                Amount: $('#Amount').val(),
                Account_Type: $('#actype').val(),
                NewAccountNo: $('#accountno').val()
            }

            $.ajax({
                type: ""POST"",
                url: ""/Custmer/insertsavingAmount"",
                data: empObj,
                /*     type: ""POST"",*/
                success: function (result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'Successful',
                        text: '',
                        //footer: '<a");
                WriteLiteral(@" href="""">Why do I have this issue?</a>'
                    })
                    $(""#FName"").val("""");
                    $('#Name').val("""");
                    $('#accountno').val("""");
                    $('#Amount').val("""");
                    $(""#Branch"").val("""");
                    $(""#actype"").val("""");
                    $(""#bal"").html("""");
                    $(""#submit"").hide();
                    $(""#bt"").html("""");

                },
                error: function (errormessage) {
                    alert(""Eror"");
                }
            });
        }

        function FindAccountDetails() {
            $.ajax({
                url: ""/Custmer/GetAccountDetailByAccountNo?num="" + $(""#accountno"").val(),
                typr: ""GET"",
                contentType: ""application/json;charset=UTF-8"",
                dataType: ""json"",
                success: function (result) {
                    if (result != null) {
                        if (result.HeadOfAccount ");
                WriteLiteral(@"== 'SAVING BANK DEPOSIT' || result.HeadOfAccount == 'Current') {
                            $(""#FName"").val(result.FATHER_HUSBAND);
                            $('#Name').val(result.customername);
                            $(""#Branch"").val(result.BranchName);
                            $(""#actype"").val(result.HeadOfAccount);
                            $(""#bal"").html('Available Balance=' + result.Opening_Balance);
                            $(""#submit"").show();
                            $(""#bt"").html("""");
                        }
                        else if (result.HeadOfAccount == 'DailyDeposite' || result.HeadOfAccount == 'SHARE CAPITAL' || result.HeadOfAccount == 'FIXED DEPOSIT' || result.HeadOfAccount == 'Recuring' || result.HeadOfAccount == 'BUSINESS LOAN' || result.HeadOfAccount == 'TRANSPORT LOAN') {
                          
                            $(""#FName"").val("""");
                            $('#Name').val("""");
                            $(""#Branch"").val("""");
     ");
                WriteLiteral(@"                       $(""#actype"").val("""");
                            $(""#bal"").html("""");
                            Swal.fire({
                                icon: 'error',
                                title: 'This is a ' + result.HeadOfAccount+' Account',
                                text: 'Only in Saving and Current account You Can Deposite Amount!',
                                //footer: '<a href="""">Why do I have this issue?</a>'
                            })
                           // $(""#bt"").html(""Only in Saving and Current account You Can Deposite Amount"");
                            $(""#submit"").hide();
                        }
                    }
                  
                    else {
                        /*alert(""Only in Saving and Current account You Can Deposite Amount"");*/
                        $(""#FName"").val("""");
                        $('#Name').val("""");
                        $(""#Branch"").val("""");
                        $(""#actype"").val");
                WriteLiteral(@"("""");
                        $(""#bal"").html("""");
                        Swal.fire({
                            icon: 'error',
                            title: 'Invalid Account Number...',
                            text: 'Please Enter Valid Account Number!',
                            //footer: '<a href="""">Why do I have this issue?</a>'
                        })
                        //$(""#bt"").html(""Invalid Accuunt Number"");
                        $(""#submit"").hide();
                    }



                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }
    </script>





");
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
            WriteLiteral("\r\n\r\n\r\n");
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
