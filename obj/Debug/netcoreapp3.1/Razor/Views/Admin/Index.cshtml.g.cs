#pragma checksum "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8484260383a0e28cd80f0a40b48f43c32c49fd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "D:\code\c++\data\WebHomework\Views\_ViewImports.cshtml"
using WebHomework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\c++\data\WebHomework\Views\_ViewImports.cshtml"
using WebHomework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8484260383a0e28cd80f0a40b48f43c32c49fd8", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0513c8cd19dec1f136246739c5e79fbed96061ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<object, IEnumerable<object>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""mybackground table-responsive"">
    <ul class=""nav nav-tabs nav-justified"">
        <li class=""active"" role=""presentation""><a href=""#emp"" data-toggle=""tab"" class=""btn btn-outline-light"" role=""button"">员工信息</a></li>
        <li role=""presentation""><a href=""#dep"" data-toggle=""tab"" class=""btn btn-outline-light"" role=""button"">部门信息</a></li>
        <li role=""presentation""><a href=""#move"" data-toggle=""tab"" class=""btn btn-outline-light"" role=""button"">调动信息</a></li>
        <li role=""presentation""><a href=""#find"" data-toggle=""tab"" class=""btn btn-outline-light"" role=""button"">查询员工</a></li>
        <li role=""presentation""><a href=""#add"" data-toggle=""tab"" class=""btn btn-outline-light"" role=""button"">添加操作</a></li>
        <li role=""presentation""><a href=""#put"" data-toggle=""tab"" class=""btn btn-outline-light"" role=""button"">查看申请</a></li>
    </ul>
    <div class=""tab-content"">
        <div class=""tab-pane active"" id=""emp"">
            <table class=""table table-hover "">
                <caption>员工信息</ca");
            WriteLiteral(@"ption>
                <thead>
                    <tr>
                        <th>工号</th>
                        <th>姓名</th>
                        <th>工作状态</th>
                        <th>入职时间</th>
                        <th>工作岗位</th>
                        <th>职务</th>
                        <th>部门编号</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                      
                        var em = (IEnumerable<Employee>)Model["emp"];
                        foreach (var i in em)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.WorkStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.DepId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2157, "\"", 2224, 1);
#nullable restore
#line 44 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2164, Url.Action("EditorEmployee", "admin", new { id = i.EmpId }), 2164, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">编辑</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 47 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"


                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>

            </table>
        </div>
        <div class=""tab-pane"" id=""dep"">
            <table class=""table table-hover "">
                <caption>部门信息</caption>
                <thead>
                    <tr>
                        <th>部门编号</th>
                        <th>部门姓名</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 65 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                      
                        var dep = (IEnumerable<Department>)Model["dep"];
                        foreach (var i in dep)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 70 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.DepId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 73 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""tab-pane"" id=""move"">
            <table class=""table table-hover "">
                <caption>调动信息</caption>
                <thead>
                    <tr>
                        <th>ID号</th>
                        <th>员工工号</th>
                        <th>调动日期</th>
                        <th>原部门</th>
                        <th>现部门</th>
                        <th>调动原因</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 92 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                      
                        var MD = (IEnumerable<MoveDep>)Model["moveDep"];
                        foreach (var i in MD)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 97 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 98 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 99 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 100 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.DepForm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 101 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.DepTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 102 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Reason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 104 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>

            </table>
        </div>
        <div class=""tab-pane"" id=""find"">
            <div class=""form-group"">
                <label>ID号：</label>
                <input type=""text"" class=""col-auto"" id=""name"" placeholder=""001"">
                <button onclick=""ajaxbtn()"" class=""btn btn-outline-primary"">查询</button>
            </div>
            <div>
                <table class=""table table-hover"">
                    <caption>员工信息</caption>
                    <thead>
                        <tr>
                            <th>工号</th>
                            <th>姓名</th>
                            <th>工作状态</th>
                            <th>入职时间</th>
                            <th>工作岗位</th>
                            <th>职务</th>
                            <th>部门编号</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id=""tr1""></tr>
                    </tbody>
                <");
            WriteLiteral(@"/table>
            </div>
            <div>
                <table class=""table table-hover "">
                    <caption>调动信息</caption>
                    <thead>
                        <tr>
                            <th>ID号</th>
                            <th>员工工号</th>
                            <th>调动日期</th>
                            <th>原部门</th>
                            <th>现部门</th>
                            <th>调动原因</th>
                        </tr>
                    </thead>
                    <tbody id=""tb1"">
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""tab-pane"" id=""add"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8484260383a0e28cd80f0a40b48f43c32c49fd815200", async() => {
                WriteLiteral(@"

                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">员工ID号：</label>
                    <div class=""col-sm-6"">
                        <input name=""EmpId"" class=""form-control"">
                    </div>
                </div>

                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">姓名：</label>
                    <div class=""col-sm-6"">
                        <input name=""Name"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">工作状态：</label>
                    <div class=""col-sm-6"">
                        <input name=""State"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">入职时间：</label>
                    <div class=""col-sm-6"">
       ");
                WriteLiteral(@"                 <input name=""WorkStart"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">岗位：</label>
                    <div class=""col-sm-6"">
                        <input name=""Job"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">职务：</label>
                    <div class=""col-sm-6"">
                        <input name=""Position"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">部门ID号：</label>
                    <div class=""col-sm-6"">
                        <input name=""DepId"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
               ");
                WriteLiteral(@"     <label class=""col-sm-2 col-form-label"">登录账号：</label>
                    <div class=""col-sm-6"">
                        <input name=""UserName"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label"">密码：</label>
                    <div class=""col-sm-6"">
                        <input name=""Passward"" class=""form-control"">
                    </div>
                </div>

                <div class=""form-group row"">
                    <div>
                        <button type=""submit"" class=""btn btn-primary col-auto"">添加</button>
                        <a");
                BeginWriteAttribute("href", " href=\"", 8890, "\"", 8939, 1);
#nullable restore
#line 215 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
WriteAttributeValue("", 8897, Url.Action("index","admin",new {p=Model}), 8897, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">返回</a>\r\n                    </div>\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            WriteLiteral(@"

        </div>
        <div class=""tab-pane"" id=""put"">
            <table class=""table table-hover "">
                <caption>申请信息</caption>
                <thead>
                    <tr>
                        <th>ID号</th>
                        <th>员工ID号</th>
                        <th>申请成功后工作状态</th>
                        <th>申请原因/申请调动部门</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 234 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                  
                    var ap = (IEnumerable<Apply>)Model["apply"];
                    foreach (var i in ap)
                    {
                        if (i.IsSure == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 241 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 242 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 243 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.StateChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 244 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                               Write(i.Reason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10061, "\"", 10084, 3);
            WriteAttributeValue("", 10071, "btnOn1(", 10071, 7, true);
#nullable restore
#line 246 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
WriteAttributeValue("", 10078, i.Id, 10078, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10083, ")", 10083, 1, true);
            EndWriteAttribute();
            WriteLiteral(">同意</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10232, "\"", 10255, 3);
            WriteAttributeValue("", 10242, "btnOn2(", 10242, 7, true);
#nullable restore
#line 249 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
WriteAttributeValue("", 10249, i.Id, 10249, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10254, ")", 10254, 1, true);
            EndWriteAttribute();
            WriteLiteral(">不同意</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 252 "D:\code\c++\data\WebHomework\Views\Admin\Index.cshtml"
                        }

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>

            </table>
        </div>
   
</div>
</div>

<script type=""text/javascript"">
    window.onload = function () {
        this.document.getElementById(""loginIndex"").text=""admin"";
    }
    function ajaxbtn() {
        $.ajax({
            url: ""/admin/Find"",
            data:{ ""text"": document.getElementById(""name"").value },
            type: ""post"",
            dataType: ""text"",
            success: function (data) {
                $(""#tr1"").empty();
                $(""#tb1"").empty();
                if (data == null) alert(""输入ID号有误！"");
                else {
                    var tr = document.getElementById(""tr1"");
                    var strs = new Array();
                    strs = data.split("" "");
                    for (i = 0; i < 7; i++)
                        $(""#tr1"").append(""<td>"" + strs[i] + ""</td>"");
                    for (var i = 7, j = 0; i < strs.length; i++) {
                        if ((i - 7) % 6 == 0) {
               ");
            WriteLiteral(@"             j++;
                            $(""#tb1"").append(""<tr id=\""tr2"" + j + ""\""></tr>"");
                        }
                        $(""#tr2""+j).append(""<td>"" + strs[i] + ""</td>"");
                    }

                }
            }
        });
    }
    function btnOn1(data) {
        var flag = confirm(""确定同意吗？"")
        if (flag) {
            location.href = ""/admin/applySure?id="" + data + ""&flag=true"";
        }
    }
    function btnOn2(data) {
        var flag = confirm(""确定不同意吗？"")
        if (flag) {
            location.href = ""/admin/applySure?id="" + data + ""&flag=false"";
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<object, IEnumerable<object>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
