#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b702cb7eff90adc6d2cf6b8b9f8b4cef8aad2357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Custmer_viewPendingWithdrowamount), @"mvc.1.0.view", @"/Views/Custmer/viewPendingWithdrowamount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b702cb7eff90adc6d2cf6b8b9f8b4cef8aad2357", @"/Views/Custmer/viewPendingWithdrowamount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_Custmer_viewPendingWithdrowamount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.Customer.CustmerEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btnok"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Custmer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "viewPendingDepositeamount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
  
    ViewData["Title"] = "ViewDoctor";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";
    var ResultData = ViewBag.Result as List<Bank.Domain.Customer.CustmerEntity>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><span class=""icon-home1""></span></li>
                <li class=""breadcrumb-item"">Society Management</li>
                <li class=""breadcrumb-item active"" aria-current=""page""><b>Pending Withdrow  Transaction</b></li>
            </ol>
        </nav>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-header"">

            </div>
            <!-- Search Panel-->


            <div class=""search-container"">
                <div class=""search-sec"" style=""display: block;"">
");
            WriteLiteral(@"                </div>
                <div class=""text-center""> <a class=""searchopen"" title=""Search"" data-toggle=""tooltip"" data-placement=""bottom""> <i class=""icon-angle-arrow-down""></i> </a></div>
            </div>

            <!-- Search Panel -->
            <!--===================================================-->
            <div class=""card-body "">
");
#nullable restore
#line 61 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
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
                                        Branch
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Account Type
                                    </th>
                                    <th width=""150px"" class=""align-top"">
                                        Account Number
                                    </th>

                                    <th width=""150px"" class=""align-top"">
                                        Name
                                    </th>
                                    <th width=");
            WriteLiteral(@"""150px"" class=""align-top"">
                                        Amount
                                    </th>


                                    <th width=""150px"" class=""align-top"">Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 91 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                  
                                    int count = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                 foreach (var list in ResultData)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 97 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 99 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                       Write(list.BranchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 102 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                       Write(list.Account_Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 107 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                       Write(list.NewAccountNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 110 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                       Write(list.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 113 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                       Write(list.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            WriteLiteral("                                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5270, "\"", 5305, 3);
            WriteAttributeValue("", 5280, "Approve(\'", 5280, 9, true);
#nullable restore
#line 117 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
WriteAttributeValue("", 5289, list.trans_id, 5289, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5303, "\')", 5303, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm No hbtn\" data-dismiss=\"modal\" aria-label=\"Close\">Approve</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 120 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 125 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 129 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\Custmer\viewPendingWithdrowamount.cshtml"
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

            <div class=""modal fade"" id=""DSubmitModal"" tabindex=""1"" role=""dialog""
                 aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5>Customer Details</h5>
                        </div>
                        <div class=""modal-body"">
                            <h6 class=""DmodalMsg""></h6>
                        </div>
                        <div clas");
            WriteLiteral(@"s=""modal-footer"">
                            <input type=""submit"" class=""btn btn-info btn-sm DsubmitConfirm hbtn"" value=""Yes"" styk=""display:none"" />
                            <button type=""button"" class=""btn btn-danger btn-sm No hbtn"" data-dismiss=""modal"" aria-label=""Close"">No</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal fade"" id=""SuccessModal"" tabindex=""1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""resultMsg"" style=""color:blue""></h5>
                        </div>
                        <div class=""modal-body"">
                            <h5 class=""msgsuccess""></h5>
                        </div>
           ");
            WriteLiteral("             <div class=\"modal-footer\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b702cb7eff90adc6d2cf6b8b9f8b4cef8aad235715976", async() => {
                WriteLiteral("Close");
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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <!--===================================================-->
        </div>
    </div>
</div>
<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>

<script>
    $(document).ready(function () {
        getDataTable();
    })




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
                //    },
                //    customize: function (win) { $(win.document.body).css('font-size', '10pt').prepend('<img src=""' + origin + '/images/t5-logo-white.png""  style=""position:absolute; t");
            WriteLiteral(@"op:0; left:0;"" />'); $(win.document.body).find('table').addClass('compact').css('font-size', 'inherit'); }

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

    var x;
    function updateDepartment(Id, Cid) {
        $('.modalMsg').text('Are you sure to View the details ?');
        $('.submitConfirm').css('display', 'block');
        $('#SubmitModal').modal(""show"");
        x = Id;
        code = Cid
        //location.href = ""/RegistrationUser/User_Registration?id="" + DepartmentId;
        // }
    }
    var dl;
    function Approve(Id) {
        Swal.fire({
            title: 'Do You Want To Approve?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancel");
            WriteLiteral(@"Button: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, Approve it!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: ""/Custmer/Appprove_WithdrowAmount?id="" + Id,
                    type: ""POST"",
                    dataType: ""json"",
                    contentType: ""application/json;charset=UTF-8"",
                    success: function (data) {
                        if (data == ""135"") {
                            Swal.fire({
                                icon: 'success',
                                title: 'Successful',
                                text: 'Withdrow Successful',

                            }).then((value) => {
                                if (value) {
                                    location.reload();
                                }

                            });
                        }


         ");
            WriteLiteral(@"           },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        bootbox.alert(""Error : "" + jsonValue);
                    }
                });
            }
        })
    }

    //$("".DsubmitConfirm"").click(function () {
    //    $.ajax({
    //        url: ""/Custmer/Appprove_Deposite?id="" + dl,
    //        type: ""POST"",
    //        dataType: ""json"",
    //        contentType: ""application/json;charset=UTF-8"",
    //        success: function (data) {
    //            if (data == ""135"") {

    //                $('.modalMsg').text('');
    //                $('#DSubmitModal').modal(""hide"");
    //                //$('.msgsuccess').text('Amount Deposited');
    //                //$('#SuccessModal').modal('show');

    //                Swal.fire({
    //                    icon: 'success',
    //                    title: 'Successful',
    //                    text: 'Amount Deposit");
            WriteLiteral(@"ed',

    //                }).then((value) => {
    //                    if (value) {
    //                        location.reload();
    //                    }

    //                });
    //            }


    //        },
    //        error: function (error) {
    //            jsonValue = jQuery.parseJSON(error.responseText);
    //            bootbox.alert(""Error : "" + jsonValue);
    //        }
    //    });

    //});


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
