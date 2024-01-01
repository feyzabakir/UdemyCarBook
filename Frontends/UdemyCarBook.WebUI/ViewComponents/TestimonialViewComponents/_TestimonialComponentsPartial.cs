﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UdemyCarBook.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialComponentsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44303/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
             //   var values = JsonConvert.DeserializeObject<List<>>(jsonData); Testimonial
              //  return View(values);
            }
            return View();
        }
    }
}