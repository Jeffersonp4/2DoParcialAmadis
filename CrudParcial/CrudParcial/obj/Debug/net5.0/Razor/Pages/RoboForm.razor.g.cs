#pragma checksum "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "898c22d115922e2e8902463d75c43ef601feda50"
// <auto-generated/>
#pragma warning disable 1591
namespace CrudParcial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using CrudParcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\_Imports.razor"
using CrudParcial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RoboForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RoboForm/{id:int}")]
    public partial class RoboForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Formulario</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                  ARobo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container-fluid");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(8, "<label class=\"col-sm-3\">Cedula</label>\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-sm-9");
                __Blazor.CrudParcial.Pages.RoboForm.TypeInference.CreateInputNumber_0(__builder2, 11, 12, "form-control", 13, 
#nullable restore
#line 17 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                                ARobo.Cedula

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.Cedula = __value, ARobo.Cedula)), 15, () => ARobo.Cedula);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(19, "<label class=\"col-sm-3\">Nombre</label>\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                              ARobo.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.Nombre = __value, ARobo.Nombre))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ARobo.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(30, "<label class=\"col-sm-3\">Fecha</label>\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-sm-9");
                __Blazor.CrudParcial.Pages.RoboForm.TypeInference.CreateInputDate_1(__builder2, 33, 34, "form-control", 35, 
#nullable restore
#line 33 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                              ARobo.Fecha

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.Fecha = __value, ARobo.Fecha)), 37, () => ARobo.Fecha);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(41, "<label class=\"col-sm-3\">Que_Robaron</label>\r\n            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                              ARobo.QueRobaron

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.QueRobaron = __value, ARobo.QueRobaron))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ARobo.QueRobaron));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(52, "<label class=\"col-sm-3\">valor_en_Dollar</label>\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-sm-9");
                __Blazor.CrudParcial.Pages.RoboForm.TypeInference.CreateInputNumber_2(__builder2, 55, 56, "form-control", 57, 
#nullable restore
#line 49 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                                ARobo.ValorDollar

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.ValorDollar = __value, ARobo.ValorDollar)), 59, () => ARobo.ValorDollar);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(63, "<label class=\"col-sm-3\">Donde_Ocurrio</label>\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                              ARobo.DondeOcurrio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.DondeOcurrio = __value, ARobo.DondeOcurrio))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ARobo.DondeOcurrio));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(74, "<label class=\"col-sm-3\">Latitud</label>\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-9");
                __Blazor.CrudParcial.Pages.RoboForm.TypeInference.CreateInputNumber_3(__builder2, 77, 78, "form-control", 79, 
#nullable restore
#line 65 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                                ARobo.Latitud

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.Latitud = __value, ARobo.Latitud)), 81, () => ARobo.Latitud);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(85, "<label class=\"col-sm-3\">Longitud</label>\r\n            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-sm-9");
                __Blazor.CrudParcial.Pages.RoboForm.TypeInference.CreateInputNumber_4(__builder2, 88, 89, "form-control", 90, 
#nullable restore
#line 73 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                                ARobo.Logintud

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ARobo.Logintud = __value, ARobo.Logintud)), 92, () => ARobo.Logintud);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n        ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group row mb-1");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-sm-12");
                __builder2.OpenElement(98, "button");
                __builder2.AddAttribute(99, "class", "btn btn-primary");
                __builder2.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
                                                          Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(101, " Guardar ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\RoboForm.razor"
       

    [Parameter]
    public int Id { get; set; }

    TablaRobo ARobo = new TablaRobo();
    public string url = "api/TablaRoboes";
    Response<object> respuesta = new Response<object>();
    Response<TablaRobo> respuestaEdita = new Response<TablaRobo>();

    private async Task Save()
    {
        if (Id != 0)
        {
            var Arespuesta = await Http.PutAsJsonAsync<object>(url, ARobo);

            respuesta = Arespuesta.Content.ReadFromJsonAsync<Response<object>>().Result;
        }
        else
        {
            var Arespuesta = await Http.PostAsJsonAsync<TablaRobo>(url, ARobo);

            respuesta = Arespuesta.Content.ReadFromJsonAsync<Response<object>>().Result;
        }


        navegar.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            respuestaEdita = await Http.GetFromJsonAsync<Response<TablaRobo>>(url+"/"+Id);

            ARobo = respuestaEdita.ls;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navegar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.CrudParcial.Pages.RoboForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
