#pragma checksum "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\Home\Interventions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47491b002d8123f4229a95a77cdfe33702375c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Interventions), @"mvc.1.0.view", @"/Views/Home/Interventions.cshtml")]
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
#line 1 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\_ViewImports.cshtml"
using CustomerPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\_ViewImports.cshtml"
using CustomerPlatform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47491b002d8123f4229a95a77cdfe33702375c8a", @"/Views/Home/Interventions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643991406567d349a6b08f0c1a3ce13a455b07ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Interventions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formintervention"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formintervention"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\Home\Interventions.cshtml"
  
    ViewData["Title"] = "Interventions";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""text-center"">
    <h1 class=""text-primary display-4"">REQUEST FOR INTERVENTION</h1>
</div>
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <!-- left column -->
            <div class=""col-md-4""></div>
            <div class=""col-md-4"">
                <!-- general form elements -->
                <div class=""card card-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Create intervention</h3>

                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47491b002d8123f4229a95a77cdfe33702375c8a5671", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div class=""form-group "">
                                <label for=""building"">Building</label>
                                <select id=""building"" required class=""form-control pointer"" name=""building_id"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47491b002d8123f4229a95a77cdfe33702375c8a6265", async() => {
                    WriteLiteral("--- Select ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 30 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\Home\Interventions.cshtml"
                               Write(Html.Raw( ViewBag.BuldingSos ));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group battery"">
                                <label for=""battery"">Battery</label>
                                <select id=""battery"" required class=""form-control pointer"" name=""battery_id"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47491b002d8123f4229a95a77cdfe33702375c8a8510", async() => {
                    WriteLiteral("--- Select ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 37 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\Home\Interventions.cshtml"
                               Write(Html.Raw(ViewBag.BatterySos));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group column"">

                                <label for=""column"">Column</label>
                                <select id=""column"" required class=""form-control pointer"" name=""column_id"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47491b002d8123f4229a95a77cdfe33702375c8a10750", async() => {
                    WriteLiteral("--- Select ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 45 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\Home\Interventions.cshtml"
                               Write(Html.Raw( ViewBag.ColumnSos));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group  elevator"">
                                <label for=""elevator"">Elevator</label>
                                <select id=""elevator"" required class=""form-control pointer"" name=""elevator_id"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47491b002d8123f4229a95a77cdfe33702375c8a13000", async() => {
                    WriteLiteral("--- Select ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 52 "D:\CodeBoxx\Odyssey\Week 11\version final jeudi\CustomerPlatform\Views\Home\Interventions.cshtml"
                               Write(Html.Raw( ViewBag.ElevatorSos));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group description"">
                                <label>Description</label>
                                <textarea class=""form-control"" id=""description"" rows=""3""
                                    placeholder=""Enter ...""></textarea>
                            </div>
                        </div>
                        <!-- /.card-body -->

                        <div class=""card-footer btnform"">
                            <button class=""btn btn-primary btn-lg btn-block"" id=""sendbtn"">SUBMIT</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\"></div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n   \r\n    <script>\r\n");
                WriteLiteral("       \r\n      \r\n       \r\n        $(\".battery\").hide();\r\n        $(\".column\").hide();\r\n        $(\".elevator\").hide();\r\n        $(\".description\").hide();\r\n        $(\".btnform\").hide();\r\n");
                WriteLiteral(@"    $(""#battery"").prop(""disabled"", true);
   $(""#building"").change(function () {

    var  building= $(this).val();
   
    if (building) {
   
    $(""#battery"").prop(""disabled"", false);
     $("".battery"").show();

    } else 
        {
		 $(""#battery"").prop(""disabled"", true); 
        }
       
});
  
   $(""#battery"").change(function () {

    var  battery= $(this).val();
   
    if (building) {
   
    $(""#column"").prop(""disabled"", false);
     $("".column"").show();

    } else 
        {
		 $(""#column"").prop(""disabled"", true); 
        }
});

   $(""#column"").change(function () {

    var  column= $(this).val();
   
    if (column) {
   
    $(""#elevator"").prop(""disabled"", false);
     $("".elevator"").show();

    } else 
        {
		 $(""#elevator"").prop(""disabled"", true); 
        }
});


   $(""#elevator"").change(function () {

    var  elevator= $(this).val();
   
    if (elevator) {
   
    $(""#description"").prop(""disabled"", false);
     $("".descriptio");
                WriteLiteral(@"n"").show();
     $("".btnform"").show();


    } else 
        {
		 $(""#description"").prop(""disabled"", true); 
          $("".btnform"").hide();
        }
});

$(document).ready(function() {
  var choice = document.getElementById(""building"");
  choice.addEventListener(""change"", building);
});


// Battery dropDown
$(document).ready(function() {
  var choice = document.getElementById(""battery"");
  choice.addEventListener(""change"", battery);
});

var battery = function() {
  var choice = document.getElementById(""battery"").value;
  if (choice) {
    $("".column"").show();
    
  }else if(choice =="""") {
    $("".column"").hide();
    $(""#column"").prop(""disabled"", true);
    $("".elevator"").hide();
    $(""#elevator"").prop(""disabled"", true);
    }
};
// Column drop down menu
$(document).ready(function() {
  var choice = document.getElementById(""column"");
  choice.addEventListener(""change"", column);
});

var column = function() {
  var choice = document.getElementById(""column"").value");
                WriteLiteral(@";
  if (choice) {
    $("".elevator"").show();
  } else if(choice ==""""){
    $("".elevator"").hide();
    $(""#elevator"").prop(""disabled"", true);
  }
};

 $(""#formintervention"").submit(function(e) {
    e.preventDefault(); // prevent actual form submit
    var form = $(this);
    console.log(form);
    var url = ""https://restapisaadeddine.azurewebsites.net/api/GetAll""; //get submit url [replace url here if desired]
    $.ajax({
         type: ""POST"",
         url: url,
         data: JSON.stringify(form), // serializes form input
         success: function(data){
             console.log(data);
              
         }
    });
    window.location.href = ""/home/privacy"";
}); 





    

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
