#pragma checksum "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\SubMenu\AddSubMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46739167b97f7426b658f2f206e9b1edb4de6fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubMenu_AddSubMenu), @"mvc.1.0.view", @"/Views/SubMenu/AddSubMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46739167b97f7426b658f2f206e9b1edb4de6fd2", @"/Views/SubMenu/AddSubMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681a471abef6d22e4bec0f7b9a2c92beba0be144", @"/Views/_ViewImports.cshtml")]
    public class Views_SubMenu_AddSubMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Domain.MenuMaster.MenuClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SubMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSubMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewSubMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlMenuName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\SubMenu\AddSubMenu.cshtml"
  
    ViewData["Title"] = "AddSubMenu";
    Layout = "~/Views/Shared/dynamicLayoutManager.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb p-0 mb-0 bg-transparent"" id=""navigation"">
            </ol>
        </nav>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs nav-fill"" role=""tablist"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46739167b97f7426b658f2f206e9b1edb4de6fd26857", async() => {
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46739167b97f7426b658f2f206e9b1edb4de6fd28318", async() => {
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
            WriteLiteral("\r\n                </ul>\r\n                <div class=\"indicatorslist\">\r\n                    <a");
            BeginWriteAttribute("title", " title=\"", 887, "\"", 895, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <p class=""ml-2"">(*) Indicates mandatory </p>
                </div>
            </div>
            <!-- BASIC FORM ELEMENTS -->
            <!--===================================================-->
            <div class=""card-body"">
                <input type=""hidden"" value=""0"" id=""hdnSubMenuId"" />
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""><b>Menu Name</b><span class=""text-danger"">*</span></label>
                    <div class=""col-xs-12 col-md-4 col-xl-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46739167b97f7426b658f2f206e9b1edb4de6fd210774", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46739167b97f7426b658f2f206e9b1edb4de6fd211063", async() => {
                    WriteLiteral("--Select--");
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
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#nullable restore
#line 36 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\SubMenu\AddSubMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Name,"MenuId","MenuName"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "C:\Users\sushanta.senapati\Desktop\CSM_FRAMEWORK\SocityManagement\MiniBank.Web\Views\SubMenu\AddSubMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MenuId);

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

                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input""><b>SubMenu Name</b> <span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <input type=""text"" id=""txtSubMenuName"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input""><b>SubMenu URL</b> <span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <input type=""text"" id=""txtSubMenuURL"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input""><b>Sl.No</b> <spa");
            WriteLiteral(@"n class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <input type=""text"" id=""txtSlNo"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input""><b>SubMenu Description</b> <span class=""text-danger"">*</span></label>
                    <div class=""col-12 col-md-4 col-xl-4"">
                        <input type=""text"" id=""txtSubMenuDescription"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
                    <div class=""col-12 col-md-6 col-xl-4"">
                        <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                        <button class=""btn btn-danger mb-1"" id=""btnCancel"">Reset</button>
");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

        <!--===================================================-->
        <!-- END BASIC FORM ELEMENTS -->
    </div>
</div>
<script>
    $(document).ready(function () {
        //breadcumb
        loadNavigation('Add SubMenu', 'gldata', 'plsubmission', 'Add SubMenu', '', 'Add SubMenu');
        var SubMenuId = getUrlVars()[""SubMenuId""];
        if (SubMenuId != undefined) {
            $(""#btnSubmit"").html(""Update"");
            $(""#btnCancel"").html(""Cancel"");
            Edit(SubMenuId);
        }
    });
    function validate() {
        if ($('#txtSubMenuName').val() == """") {
            alert(""Please Enter SubMenu!"");
            $('#txtSubMenuName').focus();
            return false;
        }
        else if ($('#txtSlNo').val() == """") {
            alert(""Please Enter SlNo!"");
            $('#txtSlNo').focus();
            return false;
        }
        else if ($('#txtSubMenuDescripti");
            WriteLiteral(@"on').val() == """") {
            alert(""Please Enter SubMenu Description!"");
            $('#txtSubMenuDescription').focus();
            return false;
        }
        else if ($('#txtSubMenuURL').val() == """") {
            alert(""Please Enter SubMenu URL!"");
            $('#txtSubMenuURL').focus();
            return false;
        }
        else {
            $(""#btnCancel"").hide();
            return true;
        }
    }

    $(""#btnSubmit"").click(function () {
        var dept = {
            MenuId: $(""#ddlMenuName"").val(),
            SubMenuId: $(""#hdnSubMenuId"").val(),
            SubMenuName: $(""#txtSubMenuName"").val(),
            SubMenuURL: $(""#txtSubMenuURL"").val(),
            SlNo: $(""#txtSlNo"").val(),
            SubMenuDescription: $(""#txtSubMenuDescription"").val()
        };
        if (validate()) {
            if (confirm(""Are you sure you want to Submit ?"")) {
                $.ajax({
                    url: ""/SubMenu/AddSubMenu"",
                    data: ");
            WriteLiteral(@"dept,
                    type: ""POST"",
                    success: function (result) {
                        if (getUrlVars()[""SubMenuId""] != undefined) {
                            alert(result)
                            window.location.href =""/SubMenu/ViewSubMenu"";
                        }
                        else {
                            alert(result);
                            reset();
                        }
                    },
                    error: function (errormessage) {
                        alert(errormessage.responseText);
                    }
                });
            }
        }
    });
    //UPDATE
    function Edit(SubMenuId) {
        $.ajax({
            url:""/SubMenu/SubMenuGetById?SubMenuId="" + SubMenuId,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                $(""#ddlMenuName"").val(result.MenuId),
              ");
            WriteLiteral(@"  $(""#txtMenuName"").val(result.MenuName),
                $(""#hdnSubMenuId"").val(result.SubMenuId),
                $(""#txtSubMenuName"").val(result.SubMenuName),
                $(""#txtSubMenuURL"").val(result.SubMenuURL),
                $(""#txtSlNo"").val(result.SlNo),
                $(""#txtSubMenuDescription"").val(result.SubMenuDescription)
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }

    $(""#btnCancel"").click(function () {
        if (getUrlVars()[""MenuId""] != undefined) {
            window.location.href =""/SubMenu/AddSubMenu"";
        }
    })
    //< !--=================================================== -->
    function reset() {
        window.location.href =""/SubMenu/AddSubMenu"";
    }
        //< !--=================================================== -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bank.Domain.MenuMaster.MenuClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
