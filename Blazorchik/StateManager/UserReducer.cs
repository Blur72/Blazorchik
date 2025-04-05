using Fluxor;

namespace Blazorchik.StateManager
{
    public static class UserReducers
    {
        [ReducerMethod]
        public static UserState SetAuthenticatedUser(UserState state, SetAuthenticatedUserAction action)
        {
            var userState = new UserState(action.UserId, action.UserName);
            return userState;
        }

        [ReducerMethod]
        public static UserState ClearAuthenticatedUser(UserState state, ClearAuthenticatedUserAction action)
        {
            var userState = new UserState(null, null);
            return userState;
        }
    }
    public record SetAuthenticatedUserAction(string UserId, string UserName);
    public record ClearAuthenticatedUserAction;
}