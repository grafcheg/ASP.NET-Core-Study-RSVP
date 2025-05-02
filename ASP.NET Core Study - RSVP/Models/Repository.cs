namespace ASP.NET_Core_Study___RSVP.Models;

public static class Repository
{
    private static List<GuestResponse> guestResponses = new List<GuestResponse>();
    public static IEnumerable<GuestResponse> Responses => guestResponses;

    public static void AddGuestResponse(GuestResponse guestResponse)
    {
        guestResponses.Add(guestResponse);
    }
}