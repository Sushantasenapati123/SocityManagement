#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\RegisterAgent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a55160186f297cf18fdcada14088165262e443f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountOpening_RegisterAgent), @"mvc.1.0.view", @"/Views/AccountOpening/RegisterAgent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a55160186f297cf18fdcada14088165262e443f", @"/Views/AccountOpening/RegisterAgent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountOpening_RegisterAgent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.AccountOpening.AccountopeningEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountOpening", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterAgent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewRegisterAgent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\AccountOpening\RegisterAgent.cshtml"
  
    //ViewData["Title"] = "RoleView";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a55160186f297cf18fdcada14088165262e443f5509", async() => {
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

                /* Create an");
                WriteLiteral(@" active/current tablink class */
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a55160186f297cf18fdcada14088165262e443f8258", async() => {
                WriteLiteral(@"

    <div class=""page-title"">
        <div class=""title-details"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                    <li class=""breadcrumb-item"">Society Management</li>
                    <li class=""breadcrumb-item active"" aria-current=""page""><b>Registration Agent</b></li>
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
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a55160186f297cf18fdcada14088165262e443f9299", async() => {
                    WriteLiteral("Add");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a55160186f297cf18fdcada14088165262e443f10844", async() => {
                    WriteLiteral("View");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                        </ul>
                        <div class=""indicatorslist"">
                            <p class=""text-danger"">(*) Indicates mandatory </p>
                        </div>

                    </div>
                 
                    <div class=""card-body"">


                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Name <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""cname"" type=""text"" class=""form-control inputs"" onKeyPress=""edValueKeyPress()"" />
");
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Father Name <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""FName"" class=""form-control"" readonly />
                            </div>

                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Customer Code <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""c_code"" class=""form-control"" readonly />
                            </div>
                        </div>


                        <div class=""form-group row"">
                            <");
                WriteLiteral(@"label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">DOB <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""DOB"" class=""form-control"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">Agent ID <span class=""text-danger"">*</span></label>
                            <div class=""col-12 col-md-6 col-xl-4"">
                                <input id=""agentcode"" class=""form-control"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""RegstrationNo"">MemberShip Charge<span class=""text-danger"">*</span></label>
                            <div cl");
                WriteLiteral(@"ass=""col-12 col-md-6 col-xl-4"">
                                <input id=""charge"" class=""form-control"" readonly />
                                <input hidden id=""cod"" />
                            </div>
                        </div>

                        <div class=""form-group row"">
                            <span id=""bt"" class=""text-danger"" style=""margin-left:30px""></span>
                            <button class=""btn-danger form-control"" style=""width:150px;margin-left:180px;"" id=""submit"" onclick=""Add()"">Register</button>
                        </div>



                    </div>

                </div>
            </div>
        </div>


    </div>
    <input type=""button"" />
    
  

    <script type=""text/javascript"">

        function edValueKeyPress() {
            $(""#cname"").autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: '/AccountOpening/AutoCompleteForCustomerName");
                WriteLiteral(@"/',
                            data: { ""prefix"": request.term },
                            type: ""POST"",
                            success: function (data) {
                                response($.map(data, function (item) {
                                    return item;
                                }))
                            },
                            error: function (response) {
                                alert(response.responseText);
                            },
                            failure: function (response) {
                                alert(response.responseText);
                            }
                        });
                    },
                    select: function (e, i) {
                        $(""#cod"").val(i.item.val);
                        FindCustomerDetailsByCCode();
                    },
                    minLength: 1
                });
           
        }
      
        function Add() {
            if ");
                WriteLiteral(@"($('#cname').val() == """") {
                Swal.fire(""Please Enter Customer Name"")
               
                return false;


           
            }
            if ($('#agentcode').val() == """") {
                Swal.fire(""Please Enter Name Again"")

                return false;



            }
            var empObj = {
                Customer_Code: $('#c_code').val(),
                Agent_Code: $('#agentcode').val(),
               
            }

            $.ajax({
                type: ""POST"",
                url: ""/AccountOpening/AddAgent"",
                data: empObj,
                /*     type: ""POST"",*/
                success: function (result) {
                    if (result == ""Record Saved Successfully"") {
                        Swal.fire({
                            icon: 'success',
                            title: 'Successful',
                            text: '',
                            //footer: '<a href="""">Why do I have this issue?</a");
                WriteLiteral(@">'
                        })



                        $(""#FName"").val("""");
                        $(""#cname"").val("""");
                        $('#c_code').val("""");
                        $(""#DOB"").val("""");
                        $(""#agentcode"").val("""");
                        $(""#charge"").val("""");
                        $('#Ccode').val(""0"")
                    }
                    else if (result == ""Record Already Exist"") {
                        Swal.fire({
                            icon: 'error',
                            title: 'Record Already Exist',
                            text: '',
                            //footer: '<a href="""">Why do I have this issue?</a>'
                        })



                        $(""#FName"").val("""");
                        $(""#cname"").val("""");
                        $('#c_code').val("""");
                        $(""#DOB"").val("""");
                        $(""#agentcode"").val("""");
                        $(""#charge"").val(""");
                WriteLiteral(@""");
                        $('#Ccode').val(""0"")
                    }
                   

                },
                error: function (errormessage) {
                    alert(""Eror"");
                }
            });
        }

      

        function FindCustomerDetailsByCCode() {
            $.ajax({
                url: ""/AccountOpening/GetCustomerDetailByCustomerCode?code="" + $(""#cod"").val(),
                typr: ""GET"",
                contentType: ""application/json;charset=UTF-8"",
                dataType: ""json"",
                success: function (result) {
                    if (result != null) {

                        $(""#FName"").val(result.FATHER_HUSBAND);
                        $('#c_code').val(result.Customer_Code);
                        $(""#DOB"").val(result.DOB);
                        $(""#agentcode"").val(result.Agent_Code); 
                        $(""#charge"").val(""100/-"");


                    }
                    else {
                   ");
                WriteLiteral(@"     $(""#FName"").val("""");
                        $('#c_code').val("""");
                        $(""#DOB"").val("""");
                        $(""#agentcode"").val("""");
                        $(""#charge"").val("""");

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