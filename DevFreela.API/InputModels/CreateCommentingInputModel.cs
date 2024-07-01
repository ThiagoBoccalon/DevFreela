namespace DevFreela.API.InputModels
{
    public class CreateCommentingInputModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
