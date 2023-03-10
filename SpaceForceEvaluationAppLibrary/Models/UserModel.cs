namespace SpaceForceEvaluationAppLibrary.Models;

public class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ObjectIdentifier { get; set; }
    public string userID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    //public string password { get; set; }
    public string rank { get; set; }
    public string teamID { get; set; }
    public string job { get; set; }
    public DateTime dailyDate { get; set; }
    public DateTime weeklyDate { get; set; }
    public DateTime monthlyDate { get; set; }

    public List<String> surveyHistory { get; set; }
    public List<String> reportHistory { get; set; }
    public string feedbackTableID { get; set; }
    public int surveyCounter { get; set; }
    public List<String> flags { get; set; }
}
