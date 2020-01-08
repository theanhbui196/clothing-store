namespace ClothingStore.Data
{
    public class CommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
    }
}