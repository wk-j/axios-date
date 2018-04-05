namespace AxiosDate.Controllers

open Microsoft.AspNetCore.Mvc
open System

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
