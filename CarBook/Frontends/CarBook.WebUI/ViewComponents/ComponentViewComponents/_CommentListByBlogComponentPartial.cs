﻿
using CarBook.Dto.TagCloudDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.ComponentViewComponents
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //private readonly IHttpClientFactory _httpClientFactory;

        //public _CommentListByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}

        //public async Task<IViewComponentResult> InvokeAsync(int id)
        //{
        //    ViewBag.blogid = id;
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:33741/api/Comments/CommentListByBlog?id=" + id);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
        //        return View(values);
        //    }

        //    return View();
        //}
    }

}
