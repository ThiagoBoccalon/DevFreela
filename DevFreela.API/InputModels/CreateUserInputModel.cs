namespace DevFreela.API.InputModels
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }
    }
}
