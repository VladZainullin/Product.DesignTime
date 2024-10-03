namespace Application.Contracts.Features.Products.Commands.UpdateProduct;

public sealed class UpdateProductBodyDto
{
    public required string Title { get; init; }
    
    public required string Description { get; init; }
}