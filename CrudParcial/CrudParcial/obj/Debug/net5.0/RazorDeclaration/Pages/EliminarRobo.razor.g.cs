// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\EliminarRobo.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\EliminarRobo.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\EliminarRobo.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarRobo/{Id:int}")]
    public partial class EliminarRobo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\jpayano\Desktop\Git para subir\CrudParcial\CrudParcial\Pages\EliminarRobo.razor"
       
    [Parameter]
    public int Id { get; set; }
    public string url = "api/TablaRoboes";
    Response<object> respuesta = new Response<object>();

    private void Cancelar() => navegar.NavigateTo("/");

    private async Task Eliminar()
    {
        var Arespuesta = await Http.DeleteAsync(url+"/"+Id);
        respuesta = Arespuesta.Content.ReadFromJsonAsync<Response<object>>().Result;



        navegar.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navegar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591