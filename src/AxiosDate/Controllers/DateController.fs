namespace AxiosDate.Controllers

open Microsoft.AspNetCore.Mvc
open System

[<CLIMutable>]
type Data = {
    F1: DateTime
    F2: string
}

[<Route("/api/[controller]/[action]")>]
type DateController() =
    inherit Controller()

    [<HttpGet>]
    member __.GetObject() =
        { F1 = DateTime.Now
          F2 = "Hello" }

    [<HttpPost>]
    member __.SendObject([<FromBody>] data: Data) =
        printfn "%A" data
        printfn "%A" (data.F1.ToLocalTime())
        data
