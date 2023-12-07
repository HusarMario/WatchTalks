using Microsoft.AspNetCore.Mvc.RazorPages;
using WatchTalks.Entities;
using WatchTalks.Interfaces;

namespace WatchTalks.Pages;

public class Index : PageModel
{
    private readonly ICrudOperationsAsync<Series> _repo;
    
    public Index(ICrudOperationsAsync<Series> repo)
    {
        _repo = repo;
    }
    
    public IReadOnlyList<Series> Series { get; private set; }
    
    public async Task OnGetAsync()
    {
        Series = await _repo.GetAllAsync();
    }
    
    public void OnGet()
    {
        
    }
}