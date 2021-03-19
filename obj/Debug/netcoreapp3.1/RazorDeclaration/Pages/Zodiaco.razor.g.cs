#pragma checksum "/home/brahiam/ProgIII/Homework7/Pages/Zodiaco.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c876e5ce77512aa6b7e4dd9f838671c462d2f67"
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
    using System.Linq;
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
#line 2 "/home/brahiam/ProgIII/Homework7/Pages/Zodiaco.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zodiaco")]
    public partial class Zodiaco : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/home/brahiam/ProgIII/Homework7/Pages/Zodiaco.razor"
       
    List<Personas> People() => new vacunasContext(options).Personas.ToList();


    protected override async Task OnInitializedAsync()
    {

        await chargeTable();
    }

    string zodiacSign(DateTime date)
    {

        string sign = "";

        if (date.Month > 2 && date.Day > 20 || date.Month < 5 && date.Day < 21)
        {

            sign = "Aries";
        }
        else if (date.Month > 3 && date.Day > 20 || date.Month < 6 && date.Day < 21)
        {

            sign = "Tauro";
        }
        else if (date.Month > 4 && date.Day > 20 || date.Month < 7 && date.Day < 21)
        {

            sign = "Geminis";
        }
        else if (date.Month > 5 && date.Day > 20 || date.Month < 8 && date.Day < 21)
        {

            sign = "Cancer";
        }
        else if (date.Month > 6 && date.Day > 20 || date.Month < 9 && date.Day < 22)
        {

            sign = "Leo";
        }
        else if (date.Month > 7 && date.Day > 21 || date.Month < 10 && date.Day < 23)
        {

            sign = "Virgo";
        }
        else if (date.Month > 8 && date.Day > 22 || date.Month < 11 && date.Day < 23)
        {

            sign = "Libra";
        }
        else if (date.Month > 9 && date.Day > 22 || date.Month < 12 && date.Day < 23)
        {

            sign = "Escorpio";
        }
        else if (date.Month > 10 && date.Day > 22 || date.Month < 13 && date.Day < 21)
        {

            sign = "Sagitario";
        }
        else if (date.Month == 12 && date.Day > 20 || date.Month < 2 && date.Day < 20)
        {

            sign = "Capricornio";
        }
        else if (date.Month > 0 && date.Day > 19 || date.Month < 3 && date.Day < 19)
        {

            sign = "Acuario";
        }
        else
        {

            sign = "Piscis";
        }

        return sign;
    }

    Dictionary<string, int> Zodiac = new Dictionary<string, int>();

    async Task chargeTable()
    {
        int aries = 0;
        int tauro = 0;
        int geminis = 0;
        int cancer = 0;
        int leo = 0;
        int virgo = 0;
        int libra = 0;
        int escorpio = 0;
        int sagitario = 0;
        int capricornio = 0;
        int acuario = 0;
        int piscis = 0;

        foreach (var person in People())
        {

            if (zodiacSign(person.FechaNacimiento) == "Aries")
            {

                aries++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Tauro")
            {

                tauro++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Geminis")
            {

                geminis++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Cancer")
            {

                cancer++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Leo")
            {

                leo++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Virgo")
            {

                virgo++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Libra")
            {

                libra++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Escorpio")
            {

                escorpio++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Sagitario")
            {

                sagitario++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Capricornio")
            {

                capricornio++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Acuario")
            {

                acuario++;
            }
            else if (zodiacSign(person.FechaNacimiento) == "Piscis")
            {
                piscis++;
            }
        }
        Zodiac.Add("Aries", aries);
        Zodiac.Add("Tauro", tauro);
        Zodiac.Add("Geminis", geminis);
        Zodiac.Add("Cancer", cancer);
        Zodiac.Add("Leo", leo);
        Zodiac.Add("Virgo", virgo);
        Zodiac.Add("Libra", libra);
        Zodiac.Add("Escorpio", escorpio);
        Zodiac.Add("Sagitario", sagitario);
        Zodiac.Add("Capricornio", capricornio);
        Zodiac.Add("Acuario", acuario);
        Zodiac.Add("Piscis", piscis);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<vacunasContext> options { get; set; }
    }
}
#pragma warning restore 1591
