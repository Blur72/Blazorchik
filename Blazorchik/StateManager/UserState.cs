using Fluxor;

namespace Blazorchik.StateManager
{
    [FeatureState]
    public class UserState
    {
        public string? UserId { get; init; }
        public string? UserName { get; init; }

        private UserState() { }

        public UserState(string userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }
    }
}