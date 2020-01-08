using ClothingStore.Data;
using System;
using System.Threading.Tasks;

namespace ClothingStore
{
    public class InsertProductCommandHandler : ICommandHandler<InsertProductCommand>
    {
        private readonly IProductCommandRespository _productCommandRepository;
        public InsertProductCommandHandler(IProductCommandRespository productCommandRepository)
        {
            _productCommandRepository = productCommandRepository;
        }

        public async Task<ICommandResult> ExecuteAsync(InsertProductCommand command)
        {
            _productCommandRepository.Add(new Product
            {
                ProductName = command.ProductName,
                ColorTypeId = command.ColorTypeId,
                ProductTypeId = command.ProductTypeId,
                SellingPrice = command.SellingPrice,
                SizeTypeId = command.SizeTypeId,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("29fd3191-f5b0-4772-b521-f5cf25836953"),
                CreatedDate = DateTime.Now
            });

            await _productCommandRepository.SaveChangesAsync();

            return new CommandResult()
            {
                Success = true
            };
        }
    }
}