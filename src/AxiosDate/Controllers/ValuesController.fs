namespace AxiosDate.Controllers

open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
[<ApiController>]
type ValuesController () =
    inherit ControllerBase()

    [<HttpGet>]
    member __.Get() =
        [|"value1"; "value2"|]

    [<HttpGet("{id}")>]
    member __.Get(id:int) =
        "value"

    [<HttpPost>]
    member __.Post([<FromBody>] value:string) =
        ()

    [<HttpPut("{id}")>]
    member __.Put(id:int, [<FromBody>] value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member __.Delete(id:int) =
        ()
