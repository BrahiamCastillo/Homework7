#pragma checksum "/home/brahiam/ProgIII/Homework7/Pages/InyectadosProvincia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d770246a1e832edb39a7765cddfe3f6e3cf0bf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Homework7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Homework7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Homework7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/brahiam/ProgIII/Homework7/_Imports.razor"
using Homework7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/brahiam/ProgIII/Homework7/Pages/InyectadosProvincia.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/Homework7/Pages/InyectadosProvincia.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/Homework7/Pages/InyectadosProvincia.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inyectadosprovincia")]
    public partial class InyectadosProvincia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/home/brahiam/ProgIII/Homework7/Pages/InyectadosProvincia.razor"
       

    bool regulator = false;

    bool activate = false;
    string value;

    int val;

    List<Provincias> Provinces() => new vacunasContext(options).Provincias.ToList();

    EjsRadioButton radiobtn;  

    List<Auditorias> VaccinesPeople = null;
     public async void getSelectedValue() 
    { 
        value = await radiobtn.GetSelectedValue();

        val = Convert.ToInt32(value);

        VaccinesPeople = new vacunasContext(options).Auditorias.
        Where(w => w.ProvinciasId == val).OrderBy(o => o.PersonasId).ToList();

        activate = true; 
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<vacunasContext> options { get; set; }
    }
}
#pragma warning restore 1591
