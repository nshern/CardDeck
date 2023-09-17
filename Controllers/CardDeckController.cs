using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardDeckController : ControllerBase
    {
        private readonly ILogger<CardDeckController> _logger;
        private readonly CardDeck _cardDeck;

        public CardDeckController(ILogger<CardDeckController> logger)
        {
            _logger = logger;
            _cardDeck = new CardDeck();
        }

        [HttpGet(Name = "GetRandomCard")]
        public ActionResult Get()
        {
            var random = new Random();
            int index = random.Next(_cardDeck.Cards.Count);
            var card = _cardDeck.Cards[index];
            return Ok(new { card = card });
        }
    }
}
