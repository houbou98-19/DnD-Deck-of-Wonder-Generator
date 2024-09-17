using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CardGenerator.Web.Models;
using CardGenerator.Application.Interfaces;
using CardGenerator.Application.DTO;

namespace CardGenerator.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICardService _cardService;

    public HomeController(ILogger<HomeController> logger, ICardService cardService)
    {
        _logger = logger;
        _cardService = cardService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult DrawCard()
    {
        var card = _cardService.DrawCard();
        var cardViewModel = new CardViewModel
        {
            Number = card.Number,
            Name = card.Name,
            Suit = card.Suit,
            Effect = card.Effect
        };
        return View(cardViewModel);
    }   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
