using TeacherChallengeLibrary;

namespace TeacherChallengeConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApiManager apiManager = new ApiManager();

            apiManager.DoApiCall();
        }
    }
}