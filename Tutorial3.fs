namespace HelloFSharp.Tutorial3

open System
open System.Net

module DownloadWebpage =
    let fetchUrl callback url =
        let request = WebRequest.Create(Uri(url))
        use requestResponse = request.GetResponse()
        use stream = requestResponse.GetResponseStream()
        use reader = new IO.StreamReader(stream)
        callback reader url