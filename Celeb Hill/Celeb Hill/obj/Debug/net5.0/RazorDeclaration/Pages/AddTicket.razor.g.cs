// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Celeb_Hill.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Celeb_Hill;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Celeb_Hill.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\_Imports.razor"
using Celeb_Hill.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\Pages\AddTicket.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addticket")]
    public partial class AddTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "E:\COURSES\Diploma\Celeb Hill\Celeb Hill\Pages\AddTicket.razor"
       
    Concert conc;
    CurrencyCourse course;


    protected override async Task OnInitializedAsync()
    {
        course = new CurrencyCourse();

        var response = await http.GetStringAsync("http://192.168.56.1:3000/getcourse");
        course = JsonConvert.DeserializeObject<CurrencyCourse>(response);

        conc.courseOfUSD = course.Course;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        conc = new Concert();
    }


    private float getPriceBYN()
    {
        conc.priceBYN = conc.priceUSD * course.Course;
        return conc.priceBYN;
    }


    protected async Task submitForm()

    {
        Concert conc = new Concert();
      

        await http.PostAsJsonAsync<Concert>("http://localhost:10000/api/TickeT/addTickeT", conc);
        NavManager.NavigateTo("/ticketsconcerts");
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
