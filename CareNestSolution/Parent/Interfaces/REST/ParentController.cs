using System.Net.Mime;
using CareNestSolution.Parent.Domain.Model.Queries;
using CareNestSolution.Parent.Domain.Services;
using CareNestSolution.Parent.Interfaces.REST.Resources;
using CareNestSolution.Parent.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
namespace CareNestSolution.Parent.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Parent Endpoints")]
public class ParentController : ControllerBase
{
    private readonly IParentQueryService parentQueryService;
    private readonly IParentCommandService parentCommandService;

    public ParentController(IParentQueryService parentQueryService, IParentCommandService parentCommandService)
    {
        this.parentQueryService = parentQueryService;
        this.parentCommandService = parentCommandService;
    }
    
    
    [HttpGet("{parentId:int}")]
    [SwaggerOperation(
        Summary = "Get a Parent by id",
        Description = "Get a Parent by id",
        OperationId = "GetParentById"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "The parent was successfully retrieved", typeof(ParentResource))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "The parent was not found")]
   public async Task<IActionResult> GetParentById(int parentId)
   {
       var getParentByIdQuery = new GetParentByIdQuery(parentId);
       var parent = await parentQueryService.Handle(getParentByIdQuery);

       if (parent is null) return NotFound();

       var parentResource = ParentResourceFromEntityAssembler.ToResourceFromEntity(parent);

       return Ok(parentResource);
   }

        
        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a Parent",
            Description = "Create a Parent",
            OperationId = "CreateParent"
        )]
        [SwaggerResponse(StatusCodes.Status201Created, "The Parent was successfully created", typeof(ParentResource))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "The Parent was not created")]
        public async Task<IActionResult> CreateParent([FromBody] CreateParentResource resource)
        {
            var createParentCommand = CreateParentCommandFromResourceAssembler.ToCommandFromResource(resource);
        
            var parent = await parentCommandService.Handle(createParentCommand);
            
            if (parent is null) return BadRequest();
            
            var parentResource = ParentResourceFromEntityAssembler.ToResourceFromEntity(parent);
            
            return CreatedAtAction(nameof(GetParentById), new { parentId = parent.Id }, parentResource);
        }

        
        [HttpGet]
        [SwaggerOperation(
            Summary = "Get all parents",
            Description = "Get all parents",
            OperationId = "GetAllParents"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The Inventories were successfully retrieved", typeof(IEnumerable<ParentResource>))]
        public async Task<IActionResult> GetAllParents()
        {
            var getAllParentsQuery = new GetAllParentsQuery();
            var parents = await parentQueryService.Handle(getAllParentsQuery);
            var parentResources = parents.Select(ParentResourceFromEntityAssembler.ToResourceFromEntity);
            
            return Ok(parentResources);
        }
}