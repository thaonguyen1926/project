

using System;

public class UserInfo {
    private String UserID;
    private String Password;

    public UserInfo(string v1, string v2)
    {
    }

    public String getUserID() {
        return UserID;
    }

    public void setUserID(String UserID) {
        this.UserID = UserID;
    }

    public String getPassword() {
        return Password;
    }

    public void setPassword(String Password) {
        this.Password = Password;
    }

    internal void setUserName(string v)
    {
        throw new NotImplementedException();
    }
}
