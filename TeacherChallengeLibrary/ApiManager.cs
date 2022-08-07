using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherChallengeLibrary;

public class ApiManager
{
    public event EventHandler<DoApiCallEventArgs> APICallMade;

    protected virtual void OnDoApiCall(DoApiCallEventArgs e)
    {
        EventHandler<DoApiCallEventArgs> eventHandler = APICallMade;
        eventHandler?.Invoke(this, e);
    }

    /// <summary>
    /// Mock api call, the method itself doesn't really matter,
    /// the challenge is how to alert the user something happened from inside this method
    /// Hint - Console.WriteLine() does not belong in here.
    /// We want that logic only inside of the Console project.
    /// Think of it this way, we have 2 UI projects
    /// (Console and WinForms) and we want to be able to alert the user.
    /// If we just said Console.WriteLine
    /// we wouldn't be able to alert the user in the WinForms proj and vice versa.
    /// </summary>
    public void DoApiCall()
    {
        //Doing an api call....
        var client = new HttpClient();
        var args = new DoApiCallEventArgs();
        var goodURL = "https://github.com";
        var badURL = "https://github.com/johndward01232323323";
        var response = client.GetAsync(goodURL).Result;

        args.AlertMessage = response.ToString();
        args.StatusCode = response.StatusCode.ToString().ToLower() switch
        {
            "ok" => StatusCode.Success,
            "404" => StatusCode.Error,
            "notfound" => StatusCode.Error,
            _ => StatusCode.Information,
        };

        OnDoApiCall(args);

        //OOOPS, something went wrong, or maybe it went right,
        //maybe I just need to let the user know something,
        //I need to tell the user in the console...
        //But HOW? That logic is in my ConsoleLogging class in the Console project
        //This method may need to change drastically or not very much I am interested in your solution!

        //Solution goes below
    }
}
