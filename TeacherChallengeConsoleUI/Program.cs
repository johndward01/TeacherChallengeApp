using TeacherChallengeLibrary;

namespace TeacherChallengeConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {
        ApiManager apiManager = new ApiManager();
        apiManager.APICallMade += apiManager_ApiCalled;

        apiManager.DoApiCall();
    }

    static void apiManager_ApiCalled(object sender, DoApiCallEventArgs e)
    {
        ConsoleLogging.PassMessage(e.AlertMessage, e.StatusCode);
    }
}