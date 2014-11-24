using potato.Processors;

namespace potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User {Username = "dave", FirstName = "Dave", LastName = "Awesome", PotatoScore = 99};

            var userProcessor = new UserProcessor();
            var token = userProcessor.Login("dmw", "awesome");
        }
    }
}
