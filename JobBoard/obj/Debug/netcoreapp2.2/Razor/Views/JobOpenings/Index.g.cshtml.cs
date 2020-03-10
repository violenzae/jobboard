#pragma checksum "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9440dab2ba0d650a5182731b96481448fd2a007d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOpenings_Index), @"mvc.1.0.view", @"/Views/JobOpenings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobOpenings/Index.cshtml", typeof(AspNetCore.Views_JobOpenings_Index))]
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
#line 1 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
using JobBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9440dab2ba0d650a5182731b96481448fd2a007d", @"/Views/JobOpenings/Index.cshtml")]
    public class Views_JobOpenings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 25, true);
            WriteLiteral("\n<h1>Job Board</h1>\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(74, 40, true);
            WriteLiteral("  <p>There are no jobs in the list.</p>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
}

#line default
#line hidden
            BeginContext(116, 11, true);
            WriteLiteral("</ul>\n<ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
   foreach (JobOpening item in Model)
  {

#line default
#line hidden
            BeginContext(169, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(178, 10, false);
#line 13 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(188, 13, true);
            WriteLiteral("</li>\n    <p>");
            EndContext();
            BeginContext(202, 16, false);
#line 14 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
  Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(218, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
  
    }

#line default
#line hidden
            BeginContext(232, 3, true);
            WriteLiteral("  \n");
            EndContext();
#line 18 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
   foreach (Contact citem in Model)
    {

#line default
#line hidden
            BeginContext(277, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(288, 10, false);
#line 20 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
     Write(citem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(298, 16, true);
            WriteLiteral("</li>\n      <li>");
            EndContext();
            BeginContext(315, 11, false);
#line 21 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
     Write(citem.Email);

#line default
#line hidden
            EndContext();
            BeginContext(326, 16, true);
            WriteLiteral("</li>\n      <li>");
            EndContext();
            BeginContext(343, 11, false);
#line 22 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
     Write(citem.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(354, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 23 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/JobOpenings/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(366, 53, true);
            WriteLiteral("</ul>\n\n<a href=\"/jobopenings/new\">Add a new item.</a>");
            EndContext();
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