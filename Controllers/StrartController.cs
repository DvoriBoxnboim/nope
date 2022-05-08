using Microsoft.AspNetCore.Mvc;
using RestSharp;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Caching;
using RestApiClient;


namespace Comparison.Controllers;

[ApiController]
[Route("[controller]")]
public class StartController : ControllerBase
{
    [HttpPost]
    public ActionResult Try()
    {
        var client = new RestClient("https://api.superget.co.il");


        var signInRequest = new RestRequest("comparisn/Try");

        signInRequest.AddQueryParameter("action", "TestFunction");
        signInRequest.AddQueryParameter("api_key", "d73d5bcf5f6705b9425c5022b65e4aa07d0e7896");


       // var response = client.Post(signInRequest);

        var response = client.Post(signInRequest);
        return response.Content;


    }

}