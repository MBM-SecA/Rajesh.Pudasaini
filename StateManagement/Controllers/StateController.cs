using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
public class StateController : Controller {

    public ViewResult FirstCookie(){
        // Statemanagement
        // 1. Client side
        // 1.1 Cookies
        Response.Cookies.Append("user", "rajesh");

        //1.2 Query String

        // Server Side State Management
        HttpContext.Session.SetString("Name", "Rajesh");

        TempData["College Name"] = "MBM College";
        return View();

    }

    public ViewResult Third() {
        var address = HttpContext.Session.GetString("Name");
        var collegeName = TempData["CollegeName"];

        ViewData["Name"] = "abc from viewData";
        ViewBag.name = "abce from viewBag";
        return View(55);
    }

    [HttpPost]
    public bool SecondQueryString(string collegeName) { //hidden input

        return true;
    }

    // 

}