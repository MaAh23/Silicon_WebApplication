using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.ViewModels;



namespace WebApp.Controllers;

[Authorize]
public class CoursesController(HttpClient httpClient) : Controller
{
    private readonly HttpClient _httpClient = httpClient;

    [Route("/courses")]
    public async Task<IActionResult> Index()
    {
        var viewModel = new CourseIndexViewModel();

        var resposne = await _httpClient.GetAsync("https://localhost:7242/api/courses");
        if (resposne.IsSuccessStatusCode)
        {
            var courses = JsonConvert.DeserializeObject<IEnumerable<CourseViewModel>>(await resposne.Content.ReadAsStringAsync());
            if (courses != null && courses.Any())
                viewModel.Courses = courses;
            
        }


        return View(viewModel);
    }
}
