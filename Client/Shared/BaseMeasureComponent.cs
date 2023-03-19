using Microsoft.AspNetCore.Components;

namespace BlazorAppBenchmark.Client.Shared
{
    public class BaseMeasureComponent : ComponentBase
    {
        protected virtual string Message => "Component render";

        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }
        protected override void OnAfterRender(bool firstRender)
        {
            if(!firstRender)
            {
                Console.WriteLine(Message);
            }
            base.OnAfterRender(firstRender);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
