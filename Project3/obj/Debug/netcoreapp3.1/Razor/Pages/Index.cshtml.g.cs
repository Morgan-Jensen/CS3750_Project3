#pragma checksum "/Users/jacobgonzo/Documents/GitHub/CS3750_Project3/Project3/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8657ace7cbafcae9729ce8a278779f68c1054798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project3.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Project3.Pages
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
#line 1 "/Users/jacobgonzo/Documents/GitHub/CS3750_Project3/Project3/Pages/_ViewImports.cshtml"
using Project3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8657ace7cbafcae9729ce8a278779f68c1054798", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a267220003b564853750887c85b9849e08f45111", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("combowithtext"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("listGroups()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/jacobgonzo/Documents/GitHub/CS3750_Project3/Project3/Pages/Index.cshtml"
  
	ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8657ace7cbafcae9729ce8a278779f68c10547984463", async() => {
                WriteLiteral(@"
	<title>Project 3</title>
	<meta charset=""utf-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
	<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8657ace7cbafcae9729ce8a278779f68c10547985830", async() => {
                WriteLiteral("\n\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8657ace7cbafcae9729ce8a278779f68c10547986088", async() => {
                    WriteLiteral("\n\t\t<label for=\"user\">Username:</label><br>\n\t\t<input type=\"text\" id=\"user\" name=\"user\" value=\"John\"><br />\n\t\t<input type=\"submit\" value=\"Submit\">\n\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8657ace7cbafcae9729ce8a278779f68c10547987742", async() => {
                    WriteLiteral(@"

		<div class=""jumbotron text-center"">
			<div class=""container"">
				<div class=""col-sm-4"">
					<p>
						<label for=""Group"">Groups:</label>

						<select id=""mydropdown"" onChange=""showtext()"">
						</select>
					</p>

				</div>
				<div class=""col-sm-4"">
					<p>Add new item <button type=""button"" id=""newItemButton"">+</button></p>
					<p>Add new group <button type=""button"" id=""newGroupButton"">+</button></p>


				</div>
			</div>
		</div>
		<center>
			<div class=""container"">
				<textarea rows=8 cols=21 wrap=""virtual"" name=""text00"" id=""1"" onChange=""updateText('1')""></textarea>
				<textarea rows=8 cols=21 wrap=""virtual"" name=""text01"" id=""2""  onChange=""updateText('2')""></textarea>
				<textarea rows=8 cols=21 wrap=""virtual"" name=""text02"" id=""3"" onChange=""updateText('3')""></textarea>
			</div>
			<div class=""container"">
				<textarea rows=8 cols=21 wrap=""virtual"" name=""text10"" id=""4"" onChange=""updateText('4')""></textarea>
				<textarea rows=8 cols=21 wrap=""virtual"" name=""text11"" id=""5"" onChange=""update");
                    WriteLiteral("Text(\'5\')\"></textarea>\n\t\t\t\t<textarea rows=8 cols=21 wrap=\"virtual\" name=\"text12\" id=\"6\" onChange=\"updateText(\'6\')\"></textarea>\n\t\t\t</div>\n\t\t</center>\n\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	<p id=""demo""></p>
	<script>
		//http://www.javascriptkit.com/script/script2/combodescrip1.shtml used to help give us an idea of the boxes for
		//the combobox to populating items.
		var title = [""Group1"", ""Group2"", ""Group3""]; // Possible Values
		var shortcut = document.combowithtext;
		var descriptions = [];
		var currentGroupItems = [];
		var currentGroupItemDescNum = [];


		function listGroups() {
			var sel = document.getElementById('mydropdown') // find the drop down
			for (var i in title) { // loop through all elements
				var opt = document.createElement(""option""); // Create the new element
				opt.value = title[i]; // set the value
				opt.text = title[i]; // set the text
				sel.appendChild(opt); // add it to the select
			}
		}

		//function addGroup() {
		//	var sel = document.getElementById('mydropdown') // find the drop down
		//	var length = sel.options.length;
		//	for (i = length - 1; i >= 0; i--) {
		//		sel.options[i] = null;
		//	}

		//	var i = title.length + 1;
		//	title[title.length");
                WriteLiteral(@"] = ""Group"" + i;
		//	listGroups();
		//}


		function addItem() {
			var grpForItem = title[shortcut.mydropdown.selectedIndex];

			var i = descriptions.length + 1;
			descriptions[descriptions.length] = grpForItem + "", Item "" + i + "" description..."";

			showtext();
		}

		function showtext() {
			//var currentGroupItems = [];
			var grpForItem = title[shortcut.mydropdown.selectedIndex];

			var i;
			var j = 0;
			for (i = 0; i < descriptions.length; i++) {
				var str = descriptions[i];
				var n = str.indexOf("","");
				var grpNum = str.substr(0, n);
				var rest = str.substr(n + 1);
				if (grpNum == grpForItem) {
					currentGroupItems[j] = rest;
					currentGroupItemDescNum[j] = i;
					j++;
				}

			}
			for (j + 1; j < descriptions.length; j++) {
				currentGroupItems[j] = null;
				currentGroupItemDescNum[j] = null;
			}

			shortcut.text00.value = currentGroupItems[0];
			shortcut.text01.value = currentGroupItems[1];
			shortcut.text02.value = currentGroupItems[2];
			shortcut.text10.value = curre");
                WriteLiteral("ntGroupItems[3];\n\t\t\tshortcut.text11.value = currentGroupItems[4];\n\t\t\tshortcut.text12.value = currentGroupItems[5];\n\t\t}\n\n\t\n\t</script>\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
