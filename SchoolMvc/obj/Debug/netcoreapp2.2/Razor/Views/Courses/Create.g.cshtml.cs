#pragma checksum "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Courses/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142a89c15ea7b84b56f95065dbf81bf0d2cef68b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Create), @"mvc.1.0.view", @"/Views/Courses/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Create.cshtml", typeof(AspNetCore.Views_Courses_Create))]
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
#line 1 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/_ViewImports.cshtml"
using SchoolMvc;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/_ViewImports.cshtml"
using SchoolMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142a89c15ea7b84b56f95065dbf81bf0d2cef68b", @"/Views/Courses/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a1671dae5b634b359cac68238ad4af86e9b787", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolMvc.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Courses/Create.cshtml"
  
    ViewData["Title"] = "Create Course";

#line default
#line hidden
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(78, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Courses/Create.cshtml"
     using (Html.BeginForm())
    {

        

#line default
#line hidden
            BeginContext(125, 34, false);
#line 10 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Courses/Create.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(159, 98, true);
            WriteLiteral("<br>\n            <input data-val=\"true\"  required id=\"Name\" name=\"Name\" type=\"text\" value=\"\"><hr>\n");
            EndContext();
            BeginContext(268, 41, false);
#line 13 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Courses/Create.cshtml"
    Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(309, 198, true);
            WriteLiteral("<br>\n            <input data-val=\"true\"  required id=\"Description\" name=\"Description\" type=\"text\" value=\"\"><hr>\n        <input type=\"submit\" value=\"Add New Course\" class=\"btn btn-outline-success\"/>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/School.Solution/SchoolMvc/Views/Courses/Create.cshtml"
        
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolMvc.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
