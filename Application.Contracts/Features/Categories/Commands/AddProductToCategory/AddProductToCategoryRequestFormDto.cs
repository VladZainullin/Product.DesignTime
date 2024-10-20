// ReSharper disable UnusedAutoPropertyAccessor.Global

using Microsoft.AspNetCore.Http;

namespace Application.Contracts.Features.Categories.Commands.AddProductToCategory;

public sealed class AddProductToCategoryRequestFormDto
{
    public required string Title { get; init; }

    public required IFormFile Photo { get; init; }
}